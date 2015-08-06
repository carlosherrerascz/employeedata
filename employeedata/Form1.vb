Option Explicit On
Option Strict On
Imports System.IO
Public Class frmAddEmployee

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFirstName.Focus()
    End Sub

    Private Sub btnExit_Click() Handles btnExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If blnSavedBefore = False Then
            Try
                With sfdFile
                    .Filter = "text files (*.txt)|*.txt|all files (*.*)|*.*"
                    .ShowDialog()
                End With

                strFileName = sfdFile.FileName
                ' Create the file.
                outputFile = File.AppendText(strFileName)
                ' Write the TextBox to the file.
                outputFile.WriteLine(txtFirstName.Text)
                outputFile.WriteLine(txtMiddleName.Text)
                outputFile.WriteLine(txtLastName.Text)
                outputFile.WriteLine(txtEmployeeNumber.Text)
                outputFile.WriteLine(cmbDepartment.Text)
                outputFile.WriteLine(txtTelephone.Text)
                outputFile.WriteLine(txtExtension.Text)
                outputFile.WriteLine(txtEmail.Text)

                ' Close the file.
                outputFile.Close()
                ' Update the isChanged variable.
                '            blnIsChanged = False
                blnSavedBefore = True
            Catch
                ' Error message for file creation error.
                MessageBox.Show("Error creating the file.")
            End Try

        Else
            outputFile = File.AppendText(strFileName)
            ' Write the TextBox to the file.
            outputFile.WriteLine(txtFirstName.Text)
            outputFile.WriteLine(txtMiddleName.Text)
            outputFile.WriteLine(txtLastName.Text)
            outputFile.WriteLine(txtEmployeeNumber.Text)
            outputFile.WriteLine(cmbDepartment.Text)
            outputFile.WriteLine(txtTelephone.Text)
            outputFile.WriteLine(txtExtension.Text)
            outputFile.WriteLine(txtEmail.Text)

            txtFirstName.Clear()
            txtMiddleName.Clear()
            txtLastName.Clear()
            txtEmployeeNumber.Clear()
            cmbDepartment.SelectedIndex = -1
            cmbDepartment.Text = String.Empty
            txtTelephone.Clear()
            txtExtension.Clear()
            txtEmail.Clear()
            ' Close the file.
            outputFile.Close()
        End If
    End Sub


    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        openFile(streamOpenFile, strFileName, opnFile)
    End Sub

    Private Sub SeachToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeachToolStripMenuItem.Click
        If checkIfOpenedFile() = True Then
            frmSearch.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub PartiallyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PartiallyToolStripMenuItem.Click
        If checkIfOpenedFile() = True Then
            frmRecords.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub FullyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FullyToolStripMenuItem.Click
        If checkIfOpenedFile() = True Then
            frmCompleteRecord.Show()
            Me.Hide()
        End If
    End Sub
End Class