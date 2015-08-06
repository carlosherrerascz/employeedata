Public Class frmSearch

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim intSelectedEmplyee As Integer = CInt(txtRecordNumber.Text)
        If intSelectedEmplyee < 0 Or intSelectedEmplyee > intTotalEmployees - 1 Then
            MessageBox.Show("Number not found in record.")
        Else
            lblFirstName.Text = strEmployees(intSelectedEmplyee).strFirstName
            lblMiddleName.Text = strEmployees(intSelectedEmplyee).strMiddleName
            lblLastName.Text = strEmployees(intSelectedEmplyee).strLastName
            lblEmployeeNumber.Text = strEmployees(intSelectedEmplyee).strEmployeeNum
            lblDepartment.Text = strEmployees(intSelectedEmplyee).strDepartment
            lblTelephone.Text = strEmployees(intSelectedEmplyee).strPhoneNumber
            lblExtension.Text = strEmployees(intSelectedEmplyee).strExtensionNumber
            lblEmail.Text = strEmployees(intSelectedEmplyee).strEmail
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        frmAddEmployee.Show()
    End Sub
End Class

