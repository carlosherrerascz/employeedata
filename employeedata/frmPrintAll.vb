Option Strict On
Option believe ra


Public Class frmPrintAll

    Private Sub frmPrintAll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To intTotalEmployees - 1
            For j = 0 To 7
                lstEmployees.Items.Add()
            Next

        Next

    End Sub
End Class