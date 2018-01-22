Imports System.IO

Public Class Form2
    Dim c As Integer

    Sub next_img()
        If c = 0 Then
            Button2.Visible = False
        ElseIf c = 28 Then
            Button3.Visible = False
        Else
            Button2.Visible = True
            Button3.Visible = True
        End If


        If c = 2 Then
            Label1.Visible = True
            Label2.Visible = True
        Else
            Label1.Visible = False
            Label2.Visible = False
        End If


        Dim linhas As String()
        linhas = File.ReadAllLines("C:\Recursos\Texto\Code_1.read")


        PictureBox1.Image = Image.FromFile(linhas(c))
        PictureBox2.Image = Image.FromFile(linhas(c + 1))
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()

        Button2.Visible = False
        Button3.Visible = True
        c = 0

        PictureBox1.Image = Image.FromFile("C:\Recursos\Imagens\Origami\00000.png")
        PictureBox2.Image = Image.FromFile("C:\Recursos\Imagens\Origami\0000.png")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        c = c - 2
        next_img()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        c = c + 2
        next_img()
    End Sub

    Private Sub AjudaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjudaToolStripMenuItem.Click
        Dialog1.Show()
    End Sub
End Class