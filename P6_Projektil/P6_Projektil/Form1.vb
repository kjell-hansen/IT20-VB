Public Class Form1
    ' Aktuell position för målet
    Private target As Point

    Private Sub txtVinkel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVinkel.KeyPress, txtHastighet.KeyPress
        ' Begränsa inmatningen till siffror och backspace
        If (e.KeyChar < "0"c OrElse e.KeyChar > "9"c) AndAlso e.KeyChar <> vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtVinkel_Leave(sender As Object, e As EventArgs) Handles txtVinkel.Leave
        ' Vinkeln ska vara mellan 0 och 90 (men inte dessa värden)
        If Val(txtVinkel.Text) > 89 OrElse Val(txtVinkel.Text) < 1 Then
            ' Sätt en annan bakgrund för att indikera felaktigt värde
            txtVinkel.BackColor = Color.Pink
        Else
            ' Sätt normal bakgrund för korrekta värden
            txtVinkel.BackColor = SystemColors.Window
        End If
        aktiveraRita()
    End Sub

    Private Sub btnRita_Click(sender As Object, e As EventArgs) Handles btnRita.Click
        ' Ritar ut projektilens bana
        Dim x, y, tid, hastighet, vinkel As Single  ' Lokala variabler för projektilens bana
        Dim punkt As System.Drawing.Graphics        ' Variabel för att kunna rita i picture-boxen 
        Dim penna As New System.Drawing.Pen(txtColor.BackColor, 4) ' Definiera pennan vi ritar med
        Dim oldCursor As Cursor = Cursor.Current    ' Lagra gamla pekarens värde

        ' Sätt väntepekare och disabla knappar
        Cursor = Cursors.WaitCursor
        btnRita.Enabled = False
        btnRensa.Enabled = False

        ' Läs in hastighet och vinkel från fälten
        hastighet = Val(txtHastighet.Text)
        vinkel = Val(txtVinkel.Text)

        ' Förbered för att rita 
        punkt = picWorld.CreateGraphics

        ' HUvudloop för att rita projektilens bana
        Do
            ' ÖKa tiden för varje varv
            tid = tid + 0.05

            ' Beräkna ny position baserat på vinkel, hastighet och tid sen avfyrning
            x = hastighet * Math.Cos(vinkel * Math.PI / 180) * tid
            y = picWorld.Height - (hastighet * Math.Sin(vinkel * Math.PI / 180) * tid - 9.82 * tid * tid / 2)

            ' Rita ut projektilens aktuella position
            punkt.DrawEllipse(penna, x, y, 2, 2)

            ' Kontrollera om projektilen träffar målet
            If Math.Abs(x - target.X) < 5 AndAlso Math.Abs(y - target.Y) < 5 Then
                MsgBox("Träff!")
                Exit Do
            End If
        Loop While (x < picWorld.Width) ' Avbryt då bredden passerats

        ' Återställ knappar och pekare
        btnRensa.Enabled = True
        btnRita.Enabled = True
        Cursor = oldCursor
    End Sub

    Private Sub btnRensa_Click(sender As Object, e As EventArgs) Handles btnRensa.Click
        ' Rensar pictureboxen på alla ritade punkter
        picWorld.CreateGraphics.Clear(SystemColors.Window)
    End Sub

    Private Function slumpaMal() As Point
        ' Slumpar fram en ny position för målet
        Dim mal As Point

        mal.X = picWorld.Width * Rnd()
        mal.Y = picWorld.Height * Rnd()

        Return mal

    End Function
    Private Sub ritaMal()
        ' Ritar ut målet
        Dim punkt As System.Drawing.Graphics
        Dim penna As New System.Drawing.Pen(Brushes.Red, 4)

        punkt = picWorld.CreateGraphics
        punkt.DrawEllipse(penna, target.X, target.Y, 4, 4)

    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        ' Rita ut punkten när formuläret ritas om
        ritaMal()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Slumpa fram en postition för målet
        target = slumpaMal()
        aktiveraRita()
        avaktiveraKontroller()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ' Se till att målet alltid finns i pictureboxen
        If target.X > picWorld.Width - 5 Then
            target.X = picWorld.Width - 5
        End If
        If target.Y > picWorld.Height - 5 Then
            target.Y = picWorld.Height - 5
        End If
        ritaMal()
    End Sub

    Private Sub aktiveraRita()
        If txtHastighet.BackColor = SystemColors.Window AndAlso txtVinkel.BackColor = SystemColors.Window Then
            btnRita.Enabled = True
        Else
            btnRita.Enabled = False
        End If
    End Sub

    Private Sub txtHastighet_Leave(sender As Object, e As EventArgs) Handles txtHastighet.Leave
        ' Kontrollera att hastigheten är tillåten
        If Val(txtHastighet.Text) < 1 Then
            txtHastighet.BackColor = Color.Pink
        Else
            txtHastighet.BackColor = SystemColors.Window
        End If
        aktiveraRita()
    End Sub

    Private Sub txtColor_Click(sender As Object, e As EventArgs) Handles txtColor.Click
        dlgColor.ShowDialog()

        txtColor.BackColor = dlgColor.Color
    End Sub

    Private Sub avaktiveraKontroller()
        txtHastighet.Enabled = False
        txtVinkel.Enabled = False
        btnRita.Enabled = False
    End Sub
End Class
