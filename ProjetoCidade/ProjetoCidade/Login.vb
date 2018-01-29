Imports System
Imports System.IO
Public Class Login
    Dim Total As Integer
    Dim utilizadores(99, 2) As String

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
                    Inicio.Hide()
                    Cidade.Show()
                    loginSucedido = True
                    Me.Hide()
                End If
            End If
        Next i
        If loginSucedido = False Then
            MsgBox("Password ou utilizador errado")
        End If
    End Sub

    Private Sub EntrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntrarToolStripMenuItem.Click, Button3.Click
        entrar()
    End Sub

    Private Sub FecharToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharToolStripMenuItem.Click, Button2.Click, ToolStripMenuItem1.Click
        Me.Close()
    End Sub
End Class