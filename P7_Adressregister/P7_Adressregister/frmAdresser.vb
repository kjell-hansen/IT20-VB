Imports System.Data.OleDb
Public Class frmAdresser
    Private antalPoster As Integer

    Private Sub frmAdresser_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Koppla mot databasen
        dbConnect()

        ' Räkna antalet poster i tabellen
        antalPoster = dsAdresser.Tables("Adressbok").Rows.Count

        ' Fyll formuläret med första posten
        fyllFormular(0)
        txtPost.Text = 0

    End Sub

    Public Sub fyllFormular(postnr As Integer)
        ' Kontrollera att antalet poster håller sig inom korrekta gränser
        If postnr >= antalPoster Then
            postnr = antalPoster - 1
        ElseIf postnr < 0 Then
            postnr = 0
        End If

        ' Fyll formuläret med uppgifter från databasen
        txtFornamn.Text = dsAdresser.Tables("Adressbok").Rows(postnr)("Fornamn")
        txtEfternamn.Text = dsAdresser.Tables("Adressbok").Rows(postnr)("Efternamn")
        txtAdress.Text = dsAdresser.Tables("Adressbok").Rows(postnr)("Adress")
        txtPostnr.Text = dsAdresser.Tables("Adressbok").Rows(postnr)("Postnr")
        txtOrt.Text = dsAdresser.Tables("Adressbok").Rows(postnr)("Ort")

        ' Fyll i aktuellt postnr i rutan
        txtPost.Text = postnr

        aktiveraKnappar(postnr)
    End Sub

    Private Sub aktiveraKnappar(postnr As Integer)
        ' Dölj Ångra-knappen om den syns
        btnAngra.Visible = False

        ' Aktivera radera, ny och visa lista
        btnRadera.Enabled = True
        btnNyPost.Enabled = True
        btnLista.Enabled = True

        ' Avaktivera alla navigationsknappar som standard
        btnForsta.Enabled = False
        btnForegaende.Enabled = False
        btnNasta.Enabled = False
        btnSista.Enabled = False
        Select Case postnr
            Case 0 ' Första posten  - Nästa och Sista aktiva
                btnNasta.Enabled = True
                btnSista.Enabled = True
            Case antalPoster - 1 ' Sista posten - Första och Föregående aktiva
                btnForsta.Enabled = True
                btnForegaende.Enabled = True
            Case Else ' Alla knappar aktiva
                btnForsta.Enabled = True
                btnForegaende.Enabled = True
                btnNasta.Enabled = True
                btnSista.Enabled = True
        End Select
    End Sub

    Private Sub btnForsta_Click(sender As Object, e As EventArgs) Handles btnForsta.Click
        fyllFormular(0)
    End Sub

    Private Sub btnForegaende_Click(sender As Object, e As EventArgs) Handles btnForegaende.Click
        Dim postnr As Integer = Val(txtPost.Text)
        fyllFormular(postnr - 1)
    End Sub

    Private Sub btnSista_Click(sender As Object, e As EventArgs) Handles btnSista.Click
        fyllFormular(antalPoster - 1)
    End Sub

    Private Sub btnNasta_Click(sender As Object, e As EventArgs) Handles btnNasta.Click
        Dim postnr As Integer = Val(txtPost.Text)
        fyllFormular(postnr + 1)
    End Sub

    Private Sub txtPost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPost.KeyPress
        If e.KeyChar = vbBack Then
            Return
        End If
        Dim allowedChars As String = "0123456789"
        If Not allowedChars.Contains(e.KeyChar.ToString) Then
            e.KeyChar = ChrW(0)
            e.Handled = True
        End If
    End Sub

    Private Sub txtPost_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPost.KeyDown
        If e.KeyCode = Keys.Enter Then
            fyllFormular(Val(txtPost.Text))
        End If
    End Sub

    Private Sub btnSpara_Click(sender As Object, e As EventArgs) Handles btnSpara.Click
        Dim commandBuilder As New OleDb.OleDbCommandBuilder(daAdresser)
        Dim dbRow As DataRow

        ' Skapa en ny datarow om det är fråga om en ny post
        If txtPost.Text = "*" Then
            dbRow = dsAdresser.Tables("Adressbok").NewRow
        Else
            ' Tilldela den gamla raden annars
            dbRow = dsAdresser.Tables("Adressbok").Rows(Val(txtPost.Text))
        End If

        ' Sätt databasfälten baserat på textrutorna
        dbRow.Item("Fornamn") = txtFornamn.Text
        dbRow.Item("Efternamn") = txtEfternamn.Text
        dbRow.Item("Adress") = txtAdress.Text
        dbRow.Item("Postnr") = txtPostnr.Text
        dbRow.Item("Ort") = txtOrt.Text

        If txtPost.Text = "*" Then
            dsAdresser.Tables("Adressbok").Rows.Add(dbRow)
            txtPost.Text = dsAdresser.Tables("Adressbok").Rows.Count - 1
            antalPoster = dsAdresser.Tables("Adressbok").Rows.Count
            aktiveraKnappar(txtPost.Text)
        End If

        daAdresser.Update(dsAdresser, "Adressbok")
        fyllFormular(txtPost.Text)

    End Sub

    Private Sub btnNyPost_Click(sender As Object, e As EventArgs) Handles btnNyPost.Click
        ' Spara undan senaste postnummer för användning i Ångra-knappen
        btnAngra.Tag = txtPost.Text
        btnAngra.Visible = True

        ' Rensa alla fält
        txtFornamn.Text = ""
        txtEfternamn.Text = ""
        txtAdress.Text = ""
        txtPostnr.Text = ""
        txtOrt.Text = ""

        ' Markera att det är en ny post i post-rutan
        txtPost.Text = "*"

        ' Disabla alla knappar
        btnForsta.Enabled = False
        btnForegaende.Enabled = False
        btnNasta.Enabled = False
        btnSista.Enabled = False
        btnRadera.Enabled = False
        btnNyPost.Enabled = False
        btnLista.Enabled = False

        ' Sätt fokus på förnamn
        txtFornamn.Focus()

    End Sub

    Private Sub btnAngra_Click(sender As Object, e As EventArgs) Handles btnAngra.Click
        txtPost.Text = btnAngra.Tag
        fyllFormular(btnAngra.Tag)
        aktiveraKnappar(btnAngra.Tag)
    End Sub

    Private Sub btnRadera_Click(sender As Object, e As EventArgs) Handles btnRadera.Click
        If MsgBox("Vill du verkligen radera denna posten?", vbYesNo + vbQuestion) = vbYes Then
            Dim commandBuilder As New OleDbCommandBuilder(daAdresser)

            ' Radera raden och uppdatera dataadaptern
            dsAdresser.Tables("Adressbok").Rows(txtPost.Text).Delete()
            daAdresser.Update(dsAdresser, "Adressbok")

            ' Uppdatera antal poster
            antalPoster = dsAdresser.Tables("Adressbok").Rows.Count

            ' Hitta numret på posten som ska visas
            Dim nyPost As Integer = txtPost.Text - 1
            If nyPost < 0 Then
                nyPost = 0
            End If

            ' Visa rätt post och aktivera knappar
            txtPost.Text = nyPost
            fyllFormular(nyPost)
            aktiveraKnappar(nyPost)

        End If
    End Sub

    Private Sub btnLista_Click(sender As Object, e As EventArgs) Handles btnLista.Click
        frmLista.show()
        Me.Hide()
    End Sub
End Class
