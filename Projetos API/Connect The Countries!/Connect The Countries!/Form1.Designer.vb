<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RosaDosVentosOrigamiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuizEuropaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JogoDaMemóriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ObjectivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjudaToolStripMenuItem, Me.ObjectivosToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(982, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RosaDosVentosOrigamiToolStripMenuItem, Me.QuizEuropaToolStripMenuItem, Me.JogoDaMemóriaToolStripMenuItem})
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AjudaToolStripMenuItem.Text = "Ajuda"
        '
        'RosaDosVentosOrigamiToolStripMenuItem
        '
        Me.RosaDosVentosOrigamiToolStripMenuItem.Name = "RosaDosVentosOrigamiToolStripMenuItem"
        Me.RosaDosVentosOrigamiToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.RosaDosVentosOrigamiToolStripMenuItem.Text = "Rosa dos Ventos (Origami)"
        '
        'QuizEuropaToolStripMenuItem
        '
        Me.QuizEuropaToolStripMenuItem.Name = "QuizEuropaToolStripMenuItem"
        Me.QuizEuropaToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.QuizEuropaToolStripMenuItem.Text = "Quiz! - Europa"
        '
        'JogoDaMemóriaToolStripMenuItem
        '
        Me.JogoDaMemóriaToolStripMenuItem.Name = "JogoDaMemóriaToolStripMenuItem"
        Me.JogoDaMemóriaToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.JogoDaMemóriaToolStripMenuItem.Text = "Jogo da Memória"
        '
        'ObjectivosToolStripMenuItem
        '
        Me.ObjectivosToolStripMenuItem.Name = "ObjectivosToolStripMenuItem"
        Me.ObjectivosToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.ObjectivosToolStripMenuItem.Text = "Objectivos"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.Location = New System.Drawing.Point(22, 94)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 104)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Rosa dos Ventos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Origami)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Consolas", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(22, 205)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 104)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Quiz! - Europa"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(22, 315)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(140, 104)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Jogo da Memória"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(229, 67)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 26)
        Me.Label1.TabIndex = 8
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(982, 459)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(998, 497)
        Me.MinimumSize = New System.Drawing.Size(998, 497)
        Me.Name = "Form1"
        Me.Text = "Connect The Countries !"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ObjectivosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents AjudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RosaDosVentosOrigamiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JogoDaMemóriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuizEuropaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
