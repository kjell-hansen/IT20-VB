Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reloadTree()
    End Sub
    Private Sub reloadTree()
        'Töm trädvyn
        tvwArtister.Nodes.Clear()

        ' Hämta alla artister
        Dim dtArtister As DataTable = hamtaData("SELECT * FROM artists")

        ' Fyll trädvyn med artister
        fyllTrad(dtArtister, 0, Nothing, "Name", "ArtistId")

        ' Sortera listan
        tvwArtister.Sort()

    End Sub
    Private Sub fyllTrad(tabell As DataTable, parentId As Integer, nod As TreeNode, title As String, tag As String)
        ' Rekursiv funktion för att fylla trädet
        For Each row As DataRow In tabell.Rows
            ' Skapa en ny trädnode och sätta text
            Dim child As New TreeNode
            child.Text = row(title).ToString
            ' Sätt en tag som möjliggör sökning av "barn"
            child.Tag = tag & "=" & row(tag)

            If parentId = 0 Then
                ' Det är en rot-nod, lägg noden i trädvyn
                tvwArtister.Nodes.Add(child)
                ' Hämta information om artistens album
                Dim dtAlbum As DataTable = hamtaData("SELECT * from albums where " & child.Tag)
                fyllTrad(dtAlbum, row(tag), child, "Title", "AlbumId")
            Else
                ' Tilldela noden till ovanliggande nod
                nod.Nodes.Add(child)
            End If
        Next
    End Sub

    Private Sub tvwArtister_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles tvwArtister.NodeMouseClick
        lblNodTag.Text = e.Node.Tag
        If IsNothing(e.Node.Parent) Then
            ' Rot nod (artist) visa alla album
            showDataGrid("SELECT * FROM albums where " & e.Node.Tag)
            ' Förhindra att man kan lägga till låt
            btnNyLat.Enabled = False
        Else
            ' Albumnod, visa alla låtar
            showDataGrid("SELECT * FROM tracks where " & e.Node.Tag)
            ' Tillåt att man kan lägga tll låt
            btnNyLat.Enabled = True
        End If
    End Sub

    Private Sub showDataGrid(sql As String)
        ' Rensa befintlig data
        grdDetalj.DataSource = Nothing

        ' Hämta ny data
        grdDetalj.DataSource = hamtaData(sql)

        ' Autojustera för innehållet (och inte för rubrikerna)
        grdDetalj.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders

        ' Dölj id-kolumnen
        grdDetalj.Columns(0).Visible = False
    End Sub

    Private Sub btnNyArtist_Click(sender As Object, e As EventArgs) Handles btnNyArtist.Click

        If frmNyArtist.ShowDialog() = DialogResult.OK Then
            ' Ladda om trädvyn
            reloadTree()
        End If

    End Sub

    Private Sub btnNyttAlbum_Click(sender As Object, e As EventArgs) Handles btnNyttAlbum.Click
        If frmNyttAlbum.ShowDialog() = DialogResult.OK Then
            ' Ladda om trädvyn
            reloadTree()
        End If

    End Sub

    Private Sub btnNyLat_Click(sender As Object, e As EventArgs) Handles btnNyLat.Click
        If frmNyLat.ShowDialog() = DialogResult.OK Then
            MsgBox("OK")
        End If
    End Sub
End Class
