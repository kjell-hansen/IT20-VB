Public Class Form1
    Private facit As Integer
    Private antalGissningar As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initiera slumptalsgeneratorn
        Randomize()

        ' Slumpa fram ett tal mellan 1 och 1000
        facit = CInt(Rnd() * 1000 + 1)

    End Sub

    Private Sub btnGissa_Click(sender As Object, e As EventArgs) Handles btnGissa.Click
        If CInt(txtGissning.Text) = facit Then
            MsgBox("Du gissade rätt!")
            Application.Exit()
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
    End Sub
End Class
