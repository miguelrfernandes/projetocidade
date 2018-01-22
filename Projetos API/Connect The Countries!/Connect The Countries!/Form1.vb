Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub RosaDosVentosOrigamiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RosaDosVentosOrigamiToolStripMenuItem.Click
        Dialog1.Show()
    End Sub

    Private Sub QuizEuropaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuizEuropaToolStripMenuItem.Click
        Dialog2.Show()
    End Sub

    Private Sub JogoDaMemóriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JogoDaMemóriaToolStripMenuItem.Click
        Dialog3.Show()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dialog4.Show()
    End Sub

    Private Sub ObjectivosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObjectivosToolStripMenuItem.Click
        Dialog5.Show()
    End Sub
End Class
