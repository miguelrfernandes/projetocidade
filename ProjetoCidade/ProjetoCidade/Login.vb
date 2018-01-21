Imports System
Imports System.IO
Public Class Login
    Dim Total As Integer
    Dim utilizadores(99, 2) As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim path As String = Directory.GetCurrentDirectory()
        FileOpen(1, path & "\utilizadores.txt", OpenMode.Input)
        Input(1, Total)
        For i = 1 To Total
            Input(1, utilizadores(i, 1))
            Input(1, utilizadores(i, 2))
        Next i
        FileClose(1)

        Dim utilizador As String = tbNome.Text
        Dim password As String = tbPassword.Text

        For i = 1 To Total
            If utilizador = utilizadores(i, 1) Then
                If password = utilizadores(i, 2) Then
                    Me.Hide()
                    Cidade.Show()
                Else
                    MsgBox("Password ou utilizador errado")
                End If
            Else
                MsgBox("Password ou utilizador errado")
            End If
        Next i
    End Sub
End Class