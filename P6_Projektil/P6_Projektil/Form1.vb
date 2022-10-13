Public Class Form1
    Private target As Point

    Private Sub txtVinkel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVinkel.KeyPress, txtHastighet.KeyPress
        If (e.KeyChar < "0"c OrElse e.KeyChar > "9"c) AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtVinkel_Leave(sender As Object, e As EventArgs) Handles txtVinkel.Leave
        If Val(txtVinkel.Text) > 89 OrElse Val(txtVinkel.Text) < 1 Then
            txtVinkel.BackColor = Color.Pink
        Else
            txtVinkel.BackColor = SystemColors.Window
        End If
    End Sub

    Private Sub btnRita_Click(sender As Object, e As EventArgs) Handles btnRita.Click
        Dim x, y, tid, hastighet, vinkel As Single
        Dim punkt As System.Drawing.Graphics
        Dim penna As New System.Drawing.Pen(Brushes.Black, 4)
        Dim oldCursor As Cursor = Cursor.Current

        Cursor = Cursors.WaitCursor
        btnRita.Enabled = False
        btnRensa.Enabled = False

        hastighet = Val(txtHastighet.Text)
        vinkel = Val(txtVinkel.Text)

        punkt = picWorld.CreateGraphics

        Do
            tid = tid + 0.25
            x = hastighet * Math.Cos(vinkel * Math.PI / 180) * tid
            y = picWorld.Height - (hastighet * Math.Sin(vinkel * Math.PI / 180) * tid - 9.82 * tid * tid / 2)

            punkt.DrawEllipse(penna, x, y, 2, 2)
        Loop While (x < picWorld.Width)

        btnRensa.Enabled = True
        btnRita.Enabled = True
        Cursor = oldCursor
    End Sub

    Private Sub btnRensa_Click(sender As Object, e As EventArgs) Handles btnRensa.Click
        picWorld.CreateGraphics.Clear(SystemColors.Window)
    End Sub

    Private Function slumpaMal() As Point
        Dim mal As Point

        mal.X = picWorld.Width * Rnd()
        mal.Y = picWorld.Height * Rnd()

        Return mal

    End Function
    Private Sub ritaMal()
        Dim punkt As System.Drawing.Graphics
        Dim penna As New System.Drawing.Pen(Brushes.Red, 4)

        punkt = picWorld.CreateGraphics
        punkt.DrawEllipse(penna, target.X, target.Y, 4, 4)

    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        ritaMal()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        target = slumpaMal()
    End Sub
End Class
