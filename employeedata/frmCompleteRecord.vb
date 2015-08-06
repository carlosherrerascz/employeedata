Public Class frmCompleteRecord

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        lstEmployees.Items.Add("===============================================================================================================================")
        lstEmployees.Items.Add("Employee" & vbTab _
                               & vbTab & "Employee number" & vbTab & vbTab & "Department" _
                               & vbTab & "Telephone number" & vbTab & "Extension" & vbTab _
                               & vbTab & "eMail")
        lstEmployees.Items.Add("===============================================================================================================================")

        For currentEmployee As Integer = 0 To intTotalEmployees - 1
            With strEmployees(currentEmployee)
                lstEmployees.Items.Add("[" & currentEmployee + 1 & "] " & .strFirstName & " " & .strMiddleName & " " & .strLastName & vbTab _
                                       & vbTab & .strEmployeeNum & vbTab & vbTab & .strDepartment & vbTab _
                                       & vbTab & .strPhoneNumber & vbTab & vbTab & .strExtensionNumber & vbTab _
                                       & vbTab & .strEmail)
            End With
        Next




    End Sub
End Class