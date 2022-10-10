Public Class Form1
    Private Sub btnSla_Click(sender As Object, e As EventArgs) Handles btnSla.Click
        Dim varde As Integer
        Dim antalRundor1 = Int(10 * Rnd()) + 11
        Dim antalRundor2 = Int(10 * Rnd()) + 11
        Dim antalRundor3 = Int(10 * Rnd()) + 11

        ' Hämta aktuell cursor och spara undan värdet
        Dim c As Cursor = Cursor
        ' Sätt väntecursor
        Cursor = Cursors.WaitCursor

        ' Avaktivera slå-knappen så att man inte kan spamma den
        btnSla.Enabled = False

        ' Animera tärningarna
        For i = 1 To 20
            If i < antalRundor1 Then
                varde = Int(6 * Rnd())
                picTarning1.Image = imlTarningar.Images(varde)
            End If

            If i < antalRundor2 Then
                varde = Int(6 * Rnd())
                picTarning2.Image = imlTarningar.Images(varde)
            End If

            If i < antalRundor3 Then
                varde = Int(6 * Rnd())
                picTarning3.Image = imlTarningar.Images(varde)
            End If
            ' Gör en DoEvents-loop för att se att tärningarna rör sig
            For j = 0 To 1000000
                Application.DoEvents()
            Next
        Next

        ' Aktivera Slå-knappen igen
        btnSla.Enabled = True

        ' Återställ cursorn
        Cursor = c
    End Sub
End Class
