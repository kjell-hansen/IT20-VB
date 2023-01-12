Imports System.ComponentModel

Public Class frmNyArtist
    Private dataAdapter As SQLite.SQLiteDataAdapter
    Private dbRow As DataRow
    Private ds As New DataSet
    Public artistid As Integer = -1
    Private Sub btnAngra_Click(sender As Object, e As EventArgs) Handles btnAngra.Click
        ' Svara att vi avbryter
        DialogResult = DialogResult.Cancel

        Me.Close()
    End Sub

    Private Sub btnSpara_Click(sender As Object, e As EventArgs) Handles btnSpara.Click
        ' Commandbuilder gör att vi slipper skriva insert/update-kod
        Dim commandBuilder As New SQLite.SQLiteCommandBuilder(dataAdapter)

        ' Fyll raden med data från formuläret
        dbRow.Item("Name") = txtArtist.Text

        ' Uppdatera tabellen
        dataAdapter.Update(ds, "Artister")

        ' Meddela att allt är ok
        DialogResult = DialogResult.OK

        ' Stäng formuläret
        Me.Close()
    End Sub

    Private Sub frmNyArtist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblArtistid.Text = artistid

        ' Rensa datasettet
        ds.Clear()

        ' Hämta data från databasen om artistId <> -1
        If artistid <> -1 Then
            ' Skapa dataadaptern och tilldela data via dataaskopplingen i modData
            dataAdapter = New SQLite.SQLiteDataAdapter("select * from Artists where artistid=" & artistid, cnChinook)
            ' Fyll datasetet från dataadaptern
            dataAdapter.Fill(ds, "Artister")
            ' Läs in till en datarow
            dbRow = ds.Tables("Artister").Rows(0)
            txtArtist.Text = dbRow.Item("name")
            btnSpara.Enabled = True
            btnRadera.Visible = True
        Else
            ' Skapa dataadaptern och tilldela data via dataaskopplingen i modData
            dataAdapter = New SQLite.SQLiteDataAdapter("select * from Artists", cnChinook)
            ' Fyll datasetet från dataadaptern
            dataAdapter.Fill(ds, "Artister")
            ' Läs in till en datarow
            dbRow = ds.Tables("Artister").NewRow
            ' Lägg till raden till datasettet
            ds.Tables("Artister").Rows.Add(dbRow)
            txtArtist.Text = ""
            btnSpara.Enabled = False
            btnRadera.Visible = False
        End If
    End Sub

    Private Sub txtArtist_TextChanged(sender As Object, e As EventArgs) Handles txtArtist.TextChanged
        ' Aktivera spara knappen om texten inte är tom
        If txtArtist.Text <> "" Then
            btnSpara.Enabled = True
        Else
            btnSpara.Enabled = False
        End If
    End Sub

    Private Sub btnRadera_Click(sender As Object, e As EventArgs) Handles btnRadera.Click
        ' Skapa en commandbuilder
        Dim commandBuilder As New SQLite.SQLiteCommandBuilder(dataAdapter)

        ' Radera aktuell post och uppdatera dataadaptern
        ds.Tables("Artister").Rows(0).Delete()
        dataAdapter.Update(ds, "Artister")

        ' Returnera OK!
        DialogResult = DialogResult.OK

    End Sub

    Private Sub frmNyArtist_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ' Antag att nästa gång formuläret öppnas är det för att lägga till ny
        artistid = -1
    End Sub
End Class