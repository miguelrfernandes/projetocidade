Public Class Inicio
    Private Sub Entrar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjudaToolStripMenuItem.Click, Button4.Click
        Login.Show()
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistarToolStripMenuItem.Click, Button1.Click
        Registar.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click, ToolStripMenuItem1.Click, Button2.Click
        Me.Close()
    End Sub

    Private Sub VerAjudaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerAjudaToolStripMenuItem.Click
        Ajuda.Show()
    End Sub

    Private Sub SobreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SobreToolStripMenuItem.Click
        Sobre.show()
    End Sub
End Class