Public Class frmLista
    Private Sub frmLista_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmAdresser.Show()
    End Sub

    Private Sub frmLista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listItem As ListViewItem

        For i = 0 To dsAdresser.Tables("Adressbok").Rows.Count - 1
            listItem = lstAdresser.Items.Add(dsAdresser.Tables("Adressbok").Rows(i)("Id"))
            listItem.SubItems.Add(dsAdresser.Tables("Adressbok").Rows(i)("Fornamn"))
            listItem.SubItems.Add(dsAdresser.Tables("Adressbok").Rows(i)("Efternamn"))
            listItem.SubItems.Add(dsAdresser.Tables("Adressbok").Rows(i)("Adress"))
            listItem.SubItems.Add(dsAdresser.Tables("Adressbok").Rows(i)("Postnr"))
            listItem.SubItems.Add(dsAdresser.Tables("Adressbok").Rows(i)("Ort"))
        Next
    End Sub

    Private Sub lstAdresser_DoubleClick(sender As Object, e As EventArgs) Handles lstAdresser.DoubleClick
        ' Hämta markerad rad
        Dim rad As Integer = lstAdresser.SelectedIndices(0)

        ' Fyll formuläret med vald post
        frmAdresser.fyllFormular(rad)

        ' Stäng listan
        Me.Close()
    End Sub
End Class