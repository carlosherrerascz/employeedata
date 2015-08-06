Option Explicit On
Option Strict On
Imports System.IO

Public Class frmRecords
    Dim strFileName As String = String.Empty
    Dim intCount As Integer

    Dim intCurrentEmployeeFile As Integer = 0

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        If intCurrentEmployeeFile > intTotalEmployees - 1 Then
            MessageBox.Show("Fin de lista, regresando al primer empleado...")
            intCurrentEmployeeFile = 0
        End If
        With strEmployees(intCurrentEmployeeFile)

            lblRecordNumber.Text = .strRecordNumber
            lblFirstName.Text = .strFirstName
            lblMiddleName.Text = .strMiddleName
            lblLastName.Text = .strLastName
            lblEmployeeNumber.Text = .strEmployeeNum
            lblDepartment.Text = .strDepartment
            lblTelephone.Text = .strPhoneNumber
            lblExtension.Text = .strExtensionNumber
            lblEmail.Text = .strEmail
        End With
        intCurrentEmployeeFile += 1

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmAddEmployee.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblRecordNumber.Text = String.Empty
        lblFirstName.Text = String.Empty
        lblMiddleName.Text = String.Empty
        lblLastName.Text = String.Empty
        lblEmployeeNumber.Text = String.Empty
        lblExtension.Text = String.Empty
        lblTelephone.Text = String.Empty
        lblEmail.Text = String.Empty
    End Sub
End Class
