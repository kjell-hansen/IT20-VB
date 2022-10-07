Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSumma.Text = ""
        lblMedel.Text = ""
        txtTal.Focus()
    End Sub

    Private Sub txtTal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTal.KeyPress
        ' TIllåt minustecken som första tecken
        If e.KeyChar = "-"c AndAlso sender.text <> "" Then
            e.Handled = True
        End If

        ' Tillåt punkt
        If e.KeyChar = "."c AndAlso InStr(sender.text, ".") > 0 Then
            e.Handled = True
        End If

        ' Tillåt siffror, punkt, minus och backspace
        If (e.KeyChar < "0"c OrElse e.KeyChar > "9"c) AndAlso e.KeyChar <> "."c AndAlso e.KeyChar <> "-"c AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnLaggTill_Click(sender As Object, e As EventArgs) Handles btnLaggTill.Click
        ' Förhindra att man kan lägga till tom
        If txtTal.Text = "" Then
            Exit Sub
        End If

        ' Lägg till talet i listrutan
        lstTal.Items.Add(txtTal.Text)

        'Gör en ny beräkning
        uppdateraBerakningar()

        ' Rensa inmatningsrutan
        txtTal.Text = ""
        txtTal.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If (MsgBox("Vill du verkligen sluta", vbYesNo + vbQuestion, "Rullande beräkning") = vbYes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnBorjaOm_Click(sender As Object, e As EventArgs) Handles btnBorjaOm.Click
        ' Töm listan
        lstTal.Items.Clear()

        ' Gör en ny beräkning
        uppdateraBerakningar()

        ' Töm inmatningsrutan
        txtTal.Text = ""
        txtTal.Focus()
    End Sub

    Private Sub btnTaBort_Click(sender As Object, e As EventArgs) Handles btnTaBort.Click
        ' Radera alla markerade tal
        For i = 0 To lstTal.SelectedItems.Count - 1
            raderaItem(lstTal.SelectedIndex)
        Next
    End Sub

    Private Sub uppdateraBerakningar()
        ' Sätt summa och medel tomt om det inte finns något i listan
        If lstTal.Items.Count = 0 Then
            lblSumma.Text = ""
            lblMedel.Text = ""
            Exit Sub
        End If

        ' Beräkna summan genom att loopa igenom listrutan
        Dim summa As Double
        For i = 0 To lstTal.Items.Count - 1
            summa = summa + Val(lstTal.Items(i))
        Next

        ' Beräkna medelvärdet mha summan och antalet items i listan
        Dim medel As Double
        medel = summa / lstTal.Items.Count

        ' Skriv ut summa och medelvärde
        lblSumma.Text = summa.ToString
        lblMedel.Text = medel.ToString

    End Sub


    Private Sub raderaItem(index As Integer)
        ' Ta bort markerat tal
        lstTal.Items.RemoveAt(index)

        ' Uppdatera beräkningen
        uppdateraBerakningar()

    End Sub

    Private Sub lstTal_KeyDown(sender As Object, e As KeyEventArgs) Handles lstTal.KeyDown
        ' Radera alla markerade tal om man trycker på Backspace eller Delete
        If lstTal.SelectedIndex <> -1 AndAlso (e.KeyCode = Keys.Back OrElse e.KeyCode = Keys.Delete) Then
            For i = 0 To lstTal.SelectedItems.Count - 1
                raderaItem(lstTal.SelectedIndex)
            Next
        End If
    End Sub

    Private Sub lstTal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTal.SelectedIndexChanged
        ' Tänd/släck ta bort-knappen beroende på om något tal är markerat
        If lstTal.SelectedIndex > -1 Then
            btnTaBort.Enabled = True
        Else
            btnTaBort.Enabled = False
        End If
    End Sub
End Class
