Public Class Museu

    Private Sub bStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bStart.Click
        bStart.Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim resposta As Integer
        If RadioButton1.Checked Then
            resposta = 1
        End If
        If RadioButton2.Checked Then
            resposta = 2
        End If
        If RadioButton3.Checked Then
            resposta = 3
        End If
        If RadioButton4.Checked Then
            resposta = 4
        End If
        lbPergunta.Text = "Outra Pergunta"

    End Sub
End Class