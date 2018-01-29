Imports System
Imports System.IO

Public Class Museu
    Dim path As String = Directory.GetCurrentDirectory()
    Private Sub bStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bStart.Click
        bStart.Hide()
        programa()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bContinuar.Click
        programa()
        resposta()


    End Sub

    Dim numresposta As Integer

    Private Sub programa()
        lbPergunta.Show()
        RadioButton1.Show()
        RadioButton2.Show()
        RadioButton3.Show()
        RadioButton4.Show()


        Dim numquadro As Integer

        Dim opcoes(3) As String
        'randomizar numero do quadro
        Randomize()

        numquadro = Rnd() * 9
        numresposta = Rnd() * 3
        'MsgBox(path & "museu\" & numquadro & ".jpg")

        quadro.Image = Image.FromFile(path & "\museu\" & numquadro & ".jpg")
        quadro.Show()
        FileOpen(1, path & "\museu\" & numquadro & ".txt", OpenMode.Input)
        Input(1, opcoes(0))
        Input(1, opcoes(1))
        Input(1, opcoes(2))
        Input(1, opcoes(3))
        FileClose(1)
        MsgBox(numresposta)
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
        MsgBox(numresposta)
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
        End If

    End Sub
End Class