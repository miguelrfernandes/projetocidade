
Public Class Cidade

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Casino.Show()
        lbSaldo.Hide()
        Button1.Hide()
        Button2.Hide()
        Button3.Show()
    End Sub


    Private Sub sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sair.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Museu.Show()
        lbSaldo.Hide()
        Button1.Hide()
        Button2.Hide()
        Button3.Show()
    End Sub

    Private Sub Cidade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        lbSaldo.Text = "Saldo: " & VariaveisGlobais.saldo & "€"
        lbSaldo.Show()
        Button1.Show()
        Button2.Show()
        Button3.Hide()
    End Sub
End Class

