Imports System.Data.SqlClient
Imports System.Data
Module Module2
    Public Sub connection_open()
        connectionString = "Data Source=.;Initial Catalog=Turkson Car Rental;Integrated Security=True"
        cnn = New SqlConnection(connectionString)
        Try
            cnn.Open()

        Catch ex As Exception
            MsgBox("Can not open Database connection...try again", MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Sub connection_close()
        cnn.Close()

    End Sub
End Module
