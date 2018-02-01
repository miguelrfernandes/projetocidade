
Public Class SpaceInvaders
#Region "variaveis"
    Dim esquerda As Boolean
    Dim direita As Boolean
    Dim aliens(13) As PictureBox

    Dim movealien As Integer = 1

    Dim disparo As Boolean
    Dim disparo1 As Boolean
    Dim disparo2 As Boolean
    Dim disparo3 As Boolean
    Dim disparo4 As Boolean
    Dim disparo5 As Boolean

#End Region

#Region "timer"
    Private Sub move_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mover.Tick
        If esquerda Then
            nave.Left = nave.Left - 3
        End If
        If direita Then
            nave.Left = nave.Left + 3
        End If
        movealiens()
        If disparo Then
            verificardisparo()
        End If
        movetiro()
    End Sub
#End Region

#Region "controlos"
    Private Sub movestart(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Right Then
            direita = True
        End If
        If e.KeyValue = Keys.Left Then
            esquerda = True
        End If
        If e.KeyValue = Keys.Up Then
            disparo = True

        End If
    End Sub

    Private Sub movestop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = Keys.Right Then
            direita = False
        End If
        If e.KeyValue = Keys.Left Then
            esquerda = False
        End If
        If e.KeyValue = Keys.Up Then
            disparo = False

        End If
    End Sub
#End Region

    Private Sub bStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComeçarToolStripMenuItem1.Click, bStart.Click
        bStart.Hide()
        Button1.Hide()
        nave.Show()
        mover.Enabled = True
        mover.Start()
        For i = 0 To 13
            aliens(i).Visible = True
        Next
    End Sub

#Region "Subs"

    Public Sub New()
        InitializeComponent()
        createarray()

    End Sub

    Private Sub createarray()
        aliens(0) = alien1
        aliens(1) = alien2
        aliens(2) = alien3
        aliens(3) = alien4
        aliens(4) = alien5
        aliens(5) = alien6
        aliens(6) = alien7
        aliens(7) = alien8
        aliens(8) = alien9
        aliens(9) = alien10
        aliens(10) = alien11
        aliens(11) = alien12
        aliens(12) = alien13
        aliens(13) = alien14
    End Sub

    Private Sub movealiens()
        For i = 0 To 13
            aliens(i).Left = aliens(i).Left + movealien
        Next
        If alien7.Left > Me.Width - alien7.Width Or alien1.Left = 0 Then
            movealien = -1 * movealien
            For i = 0 To 13
                aliens(i).Top = aliens(i).Top + 25
            Next
        End If
    End Sub
    Private Sub verificardisparo()
        disparo = False
        If Not disparo1 Then
            disparo1 = True
            tiro1.Left = nave.Left + 50
            tiro1.Top = 550
            tiro1.Show()
            Exit Sub
        End If
        If Not disparo2 Then
            disparo2 = True
            tiro2.Left = nave.Left + 50
            tiro2.Top = 550
            tiro2.Show()
            Exit Sub
        End If
        If Not disparo3 Then
            disparo3 = True
            tiro3.Left = nave.Left + 50
            tiro3.Top = 550
            tiro3.Show()
            Exit Sub
        End If
        If Not disparo4 Then
            disparo4 = True
            tiro4.Left = nave.Left + 50
            tiro4.Top = 550
            tiro4.Show()
            Exit Sub
        End If
        If Not disparo5 Then
            disparo5 = True
            tiro5.Left = nave.Left + 50
            tiro5.Top = 550
            tiro5.Show()
            Exit Sub
        End If
    End Sub

    Private Sub movetiro()
        If disparo1 Then
            For i = 0 To 13
                If tiro1.Bounds.IntersectsWith(aliens(i).Bounds) Then
                    If (aliens(i).Visible) Then
                        aliens(i).Visible = False
                        disparo1 = False
                        tiro1.Top = -1
                    End If
                End If
            Next
            If tiro1.Top < 0 Then
                tiro1.Hide()
                disparo1 = False
            End If
            tiro1.Top = tiro1.Top - 3
        End If
        If disparo2 Then
            For i = 0 To 13
                If tiro2.Bounds.IntersectsWith(aliens(i).Bounds) Then
                    If (aliens(i).Visible) Then
                        aliens(i).Visible = False
                        disparo2 = False
                        tiro2.Top = -1
                    End If
                End If
            Next

            If tiro2.Top < 0 Then
                tiro2.Hide()
                disparo2 = False
            End If
            tiro2.Top = tiro2.Top - 3
        End If
        If disparo3 Then
            For i = 0 To 13
                If tiro3.Bounds.IntersectsWith(aliens(i).Bounds) Then
                    If (aliens(i).Visible) Then
                        aliens(i).Visible = False
                        disparo3 = False
                        tiro3.Top = -1
                    End If
                End If
            Next

            If tiro3.Top < 0 Then
                tiro3.Hide()
                disparo3 = False
            End If
            tiro3.Top = tiro3.Top - 3
        End If
        If disparo4 Then
            For i = 0 To 13
                If tiro4.Bounds.IntersectsWith(aliens(i).Bounds) Then
                    If (aliens(i).Visible) Then
                        aliens(i).Visible = False
                        disparo4 = False
                        tiro4.Top = -1
                    End If
                End If
            Next

            If tiro4.Top < 0 Then
                tiro4.Hide()
                disparo4 = False
            End If
            tiro4.Top = tiro4.Top - 3
        End If
        If disparo5 Then
            For i = 0 To 13
                If tiro5.Bounds.IntersectsWith(aliens(i).Bounds) Then
                    If (aliens(i).Visible) Then
                        aliens(i).Visible = False
                        disparo5 = False
                        tiro5.Top = -1
                    End If
                End If
            Next

            If tiro5.Top < 0 Then
                tiro5.Hide()
                disparo5 = False
            End If
            tiro5.Top = tiro5.Top - 3
        End If
    End Sub
#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, FecharToolStripMenuItem.Click, ToolStripMenuItem1.Click
        Me.Hide()


    End Sub


End Class
