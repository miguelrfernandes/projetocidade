<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpaceInvaders
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.mover = New System.Windows.Forms.Timer(Me.components)
        Me.bStart = New System.Windows.Forms.Button()
        Me.alien1 = New System.Windows.Forms.PictureBox()
        Me.nave = New System.Windows.Forms.PictureBox()
        Me.alien2 = New System.Windows.Forms.PictureBox()
        Me.alien3 = New System.Windows.Forms.PictureBox()
        Me.alien4 = New System.Windows.Forms.PictureBox()
        Me.alien5 = New System.Windows.Forms.PictureBox()
        Me.alien8 = New System.Windows.Forms.PictureBox()
        Me.alien7 = New System.Windows.Forms.PictureBox()
        Me.alien6 = New System.Windows.Forms.PictureBox()
        Me.alien9 = New System.Windows.Forms.PictureBox()
        Me.alien10 = New System.Windows.Forms.PictureBox()
        Me.alien11 = New System.Windows.Forms.PictureBox()
        Me.alien12 = New System.Windows.Forms.PictureBox()
        Me.alien13 = New System.Windows.Forms.PictureBox()
        Me.alien14 = New System.Windows.Forms.PictureBox()
        Me.tiro1 = New System.Windows.Forms.Label()
        Me.tiro2 = New System.Windows.Forms.Label()
        Me.tiro3 = New System.Windows.Forms.Label()
        Me.tiro4 = New System.Windows.Forms.Label()
        Me.tiro5 = New System.Windows.Forms.Label()
        Me.tiro6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.alien1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.alien14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mover
        '
        Me.mover.Interval = 10
        '
        'bStart
        '
        Me.bStart.Location = New System.Drawing.Point(463, 194)
        Me.bStart.Name = "bStart"
        Me.bStart.Size = New System.Drawing.Size(144, 88)
        Me.bStart.TabIndex = 1
        Me.bStart.Text = "Começar"
        Me.bStart.UseVisualStyleBackColor = True
        '
        'alien1
        '
        Me.alien1.Image = Global.WindowsApplication1.My.Resources.Resources.invader
        Me.alien1.Location = New System.Drawing.Point(100, 100)
        Me.alien1.Name = "alien1"
        Me.alien1.Size = New System.Drawing.Size(100, 100)
        Me.alien1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.alien1.TabIndex = 2
        Me.alien1.TabStop = False
        Me.alien1.Visible = False
        '
        'nave
        '
        Me.nave.Image = Global.WindowsApplication1.My.Resources.Resources.nave
        Me.nave.Location = New System.Drawing.Point(500, 550)
        Me.nave.Name = "nave"
        Me.nave.Size = New System.Drawing.Size(100, 100)
        Me.nave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.nave.TabIndex = 0
        Me.nave.TabStop = False
        Me.nave.Visible = False
        '
        'alien2
        '
        Me.alien2.Image = Global.WindowsApplication1.My.Resources.Resources.invader
        Me.alien2.Location = New System.Drawing.Point(250, 100)
        Me.alien2.Name = "alien2"
        Me.alien2.Size = New System.Drawing.Size(100, 100)
        Me.alien2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.alien2.TabIndex = 3
        Me.alien2.TabStop = False
        Me.alien2.Visible = False
        '
        'alien3
        '
        Me.alien3.Image = Global.WindowsApplication1.My.Resources.Resources.invader
        Me.alien3.Location = New System.Drawing.Point(400, 100)
        Me.alien3.Name = "alien3"
        Me.alien3.Size = New System.Drawing.Size(100, 100)
        Me.alien3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.alien3.TabIndex = 4
        Me.alien3.TabStop = False
        Me.alien3.Visible = False
        '
        'alien4
        '
        Me.alien4.Image = Global.WindowsApplication1.My.Resources.Resources.invader
        Me.alien4.Location = New System.Drawing.Point(550, 100)
        Me.alien4.Name = "alien4"
        Me.alien4.Size = New System.Drawing.Size(100, 100)
        Me.alien4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.alien4.TabIndex = 5
        Me.alien4.TabStop = False
        Me.alien4.Visible = False
        '
        'alien5
        '
        Me.alien5.Image = Global.WindowsApplication1.My.Resources.Resources.invader
        Me.alien5.Location = New System.Drawing.Point(700, 100)
        Me.alien5.Name = "alien5"
        Me.alien5.Size = New System.Drawing.Size(100, 100)
        Me.alien5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.alien5.TabIndex = 6
        Me.alien5.TabStop = False
        Me.alien5.Visible = False
        '
        'alien8
        '
        Me.alien8.Image = Global.WindowsApplication1.My.Resources.Resources.invader
        Me.alien8.Location = New System.Drawing.Point(100, 250)
        Me.alien8.Name = "alien8"
        Me.alien8.Size = New System.Drawing.Size(100, 100)
        Me.alien8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.alien8.TabIndex = 7
        Me.alien8.TabStop = False
        Me.alien8.Visible = False
        '
        'alien7
        '
        Me.alien7.Image = Global.WindowsApplication1.My.Resources.Resources.invader
        Me.alien7.Location = New System.Drawing.Point(1000, 100)
        Me.alien7.Name = "alien7"
        Me.alien7.Size = New System.Drawing.Size(100, 100)
        Me.alien7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.alien7.TabIndex = 9
        Me.alien7.TabStop = False
        Me.alien7.Visible = False
        '
        'alien6
        '
        Me.alien6.Image = Global.WindowsApplication1.My.Resources.Resources.invader
        Me.alien6.Location = New System.Drawing.Point(850, 100)
        Me.alien6.Name = "alien6"
        Me.alien6.Size = New System.Drawing.Size(100, 100)
        Me.alien6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.alien6.TabIndex = 11
        Me.alien6.TabStop = False
        Me.alien6.Visible = False
        '
        'alien9
        '
        Me.alien9.Image = Global.WindowsApplication1.My.Resources.Resources.invader
        Me.alien9.Location = New System.Drawing.Point(250, 250)
        Me.alien9.Name = "alien9"
        Me.alien9.Size = New System.Drawing.Size(100, 100)
        Me.alien9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.alien9.TabIndex = 12
        Me.alien9.TabStop = False
        Me.alien9.Visible = False
        '
        'alien10
        '
        Me.alien10.Image = Global.WindowsApplication1.My.Resources.Resources.invader
        Me.alien10.Location = New System.Drawing.Point(400, 250)
        Me.alien10.Name = "alien10"
        Me.alien10.Size = New System.Drawing.Size(100, 100)
        Me.alien10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.alien10.TabIndex = 13
        Me.alien10.TabStop = False
        Me.alien10.Visible = False
        '
        'alien11
        '
        Me.alien11.Image = Global.WindowsApplication1.My.Resources.Resources.invader
        Me.alien11.Location = New System.Drawing.Point(550, 250)
        Me.alien11.Name = "alien11"
        Me.alien11.Size = New System.Drawing.Size(100, 100)
        Me.alien11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.alien11.TabIndex = 14
        Me.alien11.TabStop = False
        Me.alien11.Visible = False
        '
        'alien12
        '
        Me.alien12.Image = Global.WindowsApplication1.My.Resources.Resources.invader
        Me.alien12.Location = New System.Drawing.Point(700, 250)
        Me.alien12.Name = "alien12"
        Me.alien12.Size = New System.Drawing.Size(100, 100)
        Me.alien12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.alien12.TabIndex = 15
        Me.alien12.TabStop = False
        Me.alien12.Visible = False
        '
        'alien13
        '
        Me.alien13.Image = Global.WindowsApplication1.My.Resources.Resources.invader
        Me.alien13.Location = New System.Drawing.Point(850, 250)
        Me.alien13.Name = "alien13"
        Me.alien13.Size = New System.Drawing.Size(100, 100)
        Me.alien13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.alien13.TabIndex = 16
        Me.alien13.TabStop = False
        Me.alien13.Visible = False
        '
        'alien14
        '
        Me.alien14.Image = Global.WindowsApplication1.My.Resources.Resources.invader
        Me.alien14.Location = New System.Drawing.Point(1000, 250)
        Me.alien14.Name = "alien14"
        Me.alien14.Size = New System.Drawing.Size(100, 100)
        Me.alien14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.alien14.TabIndex = 17
        Me.alien14.TabStop = False
        Me.alien14.Visible = False
        '
        'tiro1
        '
        Me.tiro1.BackColor = System.Drawing.Color.White
        Me.tiro1.Location = New System.Drawing.Point(534, 536)
        Me.tiro1.Name = "tiro1"
        Me.tiro1.Size = New System.Drawing.Size(10, 37)
        Me.tiro1.TabIndex = 18
        Me.tiro1.Visible = False
        '
        'tiro2
        '
        Me.tiro2.BackColor = System.Drawing.Color.White
        Me.tiro2.Location = New System.Drawing.Point(534, 524)
        Me.tiro2.Name = "tiro2"
        Me.tiro2.Size = New System.Drawing.Size(10, 37)
        Me.tiro2.TabIndex = 19
        Me.tiro2.Visible = False
        '
        'tiro3
        '
        Me.tiro3.BackColor = System.Drawing.Color.White
        Me.tiro3.Location = New System.Drawing.Point(534, 524)
        Me.tiro3.Name = "tiro3"
        Me.tiro3.Size = New System.Drawing.Size(10, 37)
        Me.tiro3.TabIndex = 20
        Me.tiro3.Visible = False
        '
        'tiro4
        '
        Me.tiro4.BackColor = System.Drawing.Color.White
        Me.tiro4.Location = New System.Drawing.Point(534, 536)
        Me.tiro4.Name = "tiro4"
        Me.tiro4.Size = New System.Drawing.Size(10, 37)
        Me.tiro4.TabIndex = 21
        Me.tiro4.Visible = False
        '
        'tiro5
        '
        Me.tiro5.BackColor = System.Drawing.Color.White
        Me.tiro5.Location = New System.Drawing.Point(534, 536)
        Me.tiro5.Name = "tiro5"
        Me.tiro5.Size = New System.Drawing.Size(10, 37)
        Me.tiro5.TabIndex = 22
        Me.tiro5.Visible = False
        '
        'tiro6
        '
        Me.tiro6.BackColor = System.Drawing.Color.White
        Me.tiro6.Location = New System.Drawing.Point(547, 550)
        Me.tiro6.Name = "tiro6"
        Me.tiro6.Size = New System.Drawing.Size(10, 37)
        Me.tiro6.TabIndex = 23
        Me.tiro6.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(463, 315)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 88)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Sair"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SpaceInvaders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1175, 679)
        Me.Controls.Add(Me.tiro6)
        Me.Controls.Add(Me.tiro5)
        Me.Controls.Add(Me.tiro4)
        Me.Controls.Add(Me.tiro3)
        Me.Controls.Add(Me.tiro2)
        Me.Controls.Add(Me.tiro1)
        Me.Controls.Add(Me.alien14)
        Me.Controls.Add(Me.alien13)
        Me.Controls.Add(Me.alien12)
        Me.Controls.Add(Me.alien11)
        Me.Controls.Add(Me.alien10)
        Me.Controls.Add(Me.alien9)
        Me.Controls.Add(Me.alien6)
        Me.Controls.Add(Me.alien7)
        Me.Controls.Add(Me.alien8)
        Me.Controls.Add(Me.alien5)
        Me.Controls.Add(Me.alien4)
        Me.Controls.Add(Me.alien3)
        Me.Controls.Add(Me.alien2)
        Me.Controls.Add(Me.alien1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.bStart)
        Me.Controls.Add(Me.nave)
        Me.KeyPreview = True
        Me.Name = "SpaceInvaders"
        Me.Text = "Space Invaders"
        CType(Me.alien1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alien2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alien3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alien4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alien5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alien8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alien7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alien6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alien9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alien10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alien11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alien12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alien13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.alien14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents nave As System.Windows.Forms.PictureBox
    Friend WithEvents mover As System.Windows.Forms.Timer
    Friend WithEvents bStart As System.Windows.Forms.Button
    Friend WithEvents alien1 As System.Windows.Forms.PictureBox
    Friend WithEvents alien2 As System.Windows.Forms.PictureBox
    Friend WithEvents alien3 As System.Windows.Forms.PictureBox
    Friend WithEvents alien4 As System.Windows.Forms.PictureBox
    Friend WithEvents alien5 As System.Windows.Forms.PictureBox
    Friend WithEvents alien8 As System.Windows.Forms.PictureBox
    Friend WithEvents alien7 As System.Windows.Forms.PictureBox
    Friend WithEvents alien6 As System.Windows.Forms.PictureBox
    Friend WithEvents alien9 As System.Windows.Forms.PictureBox
    Friend WithEvents alien10 As System.Windows.Forms.PictureBox
    Friend WithEvents alien11 As System.Windows.Forms.PictureBox
    Friend WithEvents alien12 As System.Windows.Forms.PictureBox
    Friend WithEvents alien13 As System.Windows.Forms.PictureBox
    Friend WithEvents alien14 As System.Windows.Forms.PictureBox
    Friend WithEvents tiro1 As System.Windows.Forms.Label
    Friend WithEvents tiro2 As System.Windows.Forms.Label
    Friend WithEvents tiro3 As System.Windows.Forms.Label
    Friend WithEvents tiro4 As System.Windows.Forms.Label
    Friend WithEvents tiro5 As System.Windows.Forms.Label
    Friend WithEvents tiro6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
