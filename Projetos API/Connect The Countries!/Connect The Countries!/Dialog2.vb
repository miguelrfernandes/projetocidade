Imports System.Windows.Forms

Public Class Dialog2

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button2.Visible = True
        Button1.Visible = False

        PictureBox1.Image = Image.FromFile("C:\Recursos\Imagens\Ajudas\Form3.png")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button2.Visible = False
        Button1.Visible = True
        PictureBox1.Image = Image.FromFile("C:\Recursos\Imagens\Ajudas\Form3_1.png")
    End Sub

End Class
