Public Class Casino

    Private Sub bCasinoVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bVoltar.Click
        Me.Hide()
        Cidade.Show()
    End Sub

    Private Sub bRoleta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bRoleta.Click
        Me.Hide()
        Roleta.Show()
    End Sub
    Dim SI = New SpaceInvaders()
    Private Sub bSpaceInvaders_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSpaceInvaders.Click
        Me.Hide()
        SI.Show()
    End Sub
End Class