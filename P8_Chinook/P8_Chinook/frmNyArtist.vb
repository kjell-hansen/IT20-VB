Public Class frmNyArtist
    Private dataAdapter As SQLite.SQLiteDataAdapter
    Private dbRow As DataRow
    Private ds As New DataSet
    Private Sub btnAngra_Click(sender As Object, e As EventArgs) Handles btnAngra.Click
        ' Svara att vi avbryter
        DialogResult = DialogResult.Cancel

        Me.Close()
    End Sub

    Private Sub btnSpara_Click(sender As Object, e As EventArgs) Handles btnSpara.Click
        ' Skapa dataadaptern och tilldela data via dataaskopplingen i modData
        dataAdapter = New SQLite.SQLiteDataAdapter("select * from Artists", cnChinook)

        ' Commandbuilder gör att vi slipper skriva insert/update-kod
        Dim commandBuilder As New SQLite.SQLiteCommandBuilder(dataAdapter)

        ' Fyll med innehåll
        dataAdapter.Fill(ds, "Artister")

        ' Skapa en ny rad och lägg till i datasettet
        dbRow = ds.Tables("Artister").NewRow
        ds.Tables("Artister").Rows.Add(dbRow)

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
        txtArtist.Text = ""
        btnSpara.Enabled = False
    End Sub

    Private Sub txtArtist_TextChanged(sender As Object, e As EventArgs) Handles txtArtist.TextChanged
        ' Aktivera spara knappen om texten inte är tom
        If txtArtist.Text <> "" Then
            btnSpara.Enabled = True
        Else
            btnSpara.Enabled = False
        End If
    End Sub
End Class