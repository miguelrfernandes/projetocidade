Imports System
Imports System.IO

Public Class Museu
    Dim path As String = Directory.GetCurrentDirectory()

    Dim numresposta As Integer

    Dim registo(9) As Integer

    Dim registocontador As Integer = 0

    Dim PrimeiraVez As Boolean = True

    Private Sub programa()
        PrimeiraVez = False
        lbPergunta.Show()
        RadioButton1.Show()
        RadioButton2.Show()
        RadioButton3.Show()
        RadioButton4.Show()
        bContinuar.Show()

        Dim numquadro As Integer

        Dim opcoes(3) As String
        'randomizar numero do quadro
        Randomize()

        numresposta = Rnd() * 3
        If registocontador = 10 Then
            MsgBox("O jogo acabou!")
            Me.Hide()
            Cidade.Show()
        End If
        numquadro = Rnd() * 9
        While registo(numquadro) = 1
            numquadro = Rnd() * 9
        End While
        registo(numquadro) = 1
        registocontador += 1


        quadro.Image = Image.FromFile(path & "\museu\" & numquadro & ".jpg")
        quadro.Show()
        FileOpen(1, path & "\museu\" & numquadro & ".txt", OpenMode.Input)
        Input(1, opcoes(0))
        Input(1, opcoes(1))
        Input(1, opcoes(2))
        Input(1, opcoes(3))
        FileClose(1)
        Select Case numresposta
            Case 0
                RadioButton1.Text = opcoes(0)
                RadioButton2.Text = opcoes(1)
                RadioButton3.Text = opcoes(2)
                RadioButton4.Text = opcoes(3)
            Case 1
                RadioButton1.Text = opcoes(3)
                RadioButton2.Text = opcoes(0)
                RadioButton3.Text = opcoes(1)
                RadioButton4.Text = opcoes(2)
            Case 2
                RadioButton1.Text = opcoes(2)
                RadioButton2.Text = opcoes(3)
                RadioButton3.Text = opcoes(0)
                RadioButton4.Text = opcoes(1)
            Case 3
                RadioButton1.Text = opcoes(1)
                RadioButton2.Text = opcoes(2)
                RadioButton3.Text = opcoes(3)
                RadioButton4.Text = opcoes(0)
        End Select
    End Sub

    Private Sub resposta()
        Dim answer As Boolean = False
        If RadioButton1.Checked And numresposta = 0 Then
            answer = True
        End If
        If RadioButton2.Checked And numresposta = 1 Then
            answer = True
        End If
        If RadioButton3.Checked And numresposta = 2 Then
            answer = True
        End If
        If RadioButton4.Checked And numresposta = 3 Then
            answer = True
        End If

        If answer Then
            MsgBox("Resposta Acertada!")
        Else
            MsgBox("Reposta Errada!")
        End If

    End Sub

    Private Sub bStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bStart.Click
        bStart.Hide()
        For i As Integer = 0 To 9
            registo(i) = 0
        Next
        programa()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bContinuar.Click
        resposta()
        programa()
    End Sub

    Private Sub XToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XToolStripMenuItem.Click, FecharToolStripMenuItem.Click, Button1.Click
        Me.Hide()
        Cidade.Show()
    End Sub

    Private Sub JogarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JogarToolStripMenuItem.Click
        bStart.Hide()
        If Not PrimeiraVez Then
            resposta()
        End If
        programa()
    End Sub
End Class