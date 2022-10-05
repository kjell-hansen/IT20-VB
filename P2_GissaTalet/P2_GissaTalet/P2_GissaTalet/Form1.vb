Public Class Form1
    Private facit As Integer
    Private antalGissningar As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initiera slumptalsgeneratorn
        Randomize()

        ' Slumpa fram ett tal mellan 1 och 1000
        facit = CInt(Rnd() * 1000 + 1)
        txtGissning.Focus()
    End Sub

    Private Sub btnGissa_Click(sender As Object, e As EventArgs) Handles btnGissa.Click
        ' Kontrollera att det är ett tal i rutan
        If Not IsNumeric(txtGissning.Text) Then
            MsgBox("Du måste skriva talet med siffror")
            txtGissning.Text = ""
            txtGissning.Focus()
            Exit Sub
        End If

        If CInt(txtGissning.Text) = facit Then
            MsgBox("Du gissade rätt!")
            If MsgBox("Vill du prova igen", vbYesNo) = vbNo Then
                Application.Exit()
            Else
                ' Ta fram ett nytt slumptal
                facit = CInt(Rnd() * 1000 + 1)
                ' Nollställ antal gissningar
                antalGissningar = 0
                'Töm textfältet
                txtGissning.Text = ""
                ' Skriv ut info om antal gissningar
                lblAntalGissningar.Text = "Du har gissat " + antalGissningar.ToString + " gånger"
            End If
        ElseIf CInt(txtGissning.Text) > facit Then
                MsgBox("Du gissade för högt")
            Else
                MsgBox("Du gissade för lågt")
        End If

        ' ÖKa antalet gissningar 
        antalGissningar = antalGissningar + 1
        lblAntalGissningar.Text = "Du har gissat " + antalGissningar.ToString + " gånger"

        ' Töm textfältet
        txtGissning.Text = ""
        txtGissning.Focus()
    End Sub

    Private Sub btnGeUpp_Click(sender As Object, e As EventArgs) Handles btnGeUpp.Click
        ' Fråga om användaren vill avsluta
        If MsgBox("Är du helt säker på att du vill sluta", vbYesNo, "Gissa talet") = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnBorjaOm_Click(sender As Object, e As EventArgs) Handles btnBorjaOm.Click
        ' Ta fram ett nytt slumptal
        facit = CInt(Rnd() * 1000 + 1)
        ' Nollställ antal gissningar
        antalGissningar = 0
        'Töm textfältet
        txtGissning.Text = ""
        ' Skriv ut info om antal gissningar
        lblAntalGissningar.Text = "Du har gissat " + antalGissningar.ToString + " gånger"

    End Sub

    Private Sub Label1_DoubleClick(sender As Object, e As EventArgs) Handles Label1.DoubleClick
        MsgBox(facit)
    End Sub
End Class
