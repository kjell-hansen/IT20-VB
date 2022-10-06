Public Class Form1
    Private summa As Double
    Private antal As Integer
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

        ' Öka summan med talet
        summa = summa + Val(txtTal.Text)
        lblSumma.Text = summa

        ' Öka räknaren för antal tal
        antal = antal + 1

        ' Beräkna medel 
        lblMedel.Text = summa / antal

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
        ' Nollställ räknare
        antal = 0
        summa = 0

        ' Töm listan
        lstTal.Items.Clear()

        ' Töm labels och inmatningsrutan
        txtTal.Text = ""
        lblMedel.Text = ""
        lblSumma.Text = ""
        txtTal.Focus()
    End Sub
End Class
