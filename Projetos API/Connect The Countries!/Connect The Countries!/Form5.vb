Imports System.IO

Public Class Form5

    Dim tabela(44), q(5), d, certo, errado, ex, capital As Integer, respostas(), codigo(), linhas() As String, flip As Boolean = False

    Dim ajuda_usada As Boolean = False, n_hints As Integer = 8, n_hint_usada As Integer, inform(2) As String


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()
        backmenu()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
        backmenu()
    End Sub

    'Este serve para fazer restart
    Sub backmenu()

        Label1.Visible = True
        Label2.Visible = False
        Panel1.Visible = False

        BatotaToolStripMenuItem.Enabled = False
        BatotaToolStripMenuItem.Text = "Batota - OFF"
        flip = False

        Button7.Text = "Hints - 8"
        n_hints = 8

    End Sub

    'Este procedimento coloca os números (1 até 44) misturados ao calhas, porém sem se repetir nenhum e insere-os todos numa tabela.
    Sub RanNum()

        Dim c, j, valor As Integer
        c = 0
        For i = 0 To 44
            tabela(i) = 0
        Next

        For i = 0 To 1
            Randomize()
            valor = CInt(Int((43 * Rnd()) + 1))

            tabela(i) = valor
        Next

        j = 1
        While (j <= 44)
            c = j - 1
            Do While (c >= 1)
                If tabela(j) <> tabela(c) Then
                    c = c - 1
                Else
                    Randomize()
                    valor = CInt(Int((43 * Rnd()) + 1))
                    tabela(j) = valor
                    c = j - 1
                End If
            Loop
            j = j + 1
        End While

        TextBox1.Clear()
        For i = 1 To 44
            tabela(i) = tabela(i) + 1
            TextBox1.Text = TextBox1.Text & "País: " & tabela(i) & vbCrLf
        Next

    End Sub


    'Este procedimento coloca os números (1 até 4) misturados ao calhas, porém sem se repetir nenhum e insere-os todos numa tabela.
    Sub RanResposta()
        Dim c, j, valor As Integer

        c = 0
        For i = 1 To 5
            q(i) = 0
        Next

        For i = 1 To 2
            Randomize()
            valor = CInt(Int((4 * Rnd() + 1)))

            q(i) = valor
        Next

        j = 2
        While (j <= 5)
            c = j - 1
            Do While (c >= 1)
                If q(j) <> q(c) Then
                    c = c - 1
                Else
                    Randomize()
                    valor = CInt(Int((4 * Rnd()) + 1))
                    q(j) = valor
                    c = j - 1
                End If
            Loop
            j = j + 1
        End While

        TextBox2.Clear()

        'Esta pequena parte de código está reservada para a Batota
        Dim abcd(5) As String

        abcd(1) = "(A) - "
        abcd(2) = "(B) - "
        abcd(4) = "(C) - "
        abcd(5) = "(D) - "

        For i = 1 To 5
            If q(i) <> 0 Then
                If q(i) = 4 Then
                    TextBox2.Text = TextBox2.Text & abcd(i) & "Resposta Certa" & vbCrLf
                Else
                    TextBox2.Text = TextBox2.Text & abcd(i) & vbCrLf
                End If
            End If
        Next
    End Sub


    'Este procedimento codifica em cada um dos números da tabela, uma imagem específica e escreve as opções nos botões
    Sub europa()

        If d = 1 Then
            RichTextBox1.Visible = True
        End If

        d = d + 1

        If d < 45 Then
            For i = 0 To 44
                If tabela(d) = i Then

                    PictureBox1.Image = Image.FromFile(codigo(i - 1))

                    Button3.Text = "(A) "
                    Button4.Text = "(B) "
                    Button5.Text = "(C) "
                    Button6.Text = "(D) "

                    RanResposta()

                    TextBox2.Text = TextBox2.Text & vbCrLf & "País: " & i & vbCrLf

                    Button3.Text = Button3.Text & linhas((4 * i) - q(1))
                    Button4.Text = Button4.Text & linhas((4 * i) - q(2))
                    Button5.Text = Button5.Text & linhas((4 * i) - q(4))
                    Button6.Text = Button6.Text & linhas((4 * i) - q(5))

                    TextBox3.Clear()
                    TextBox3.Text = TextBox3.Text & certo & vbCrLf
                    TextBox4.Clear()
                    TextBox4.Text = TextBox4.Text & errado & vbCrLf

                    i = 45
                End If
            Next
        ElseIf d = 45 Then

            TextBox3.Clear()
            TextBox3.Text = TextBox3.Text & certo & vbCrLf
            TextBox4.Clear()
            TextBox4.Text = TextBox4.Text & errado & vbCrLf

            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
            Button6.Enabled = False

            If n_hints > 8 Then
                inform(1) = vbCrLf & "Arranjaste mais (" & n_hints & " - 8 = " & n_hints - 8 & ") hints do que as que tinhas inicialmente!"
            ElseIf n_hints = 8 Then
                inform(1) = vbCrLf & "Variação nula de hints! Tens as mesmas com que começaste!"
            ElseIf n_hints < 8 And n_hints > 1 Then
                inform(1) = vbCrLf & "Precisaste de " & n_hint_usada & " hints."
            ElseIf n_hints = 1 Then
                inform(1) = vbCrLf & "Deixaste só uma hint. Podias tê-la aproveitado."
            Else
                inform(1) = vbCrLf & "Isso é que foi gastar hints, foram todas."
            End If

            If certo = 0 Then
                MsgBox("Parabéns por teres concluido o Quiz! Vamos ver as pontuações." & vbCrLf & vbCrLf & "Não acertaste em nenhuma resposta. É preciso perícia! ;)" & inform(1) & inform(2), 64, "Resultados")
            ElseIf certo >= 1 And certo < 11 Then
                MsgBox("Parabéns por teres concluido o Quiz! Vamos ver as pontuações." & vbCrLf & vbCrLf & "Acertaste só " & certo & " respostas. Tens que melhorar nisso!" & inform(1) & inform(2), 64, "Resultados")
            ElseIf certo >= 11 And certo < 22 Then
                MsgBox("Parabéns por teres concluido o Quiz! Vamos ver as pontuações." & vbCrLf & vbCrLf & "Acertaste em " & certo & " respostas. Podias fazer melhor!" & inform(1) & inform(2), 64, "Resultados")
            ElseIf certo >= 22 And certo < 33 Then
                MsgBox("Parabéns por teres concluido o Quiz! Vamos ver as pontuações." & vbCrLf & vbCrLf & "Acertaste em " & certo & " respostas.  Boa! Um número considerável, continua o bom trabalho!" & inform(1) & inform(2), 64, "Resultados")
            ElseIf certo >= 33 And certo < 44 Then
                MsgBox("Parabéns por teres concluido o Quiz! Vamos ver as pontuações." & vbCrLf & vbCrLf & "Acertaste em " & certo & " respostas. Muito bem, já são muitas respostas certas!" & inform(1) & inform(2), 64, "Resultados")
            ElseIf certo = 44 Then
                MsgBox("Parabéns por teres concluido o Quiz! Vamos ver as pontuações." & vbCrLf & vbCrLf & "Acertaste em todas as respostas! És um verdadeiro Às!" & inform(1) & inform(2), 64, "Resultados")
            End If

            Panel1.Visible = False
            Label2.Visible = False

        End If

    End Sub

    'Este procedimento serve para determinar se a escolha é acertada ou não. Também escreve um pequeno comentário numa RichTextBox.
    Sub CertoErrado()

        Dim valor As Integer, nova As Boolean = False

        RichTextBox1.Clear()

        For i = 0 To 44
            If tabela(d) = i Then
                valor = i
                i = 45
            End If
        Next

        RichTextBox1.Text = RichTextBox1.Text & "Resposta certa: " & linhas((4 * valor) - 4) & vbCrLf
        RichTextBox1.Text = RichTextBox1.Text & "Tu escolheste: " & linhas((4 * valor) - q(ex)) & vbCrLf

        If (q(ex) = 4) Then
            certo = certo + 1
            RichTextBox1.Text = RichTextBox1.Text & vbCrLf & "Boa! Acertaste!"
            nova = True
        Else
            errado = errado + 1
            RichTextBox1.Text = RichTextBox1.Text & vbCrLf & "Resposta Errada!"
            nova = False
        End If

        If nova = True Then

            For i = 1 To 8
                If i * 5 = certo Then
                    n_hints = n_hints + 1
                    Button7.Text = "Hints - " & n_hints
                End If
            Next
            nova = False
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ex = 1
        CertoErrado()
        europa()

        ajuda_usada = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ex = 2
        CertoErrado()
        europa()

        ajuda_usada = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ex = 4
        CertoErrado()
        europa()

        ajuda_usada = False
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ex = 5
        CertoErrado()
        europa()

        ajuda_usada = False
    End Sub

    Private Sub NovoJogoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoJogoToolStripMenuItem.Click
        Label1.Visible = False
        Label2.Visible = True
        Panel1.Visible = True

        RichTextBox1.Clear()
        Button7.Text = "Hints - 8"
        BatotaToolStripMenuItem.Enabled = True

        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True

        inform(2) = vbCrLf & "Vejo que não usaste nenhuma Batota, parabéns!"

        codigo = File.ReadAllLines("C:\Recursos\Texto\Code_2_1.read")
        linhas = File.ReadAllLines("C:\Recursos\Texto\Code_2_1_escolha.read")

        n_hints = 8
        certo = 0
        errado = 0
        d = 0

        RanNum()
        europa()
    End Sub

    Private Sub BatotaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatotaToolStripMenuItem.Click

        inform(2) = vbCrLf & "Bem, usaste batota! Fico contente com isso. :D"

        If flip = False Then
            flip = True
            BatotaToolStripMenuItem.Text = "Batota - ON"

            TextBox1.Visible = True
            TextBox2.Visible = True

        Else
            flip = False
            BatotaToolStripMenuItem.Text = "Batota - OFF"

            TextBox1.Visible = False
            TextBox2.Visible = False
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim hint() As String, pais As Integer

        If ajuda_usada = False Then
            ajuda_usada = True

            n_hint_usada = n_hint_usada + 1
            n_hints = n_hints - 1

            If n_hints = 0 Then
                Button7.Text = "Hints - 0"
            ElseIf n_hints >= 0 Then
                Button7.Text = "Hints - " & n_hints
            End If
        End If

        For i = 0 To 44
            If tabela(d) = i Then
                pais = i - 1
                i = 45
            End If
        Next

        hint = File.ReadAllLines("C:\Recursos\Texto\Code_2_1_hints.read")

        If n_hints >= 0 Then
            MsgBox(hint(pais), 64, "Hint")
        Else
            MsgBox("Não tens mais ajudas disponíveis!", MsgBoxStyle.Critical, "Hint")
        End If
    End Sub
End Class