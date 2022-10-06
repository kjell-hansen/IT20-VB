Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblResult.Text = ""
        cboRaknesatt.SelectedIndex = 0
    End Sub

    Private Sub txtTal1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTal1.KeyPress, txtTal2.KeyPress
        ' Minustecken tillåts bara om det är första tecknet
        If e.KeyChar = "-"c AndAlso sender.text <> "" Then
            e.Handled = True
        End If
        ' Kontrollera att det bara kan skrivas en punkt
        If e.KeyChar = "." AndAlso InStr(sender.Text, ".") > 0 Then
            e.Handled = True
        End If
        ' Tillåt bara siffror, punkt Backspace och minustecken
        If (e.KeyChar < "0"c OrElse e.KeyChar > "9"c) AndAlso e.KeyChar <> "."c AndAlso e.KeyChar <> vbBack AndAlso e.KeyChar <> "-"c Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnRakna_Click(sender As Object, e As EventArgs) Handles btnRakna.Click
        Select Case cboRaknesatt.Text
            Case "+"
                lblResult.Text = Val(txtTal1.Text) + Val(txtTal2.Text)
            Case "-"
                lblResult.Text = Val(txtTal1.Text) - Val(txtTal2.Text)
            Case "*"
                lblResult.Text = Val(txtTal1.Text) * Val(txtTal2.Text)
            Case "/"
                If Val(txtTal2.Text) = 0 Then
                    MsgBox("Otillåten operation")
                Else
                    lblResult.Text = Val(txtTal1.Text) / Val(txtTal2.Text)
                End If
            Case "%"
                If Val(txtTal2.Text) = 0 Then
                    MsgBox("Otillåten operation")
                Else
                    lblResult.Text = Val(txtTal1.Text) Mod Val(txtTal2.Text)
                End If
        End Select

    End Sub
End Class
