﻿Imports System.Data.OleDb
Public Class frmAdresser
    Private con As New OleDb.OleDbConnection
    Private dsAdresser As New DataSet
    Private daAdresser As OleDbDataAdapter
    Private antalPoster As Integer

    Private Sub frmAdresser_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Kombinera sökvägar, databasens namn mm till en dbSource
        Dim dbProvider As String = "PROVIDER=Microsoft.ACE.OLEDB.12.0;"
        Dim dbName As String = "Adresser.accdb"
        Dim dbPath As String = "c:\users\kjellh\Documents"
        Dim dbSource As String = "Data source=" & dbPath & "\" & dbName
        Dim sql As String

        ' Sätt i hop kopplingssträngen mha variablerna ovan
        con.ConnectionString = dbProvider & dbSource

        ' Öppna databasen
        con.Open()

        ' Välj data att visa
        sql = "SELECT * FROM adresser"

        ' Koppla in dataadaptern och fyll den
        daAdresser = New OleDbDataAdapter(sql, con)
        daAdresser.Fill(dsAdresser, "Adressbok")

        ' Räkna antalet poster i tabellen
        antalPoster = dsAdresser.Tables("Adressbok").Rows.Count

        ' Fyll formuläret med första posten
        fyllFormular(0)
        txtPost.Text = 0

    End Sub

    Private Sub fyllFormular(postnr As Integer)
        If postnr >= antalPoster Then
            postnr = antalPoster - 1
        End If

        ' Fyll formuläret med uppgifter från databasen
        txtFornamn.Text = dsAdresser.Tables("Adressbok").Rows(postnr)("Fornamn")
        txtEfternamn.Text = dsAdresser.Tables("Adressbok").Rows(postnr)("Efternamn")
        txtAdress.Text = dsAdresser.Tables("Adressbok").Rows(postnr)("Adress")
        txtPostnr.Text = dsAdresser.Tables("Adressbok").Rows(postnr)("Postnr")
        txtOrt.Text = dsAdresser.Tables("Adressbok").Rows(postnr)("Ort")

        '       txtPost.Text = postnr

        aktiveraKnappar(postnr)
    End Sub

    Private Sub aktiveraKnappar(postnr As Integer)
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
        txtPost.Text = 0
    End Sub

    Private Sub btnForegaende_Click(sender As Object, e As EventArgs) Handles btnForegaende.Click
        Dim postnr As Integer = Val(txtPost.Text)
        fyllFormular(postnr - 1)
        txtPost.Text = postnr - 1
    End Sub

    Private Sub btnSista_Click(sender As Object, e As EventArgs) Handles btnSista.Click
        fyllFormular(antalPoster - 1)
        txtPost.Text = antalPoster - 1
    End Sub

    Private Sub btnNasta_Click(sender As Object, e As EventArgs) Handles btnNasta.Click
        Dim postnr As Integer = Val(txtPost.Text)
        fyllFormular(postnr + 1)
        txtPost.Text = postnr + 1
    End Sub

    Private Sub txtPost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPost.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "0123456789"
            If Not allowedChars.Contains(e.KeyChar.ToString) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtPost_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPost.KeyDown
        If e.KeyCode = Keys.Enter Then
            fyllFormular(Val(txtPost.Text))
            txtPost.Text = Val(txtPost.Text)
        End If
    End Sub

    Private Sub btnSpara_Click(sender As Object, e As EventArgs) Handles btnSpara.Click
        Dim commandBuilder As New OleDb.OleDbCommandBuilder(daAdresser)
        Dim dbRow As DataRow

        dbRow = dsAdresser.Tables("Adressbok").Rows(Val(txtPost.Text))
        dbRow.Item("Fornamn") = txtFornamn.Text
        dbRow.Item("Efternamn") = txtEfternamn.Text
        dbRow.Item("Adress") = txtAdress.Text
        dbRow.Item("Postnr") = txtPostnr.Text
        dbRow.Item("Ort") = txtOrt.Text

        daAdresser.Update(dsAdresser, "Adressbok")

    End Sub
End Class
