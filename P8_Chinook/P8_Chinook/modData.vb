Module modData

    Public Function cnChinook() As SQLite.SQLiteConnection
        Dim cnString As New SQLite.SQLiteConnectionStringBuilder
        Dim cn As SQLite.SQLiteConnection

        cnString.DataSource = "C:\Users\kjellh\source\repos\IT20-VB\P8_Chinook\chinook.db"
        cnString.ForeignKeys = True

        cn = New SQLite.SQLiteConnection(cnString.ToString)
        cn.Open()

        Return cn

    End Function
    Public Function hamtaData(sql As String) As DataTable
        ' Skapa en Datatable för returen
        Dim dt As New DataTable

        ' Skapa ett kommandoobjekt för att läsa databasen
        Dim cmd As New SQLite.SQLiteCommand(sql, cnChinook())

        ' Skapa en dataadapter för att exekvera kommandot
        Dim da As New SQLite.SQLiteDataAdapter(cmd)

        ' Fyll returobjektet
        da.Fill(dt)

        ' Returnera datatabellen
        Return dt

    End Function
End Module
