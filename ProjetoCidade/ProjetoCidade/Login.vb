Imports System
Imports System.IO
Public Class Login
    Dim Total As Integer
    Dim utilizadores(99, 2) As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EntrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntrarToolStripMenuItem.Click
        entrar()
    End Sub
    Private Sub entrar()
        Dim loginSucedido As Boolean = False
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
                    Inicio.Hide()
                    Cidade.Show()
                    loginSucedido = True
                End If
            End If
        Next i
        If loginSucedido = False Then
            MsgBox("Password ou utilizador errado")
        End If
    End Sub
End Class