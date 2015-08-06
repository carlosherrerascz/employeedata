Option Explicit On
Option Strict On
Imports System.IO

Module Module1

    'Variables 
    Public strFileName As String = String.Empty
    'Variables necessary to open files
    Public streamOpenFile As StreamReader
    Public outputFile As StreamWriter
    Public strEmployees() As employeeList
    Public intCount As Integer
    Public intTotalEmployees As Integer

    Public blnSavedBefore As Boolean = False

    Dim intCurrentEmployeeFile As Integer = 0

    Public Structure employeeList
        Dim strRecordNumber As String
        Dim strFirstName As String
        Dim strMiddleName As String
        Dim strLastName As String
        Dim strEmployeeNum As String
        Dim strDepartment As String
        Dim strPhoneNumber As String
        Dim strExtensionNumber As String
        Dim strEmail As String
    End Structure

    Sub openFile(ByRef streamReader As StreamReader, ByRef strFileName As String, ByRef opnFile As OpenFileDialog)
        With opnFile
            .Filter = "text files (*.txt)|*.txt|all files (*.*)|*.*"
            .Title = "Open a file:"
        End With
        If opnFile.ShowDialog = DialogResult.OK Then
            Try
                strFileName = opnFile.FileName
            Catch ex As Exception
                MessageBox.Show("Filename not valid!")
            End Try

        streamReader = File.OpenText(strFileName)
            'Used to determine total length of text file.
        While Not (streamReader.EndOfStream)
            Dim currVal As String = streamReader.ReadLine()
            intCount += 1
        End While
        'Rewind to line 0
        streamReader.Close()
        streamReader = File.OpenText(strFileName)

        intTotalEmployees = CInt(intCount / 8)

        'Increment it by 3 - 1, as every array starts with one dimension.
        If intTotalEmployees <> 1 Then
            ReDim strEmployees(intTotalEmployees - 1)
        End If


        Dim strCurrentVal As String = String.Empty

        'Cycle through all employees and assign them a value
            For currentEmployee As Integer = 0 To intTotalEmployees - 1
                strEmployees(currentEmployee).strRecordNumber = (currentEmployee + 1).ToString
                For currentAttribute As Integer = 0 To 7
                    strCurrentVal = streamReader.ReadLine
                    Select Case currentAttribute
                        Case Is = 0
                            strEmployees(currentEmployee).strFirstName = strCurrentVal
                        Case Is = 1
                            strEmployees(currentEmployee).strMiddleName = strCurrentVal
                        Case Is = 2
                            strEmployees(currentEmployee).strLastName = strCurrentVal
                        Case Is = 3
                            strEmployees(currentEmployee).strEmployeeNum = strCurrentVal
                        Case Is = 4
                            strEmployees(currentEmployee).strDepartment = strCurrentVal
                        Case Is = 5
                            strEmployees(currentEmployee).strPhoneNumber = strCurrentVal
                        Case Is = 6
                            strEmployees(currentEmployee).strExtensionNumber = strCurrentVal
                        Case Is = 7
                            strEmployees(currentEmployee).strEmail = strCurrentVal
                    End Select
                Next
            Next

        streamReader.Close()
        End If
    End Sub

    Function checkIfOpenedFile() As Boolean
        If strFileName <> String.Empty Then
            Return True
        Else
            MessageBox.Show("Please open a file before going to this menu!")
            Return False
        End If
    End Function
End Module
