Imports System.Data.SqlClient
Public Class Customer

    'Customer Table data adapter
    'Dim CustomerAdapter As Turkson_Car_RentalDataSetTableAdapters.tblCustomerTableAdapter = New Turkson_Car_RentalDataSetTableAdapters.tblCustomerTableAdapter()
    'Customer Table dataset
    'Dim customerDataSet As Turkson_Car_RentalDataSet = New Turkson_Car_RentalDataSet()
    'Variable for storing customer data collected
    'Dim customerRow As Turkson_Car_RentalDataSet.tblCustomerRow


    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '' table. You can move, or remove it, as needed.

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnReset.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnNewCustomer.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If txtCFN.Text = "" Or txtCLN.Text = "" Or txtCMC.Text = "" Or txtNHIS.Text = "" Or txtCA.Text = "" Or txtPIP.Text = "" Or txtVID.Text = "" Then
                MsgBox("Please make an input in all fields.", MsgBoxStyle.Critical)
            Else
                qry = " Insert Into tblCustomer(cust_first_name, cust_last_name, cust_mobile_contact, cust_credential, cust_address, cust_voters_ID, cust_passport_ID, cust_NHIS) values 
             ('" & txtCFN.Text & "','" & txtCLN.Text & "','" & txtCMC.Text & "','" & txtCA.Text & "','" & txtNHIS.Text & "','" & txtPIP.Text & "','" & txtVID.Text & "' )"
                connection_open()
                cmd = New SqlCommand(qry, cnn)
            End If
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                MsgBox("Customer Sucessfully added", MsgBoxStyle.Information, "Customer Form")
                Me.Hide()


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Customer_Click(sender As Object, e As EventArgs) Handles MyBase.Click

    End Sub
End Class