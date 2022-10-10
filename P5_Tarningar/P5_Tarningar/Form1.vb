Public Class Form1
    ' Definiera variabler för antal rundor och tärningsvärden
    Private t1Varde As Integer
    Private t2Varde As Integer
    Private t3Varde As Integer
    Private antalRundor1 As Integer
    Private antalRundor2 As Integer
    Private antalRundor3 As Integer

    Private Sub btnSla_Click(sender As Object, e As EventArgs) Handles btnSla.Click
        ' Hämta aktuell cursor och spara undan värdet
        Dim c As Cursor = Cursor
        ' Sätt väntecursor
        Cursor = Cursors.WaitCursor

        ' Avaktivera slå-knappen så att man inte kan spamma den
        btnSla.Enabled = False

        ' Slumpa antalet rundor för varje tärning
        antalRundor1 = Int(100 * Rnd()) + 10
        antalRundor2 = Int(100 * Rnd()) + 10
        antalRundor3 = Int(100 * Rnd()) + 10

        ' Sätt startinterval för varje timer
        timT1.Interval = 1000 / antalRundor1
        timT2.Interval = 1000 / antalRundor2
        timT3.Interval = 1000 / antalRundor3

        ' Sätt bakgrundsfärg för att indikera att tärningen rullar
        picTarning1.BackColor = Color.Pink
        picTarning2.BackColor = Color.Pink
        picTarning3.BackColor = Color.Pink

        ' Starta animeringen
        timT1.Start()
        timT2.Start()
        timT3.Start()

        While timT1.Enabled AndAlso timT2.Enabled AndAlso timT3.Enabled
            Application.DoEvents()
        End While

        ' Aktivera Slå-knappen igen
        btnSla.Enabled = True

        ' Återställ cursorn
        Cursor = c
    End Sub

    Private Sub timT1_Tick(sender As Object, e As EventArgs) Handles timT1.Tick
        ' Ändra värde på tärning 1 varje gång timern tickar
        Dim nyttVarde As Integer = t1Varde

        ' Se till att det blir ett nytt värde varje gång
        Do While nyttVarde = t1Varde
            nyttVarde = Int(6 * Rnd())
            picTarning1.Image = imlTarningar.Images(nyttVarde)
        Loop
        ' Lagqa undan senaste värdet
        t1Varde = nyttVarde

        If antalRundor1 > 0 Then
            ' Beräkna nytt intervall
            timT1.Interval = 1000 / antalRundor1
            antalRundor1 -= 1
        Else
            ' Avbryt animeringen och sätt "klar-färg"
            timT1.Enabled = False
            picTarning1.BackColor = Color.LightGreen
        End If

    End Sub
    Private Sub timT2_Tick(sender As Object, e As EventArgs) Handles timT2.Tick
        ' Ändra värde på tärning 2 varje gång timern tickar
        Dim nyttVarde As Integer = t2Varde

        ' Se till att det blir ett nytt värde varje gång
        Do While nyttVarde = t2Varde
            nyttVarde = Int(6 * Rnd())
            picTarning2.Image = imlTarningar.Images(nyttVarde)
        Loop
        ' Lagra undan senaste värdet
        t2Varde = nyttVarde

        If antalRundor2 > 0 Then
            ' Beräkna nytt intervall
            timT2.Interval = 1000 / antalRundor2
            antalRundor2 -= 1
        Else
            ' Avbryt animeringen och sätt "klar-färg"
            timT2.Enabled = False
            picTarning2.BackColor = Color.LightGreen
        End If

    End Sub
    Private Sub timT3_Tick(sender As Object, e As EventArgs) Handles timT3.Tick
        ' Ändra värde på tärning 3 varje gång timern tickar
        Dim nyttVarde As Integer = t3Varde

        ' Se till att det blir ett nytt värde varje gång
        Do While nyttVarde = t3Varde
            nyttVarde = Int(6 * Rnd())
            picTarning3.Image = imlTarningar.Images(nyttVarde)
        Loop
        ' Lagra undan senaste värdet
        t3Varde = nyttVarde

        ' Titta om det ska rullas fler gånger
        If antalRundor3 > 0 Then
            ' Beräkna nytt intervall
            timT3.Interval = 1000 / antalRundor3
            antalRundor3 -= 1
        Else
            ' Avbryt animeringen och sätt "klar-färg"
            timT3.Enabled = False
            picTarning3.BackColor = Color.LightGreen
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Initiera slumptal
        Randomize()
    End Sub
End Class
