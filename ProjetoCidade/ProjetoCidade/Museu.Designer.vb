<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Museu
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
        Me.lbPergunta = New System.Windows.Forms.Label()
        Me.bStart = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.bContinuar = New System.Windows.Forms.Button()
        Me.quadro = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JogarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FecharToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerAjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.quadro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbPergunta
        '
        Me.lbPergunta.AutoSize = True
        Me.lbPergunta.Location = New System.Drawing.Point(571, 614)
        Me.lbPergunta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbPergunta.Name = "lbPergunta"
        Me.lbPergunta.Size = New System.Drawing.Size(135, 17)
        Me.lbPergunta.TabIndex = 1
        Me.lbPergunta.Text = "Que quadro é este?"
        Me.lbPergunta.Visible = False
        '
        'bStart
        '
        Me.bStart.Location = New System.Drawing.Point(560, 568)
        Me.bStart.Margin = New System.Windows.Forms.Padding(4)
        Me.bStart.Name = "bStart"
        Me.bStart.Size = New System.Drawing.Size(225, 82)
        Me.bStart.TabIndex = 2
        Me.bStart.Text = "Começar"
        Me.bStart.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(336, 690)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(115, 21)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        Me.RadioButton1.Visible = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(336, 759)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(115, 21)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        Me.RadioButton2.Visible = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(760, 690)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(115, 21)
        Me.RadioButton3.TabIndex = 5
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        Me.RadioButton3.Visible = False
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(760, 759)
        Me.RadioButton4.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(115, 21)
        Me.RadioButton4.TabIndex = 6
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "RadioButton4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        Me.RadioButton4.Visible = False
        '
        'bContinuar
        '
        Me.bContinuar.Location = New System.Drawing.Point(1028, 729)
        Me.bContinuar.Margin = New System.Windows.Forms.Padding(4)
        Me.bContinuar.Name = "bContinuar"
        Me.bContinuar.Size = New System.Drawing.Size(100, 28)
        Me.bContinuar.TabIndex = 7
        Me.bContinuar.Text = "Continuar"
        Me.bContinuar.UseVisualStyleBackColor = True
        Me.bContinuar.Visible = False
        '
        'quadro
        '
        Me.quadro.BackColor = System.Drawing.Color.Transparent
        Me.quadro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.quadro.Image = Global.WindowsApplication1.My.Resources.Resources._1
        Me.quadro.Location = New System.Drawing.Point(448, 192)
        Me.quadro.Margin = New System.Windows.Forms.Padding(4)
        Me.quadro.Name = "quadro"
        Me.quadro.Size = New System.Drawing.Size(472, 356)
        Me.quadro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.quadro.TabIndex = 8
        Me.quadro.TabStop = False
        Me.quadro.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.XToolStripMenuItem, Me.MenuToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1344, 28)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'XToolStripMenuItem
        '
        Me.XToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.XToolStripMenuItem.Name = "XToolStripMenuItem"
        Me.XToolStripMenuItem.Size = New System.Drawing.Size(30, 24)
        Me.XToolStripMenuItem.Text = "X"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JogarToolStripMenuItem, Me.FecharToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'JogarToolStripMenuItem
        '
        Me.JogarToolStripMenuItem.Name = "JogarToolStripMenuItem"
        Me.JogarToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.JogarToolStripMenuItem.Text = "Jogar"
        '
        'FecharToolStripMenuItem
        '
        Me.FecharToolStripMenuItem.Name = "FecharToolStripMenuItem"
        Me.FecharToolStripMenuItem.Size = New System.Drawing.Size(121, 24)
        Me.FecharToolStripMenuItem.Text = "Fechar"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerAjudaToolStripMenuItem, Me.SobreToolStripMenuItem})
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.AjudaToolStripMenuItem.Text = "Ajuda"
        '
        'VerAjudaToolStripMenuItem
        '
        Me.VerAjudaToolStripMenuItem.Name = "VerAjudaToolStripMenuItem"
        Me.VerAjudaToolStripMenuItem.Size = New System.Drawing.Size(142, 24)
        Me.VerAjudaToolStripMenuItem.Text = "Ver Ajuda"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(142, 24)
        Me.SobreToolStripMenuItem.Text = "Sobre"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(574, 814)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Fechar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Museu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Museu1024x728
        Me.ClientSize = New System.Drawing.Size(1344, 849)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.quadro)
        Me.Controls.Add(Me.bContinuar)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.bStart)
        Me.Controls.Add(Me.lbPergunta)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Museu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Museu — Quiz"
        CType(Me.quadro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbPergunta As System.Windows.Forms.Label
    Friend WithEvents bStart As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents bContinuar As System.Windows.Forms.Button
    Friend WithEvents quadro As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents XToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JogarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FecharToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerAjudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
