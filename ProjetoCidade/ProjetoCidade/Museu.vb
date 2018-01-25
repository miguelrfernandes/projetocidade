Imports System
Imports System.IO

Public Class Museu
    Dim path As String = Directory.GetCurrentDirectory()
    Private Sub bStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bStart.Click
        bStart.Hide()
        programa()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        programa()



    End Sub

    Private Sub programa()
        Dim numquadro As Integer = 1
        Dim opcoes(3) As String
        'randomizar numero do quadro
        Randomize()

        numquadro = Rnd() * 4
        'MsgBox(path & "museu\" & numquadro & ".jpg")

        quadro.Image = Image.FromFile(path & "\museu\" & numquadro & ".jpg")
        quadro.Show()
        FileOpen(1, path & "\museu\" & numquadro & ".txt", OpenMode.Input)
        Input(1, opcoes(0))
        Input(1, opcoes(1))
        Input(1, opcoes(2))
        Input(1, opcoes(3))
        RadioButton1.Text = opcoes(0)
        RadioButton2.Text = opcoes(1)
        RadioButton3.Text = opcoes(2)
        RadioButton4.Text = opcoes(3)
        FileClose(1)
    End Sub

    Private Sub das()
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