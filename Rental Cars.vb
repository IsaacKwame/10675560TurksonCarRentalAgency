Imports System.Data.SqlClient
Public Class Form1
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If txtCN.Text = "" Or txtCM.Text = "" Or txtCMO.Text = "" Or txtCT.Text = "" Or txtCC.Text = "" Or txtCMI.Text = "" Or txtCP.Text = "" Or txtCS.Text = "" Then
                MsgBox("Please make an input in all fields.", MsgBoxStyle.Critical)
            Else
                qry = " Insert Into tbl_Car(car_name, car_manufacturer, car_model, car_type, car_capacity, car_mileage, car_image, car_price, car_status) Values 
             ('" & txtCN.Text & "','" & txtCM.Text & "','" & txtCMO.Text & "','" & txtCT.Text & "','" & txtCC.Text & "','" & txtCMI.Text & "','" & txtCP.Text & "','" & txtCS.Text & "' )"
                connection_open()
                cmd = New SqlCommand(qry, cnn)
            End If
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                MsgBox("Car successfully selected car", MsgBoxStyle.Information, "Rental Cars")
                Me.Hide()
                Payment.Show()


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
