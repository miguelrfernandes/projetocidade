Public Class Roleta
    Private Sub rodar()
        Dim sorte As Integer
        Dim aposta As Integer
        Dim resultado As Integer
        Randomize()
        sorte = Rnd() * 35
        aposta = tbAposta.Text
        saldo = saldo - aposta
        lbNumero.Visible = True
        lbResultado.Visible = True
        If sorte Mod 2 = 0 And sorte <> 0 Then
            lbNumero.BackColor = Color.Black
            If rbPreto.Checked Then
                resultado = aposta * 2
            End If
        End If
        If sorte = 0 Then
            lbNumero.BackColor = Color.Green
            If rbVerde.Checked Then
                resultado = aposta * 35
            End If
        End If
        If sorte Mod 2 = 1 Then
            lbNumero.BackColor = Color.Red
            If rbVermelho.Checked Then
                resultado = aposta * 2
            End If
        End If
        saldo = saldo + resultado
        lbNumero.Text = sorte
        lbSaldo.Text = "Saldo: " & saldo & "€"
        If resultado > 0 Then
            lbResultado.Text = "Ganhaste " & resultado & "€"
        Else
            lbResultado.Text = "Perdeste"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, JogarToolStripMenuItem.Click
        Try
            rodar()
        Catch ex As Exception
            MsgBox("Erro")
        End Try
    End Sub

    Private Sub voltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles voltar.Click, FecharToolStripMenuItem.Click, X.Click
        Me.Hide()
        Cidade.Show()
    End Sub
End Class