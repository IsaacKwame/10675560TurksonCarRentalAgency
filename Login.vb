Imports System.Data.SqlClient
Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Please make an input in all fields.", MsgBoxStyle.Critical)
        Else
            qry = "select * from tblLogin where Username ='" & txtUsername.Text & "' and Password='" & txtPassword.Text & "'"
            connection_open()
            cmd = New SqlCommand(qry, cnn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                MsgBox("Login Successfull", MsgBoxStyle.Information, "Login Form")
                Me.Hide()
                connection_close()
                Customer.Show()

            Else
                MsgBox("Invalid Username/Password", MsgBoxStyle.Critical, "Login Failure")
                connection_close()
            End If


        End If
    End Sub
End Class