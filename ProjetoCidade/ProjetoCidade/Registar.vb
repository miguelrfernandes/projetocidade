Imports System
Imports System.IO
Public Class Registar
    Dim Total As Integer
    Dim utilizadores(99, 2) As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim utilizador As String = tbUser.Text
        Dim password As String = tbPassword.Text

        Dim path As String = Directory.GetCurrentDirectory()

        'ler ficheiro
        FileOpen(1, path & "\utilizadores.txt", OpenMode.Input)
        Input(1, Total)
        For i = 1 To Total
            Input(1, utilizadores(i, 1))
            Input(1, utilizadores(i, 2))
        Next i
        FileClose(1)

        'escrever ficheiro
        FileOpen(1, path & "\utilizadores.txt", OpenMode.Output)
        Total += 1
        utilizadores(Total, 1) = utilizador : utilizadores(Total, 2) = password
        WriteLine(1, Total)
        For i = 1 To Total
            WriteLine(1, utilizadores(i, 1), utilizadores(i, 2))
        Next i
        FileClose(1)

        MsgBox("Utilizador registado")


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Inicio.Show()
    End Sub
End Class