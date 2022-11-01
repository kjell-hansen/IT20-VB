Imports System.Data.OleDb

Module modData
    Public con As New OleDb.OleDbConnection
    Public dsAdresser As New DataSet
    Public daAdresser As OleDbDataAdapter

    Public Sub dbConnect()
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
        daAdresser.MissingSchemaAction = MissingSchemaAction.AddWithKey
        daAdresser.Fill(dsAdresser, "Adressbok")

    End Sub
End Module
