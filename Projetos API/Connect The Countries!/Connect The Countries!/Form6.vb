Imports System.IO

Public Class Form6

    Dim s, min, n1, ni, falso, stoptimer, t As Integer, config() As String, vira As Boolean = False

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()

        Timer1.Enabled = False

        Panel1.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()

        s = 0
        min = 0
        t = 0
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim escolha, valor2 As Integer

        pic_enabled()
        reset_imagens()

        stoptimer = 0
        t = 0
        s = 0
        min = 0
        Timer1.Enabled = True

        Panel1.Visible = True
        Label1.Visible = True
        Label2.Visible = True
        TextBox1.Visible = True
        TextBox2.Visible = True
        TextBox4.Visible = True
        TextBox5.Visible = True

        TextBox4.Clear()
        TextBox5.Clear()

        'Aleatório para escolher uma pré-configuração para o jogo da memória

        Randomize()
        escolha = CInt(Int((6 * Rnd()) + 1))

        While valor2 = escolha
            Randomize()
            escolha = CInt(Int((6 * Rnd()) + 1))
        End While

        valor2 = escolha
        TextBox3.Clear()
        TextBox3.Text = TextBox3.Text & escolha

        If escolha = 1 Then
            config = File.ReadAllLines("C:\Recursos\Texto\Code_3_1.read")
        ElseIf escolha = 2 Then
            config = File.ReadAllLines("C:\Recursos\Texto\Code_3_2.read")
        ElseIf escolha = 3 Then
            config = File.ReadAllLines("C:\Recursos\Texto\Code_3_3.read")
        ElseIf escolha = 4 Then
            config = File.ReadAllLines("C:\Recursos\Texto\Code_3_4.read")
        ElseIf escolha = 5 Then
            config = File.ReadAllLines("C:\Recursos\Texto\Code_3_5.read")
        ElseIf escolha = 6 Then
            config = File.ReadAllLines("C:\Recursos\Texto\Code_3_6.read")
        End If


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If s < 59 Then
            s = s + 1
        Else
            s = 0
            min = min + 1
        End If

        TextBox2.Clear()
        TextBox1.Clear()

        If s < 10 Then
            TextBox2.Text = TextBox2.Text & "0" & s
        Else
            TextBox2.Text = TextBox2.Text & s
        End If
        TextBox1.Text = TextBox1.Text & min
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        pic_enabled()
        reset_imagens()

        stoptimer = 0
        t = 0
        s = -1
        min = 0

        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Timer1.Enabled = False

        Panel1.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()

    End Sub


    'Prodecimentos a partir daqui para baixo

    Sub compara()
        Dim percentagem As Decimal

        If vira = False Then
            vira = True
            falso = 0
            n1 = ni
        Else
            vira = False

            t = t + 1
            TextBox4.Clear()
            TextBox4.Text = TextBox4.Text & t

            If n1 <> ni Then
                If config(n1) <> config(ni) Then
                    falso = 1
                    MsgBox("Errado! Tenta outra vez!", 48, "")
                Else
                    falso = 2
                    stoptimer = stoptimer + 1
                    TextBox5.Clear()
                    TextBox5.Text = TextBox5.Text & stoptimer

                    If stoptimer = 9 Then

                        percentagem = Format((((t - 9) / t) * 100), "0.00")

                        Timer1.Enabled = False
                        If min = 0 Then
                            MsgBox("Boa, concluiste o Jogo da Memória!!" & vbCrLf & vbCrLf & "Demoraste: " & s & " segundos!" & vbCrLf & "Tentativas totais: " & t & vbCrLf & "Tentativas erradas: " & t - 9 & vbCrLf & "Percentagem de tentativas erradas: " & percentagem & "%", 48)
                        ElseIf s = 0 Then
                            MsgBox("Boa, concluiste o Jogo da Memória!!" & vbCrLf & vbCrLf & "Demoraste: " & min & " min. certo(s)" & vbCrLf & "Tentativas totais: " & t & vbCrLf & "Tentativas erradas: " & t - 9 & vbCrLf & "Percentagem de tentativas erradas: " & percentagem & "%", 48)
                        Else
                            MsgBox("Boa, concluiste o Jogo da Memória!!" & vbCrLf & vbCrLf & "Demoraste: " & min & " min. e " & s & " segundos!" & vbCrLf & "Tentativas totais: " & t & vbCrLf & "Tentativas erradas: " & t - 9 & vbCrLf & "Percentagem de tentativas erradas: " & percentagem & "%", 48)
                        End If
                    End If

                End If

            Else
                MsgBox("Não podes comparar o mesmo duas vez, tens que escolher outra carta!", 64, "Erro")
                virar1a()
            End If
        End If
    End Sub

    Sub virar1a()
        If n1 = 0 Then
            PictureBox1.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        ElseIf n1 = 1 Then
            PictureBox2.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        ElseIf n1 = 2 Then
            PictureBox3.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        ElseIf n1 = 3 Then
            PictureBox4.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        ElseIf n1 = 4 Then
            PictureBox5.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        ElseIf n1 = 5 Then
            PictureBox6.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        ElseIf n1 = 6 Then
            PictureBox7.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        ElseIf n1 = 7 Then
            PictureBox8.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        ElseIf n1 = 8 Then
            PictureBox9.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        ElseIf n1 = 9 Then
            PictureBox10.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        ElseIf n1 = 10 Then
            PictureBox11.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        ElseIf n1 = 11 Then
            PictureBox12.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        ElseIf n1 = 12 Then
            PictureBox13.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        ElseIf n1 = 13 Then
            PictureBox14.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        ElseIf n1 = 14 Then
            PictureBox15.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        ElseIf n1 = 15 Then
            PictureBox16.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        ElseIf n1 = 16 Then
            PictureBox17.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        ElseIf n1 = 17 Then
            PictureBox18.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        End If
    End Sub


    Sub desativar()
        If n1 = 0 Then
            PictureBox1.Enabled = False
        ElseIf n1 = 1 Then
            PictureBox2.Enabled = False
        ElseIf n1 = 2 Then
            PictureBox3.Enabled = False
        ElseIf n1 = 3 Then
            PictureBox4.Enabled = False
        ElseIf n1 = 4 Then
            PictureBox5.Enabled = False
        ElseIf n1 = 5 Then
            PictureBox6.Enabled = False
        ElseIf n1 = 6 Then
            PictureBox7.Enabled = False
        ElseIf n1 = 7 Then
            PictureBox8.Enabled = False
        ElseIf n1 = 8 Then
            PictureBox9.Enabled = False
        ElseIf n1 = 9 Then
            PictureBox10.Enabled = False
        ElseIf n1 = 10 Then
            PictureBox11.Enabled = False
        ElseIf n1 = 11 Then
            PictureBox12.Enabled = False
        ElseIf n1 = 12 Then
            PictureBox13.Enabled = False
        ElseIf n1 = 13 Then
            PictureBox14.Enabled = False
        ElseIf n1 = 14 Then
            PictureBox15.Enabled = False
        ElseIf n1 = 15 Then
            PictureBox16.Enabled = False
        ElseIf n1 = 16 Then
            PictureBox17.Enabled = False
        ElseIf n1 = 17 Then
            PictureBox18.Enabled = False
        End If
    End Sub

    Sub pic_enabled()
        PictureBox1.Enabled = True
        PictureBox2.Enabled = True
        PictureBox3.Enabled = True
        PictureBox4.Enabled = True
        PictureBox5.Enabled = True
        PictureBox6.Enabled = True
        PictureBox7.Enabled = True
        PictureBox8.Enabled = True
        PictureBox9.Enabled = True
        PictureBox10.Enabled = True
        PictureBox11.Enabled = True
        PictureBox12.Enabled = True
        PictureBox13.Enabled = True
        PictureBox14.Enabled = True
        PictureBox15.Enabled = True
        PictureBox16.Enabled = True
        PictureBox17.Enabled = True
        PictureBox18.Enabled = True
    End Sub

    Sub reset_imagens()
        PictureBox1.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        PictureBox2.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        PictureBox3.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        PictureBox4.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        PictureBox5.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        PictureBox6.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        PictureBox7.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        PictureBox8.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        PictureBox9.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        PictureBox10.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        PictureBox11.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        PictureBox12.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        PictureBox13.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        PictureBox14.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        PictureBox15.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        PictureBox16.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        PictureBox17.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
        PictureBox18.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
    End Sub

    'Até aqui. PictureBox para baixo.



    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        ni = 0
        PictureBox1.Image = Image.FromFile(config(ni))
        compara()
        If falso = 1 Then
            PictureBox1.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
            virar1a()

        ElseIf falso = 2 Then
            PictureBox1.Enabled = False
            desativar()
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        ni = 1
        PictureBox2.Image = Image.FromFile(config(ni))
        compara()

        If falso = 1 Then
            PictureBox2.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
            virar1a()

        ElseIf falso = 2 Then
            PictureBox2.Enabled = False
            desativar()
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        ni = 2
        PictureBox3.Image = Image.FromFile(config(ni))
        compara()

        If falso = 1 Then
            PictureBox3.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
            virar1a()

        ElseIf falso = 2 Then
            PictureBox3.Enabled = False
            desativar()
        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        ni = 3
        PictureBox4.Image = Image.FromFile(config(ni))
        compara()

        If falso = 1 Then
            PictureBox4.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
            virar1a()

        ElseIf falso = 2 Then
            PictureBox4.Enabled = False
            desativar()
        End If
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        ni = 4
        PictureBox5.Image = Image.FromFile(config(ni))
        compara()

        If falso = 1 Then
            PictureBox5.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
            virar1a()

        ElseIf falso = 2 Then
            PictureBox5.Enabled = False
            desativar()
        End If
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        ni = 5
        PictureBox6.Image = Image.FromFile(config(ni))
        compara()

        If falso = 1 Then
            PictureBox6.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
            virar1a()

        ElseIf falso = 2 Then
            PictureBox6.Enabled = False
            desativar()
        End If
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        ni = 6
        PictureBox7.Image = Image.FromFile(config(ni))
        compara()

        If falso = 1 Then
            PictureBox7.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
            virar1a()

        ElseIf falso = 2 Then
            PictureBox7.Enabled = False
            desativar()
        End If
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        ni = 7
        PictureBox8.Image = Image.FromFile(config(ni))
        compara()

        If falso = 1 Then
            PictureBox8.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
            virar1a()

        ElseIf falso = 2 Then
            PictureBox8.Enabled = False
            desativar()
        End If
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        ni = 8
        PictureBox9.Image = Image.FromFile(config(ni))
        compara()

        If falso = 1 Then
            PictureBox9.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
            virar1a()

        ElseIf falso = 2 Then
            PictureBox9.Enabled = False
            desativar()
        End If
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        ni = 9
        PictureBox10.Image = Image.FromFile(config(ni))
        compara()

        If falso = 1 Then
            PictureBox10.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
            virar1a()

        ElseIf falso = 2 Then
            PictureBox10.Enabled = False
            desativar()
        End If
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        ni = 10
        PictureBox11.Image = Image.FromFile(config(ni))
        compara()

        If falso = 1 Then
            PictureBox11.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
            virar1a()

        ElseIf falso = 2 Then
            PictureBox11.Enabled = False
            desativar()
        End If
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        ni = 11
        PictureBox12.Image = Image.FromFile(config(ni))
        compara()

        If falso = 1 Then
            PictureBox12.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
            virar1a()

        ElseIf falso = 2 Then
            PictureBox12.Enabled = False
            desativar()
        End If
    End Sub

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        ni = 12
        PictureBox13.Image = Image.FromFile(config(ni))
        compara()

        If falso = 1 Then
            PictureBox13.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
            virar1a()

        ElseIf falso = 2 Then
            PictureBox13.Enabled = False
            desativar()
        End If
    End Sub

    Private Sub PictureBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox14.Click
        ni = 13
        PictureBox14.Image = Image.FromFile(config(ni))
        compara()

        If falso = 1 Then
            PictureBox14.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
            virar1a()

        ElseIf falso = 2 Then
            PictureBox14.Enabled = False
            desativar()
        End If
    End Sub

    Private Sub PictureBox15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox15.Click
        ni = 14
        PictureBox15.Image = Image.FromFile(config(ni))
        compara()

        If falso = 1 Then
            PictureBox15.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
            virar1a()

        ElseIf falso = 2 Then
            PictureBox15.Enabled = False
            desativar()
        End If
    End Sub

    Private Sub PictureBox16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox16.Click
        ni = 15
        PictureBox16.Image = Image.FromFile(config(ni))
        compara()

        If falso = 1 Then
            PictureBox16.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
            virar1a()

        ElseIf falso = 2 Then
            PictureBox16.Enabled = False
            desativar()
        End If
    End Sub

    Private Sub PictureBox17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox17.Click
        ni = 16
        PictureBox17.Image = Image.FromFile(config(ni))
        compara()

        If falso = 1 Then
            PictureBox17.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
            virar1a()

        ElseIf falso = 2 Then
            PictureBox17.Enabled = False
            desativar()
        End If
    End Sub

    Private Sub PictureBox18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox18.Click
        ni = 17
        PictureBox18.Image = Image.FromFile(config(ni))
        compara()

        If falso = 1 Then
            PictureBox18.Image = Image.FromFile("C:\Recursos\Imagens\Memoria\0.jpg")
            virar1a()

        ElseIf falso = 2 Then
            PictureBox18.Enabled = False
            desativar()
        End If
    End Sub

    Private Sub AjudaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjudaToolStripMenuItem2.Click
        Dialog3.Show()
    End Sub
End Class