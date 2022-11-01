Module modData
    Public cnChinook As New SQLite.SQLiteConnection("Data source=C:\Users\kjellh\source\repos\IT20-VB\P8_Chinook\chinook.db")

    Public Function hamtaData(sql As String) As DataTable
        ' Skapa en Datatable för returen
        Dim dt As New DataTable

        ' Skapa ett kommandoobjekt för att läsa databasen
        Dim cmd As New SQLite.SQLiteCommand(sql, cnChinook)

        ' Skapa en dataadapter för att exekvera kommandot
        Dim da As New SQLite.SQLiteDataAdapter(cmd)

        ' Fyll returobjektet
        da.Fill(dt)

        ' Returnera datatabellen
        Return dt

    End Function
End Module
