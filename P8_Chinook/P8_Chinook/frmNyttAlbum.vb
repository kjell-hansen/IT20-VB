Public Class frmNyttAlbum
    Private Sub btnSpara_Click(sender As Object, e As EventArgs) Handles btnSpara.Click
        ' SKapa en dataadapter för koppling mot tabellen
        Dim dataAdapter As New SQLite.SQLiteDataAdapter("select * from albums", cnChinook)
        ' Skapa en commandbuilder för enklare hantering av insert/updates
        Dim commandBuilder As New SQLite.SQLiteCommandBuilder(dataAdapter)
        Dim dbRow As DataRow
        Dim ds As New DataSet

        ' Fyll adaptern
        dataAdapter.Fill(ds, "Album")

        ' Skapa en ny rad
        dbRow = ds.Tables("Album").NewRow

        ' Tilldela raden värden från formuläret
        dbRow.Item("title") = txtAlbum.Text
        dbRow.Item("artistid") = cboArtist.SelectedValue

        ' Lägg till raden i datasettet
        ds.Tables("Album").Rows.Add(dbRow)

        ' Uppdatera dataadaptern
        dataAdapter.Update(ds, "Album")

        ' Skicka tillbaka ok
        DialogResult = DialogResult.OK

    End Sub

    Private Sub btnAvbryt_Click(sender As Object, e As EventArgs) Handles btnAvbryt.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub frmNyttAlbum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Rensa textrutan
        txtAlbum.Text = ""

        ' Fyll comboboxen
        cboArtist.DataSource = hamtaData("select * from Artists order by name")
        cboArtist.DisplayMember = "name"
        cboArtist.ValueMember = "artistid"

        ' Disabla spara-knappen
        btnSpara.Enabled = False
    End Sub

    Private Sub txtAlbum_TextChanged(sender As Object, e As EventArgs) Handles txtAlbum.TextChanged
        If txtAlbum.Text = "" Then
            btnSpara.Enabled = False
        Else
            btnSpara.Enabled = True
        End If
    End Sub
End Class