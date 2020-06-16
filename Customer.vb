Public Class Customer

    'Customer Table data adapter
    Dim CustomerAdapter As Turkson_Car_RentalDataSetTableAdapters.tblCustomerTableAdapter = New Turkson_Car_RentalDataSetTableAdapters.tblCustomerTableAdapter()
    'Customer Table dataset
    Dim customerDataSet As Turkson_Car_RentalDataSet = New Turkson_Car_RentalDataSet()
    'Variable for storing customer data collected
    Dim customerRow As Turkson_Car_RentalDataSet.tblCustomerRow


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

        Catch ex As Exception

        End Try
    End Sub
End Class