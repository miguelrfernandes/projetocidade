<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cidade
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
        Me.sair = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CasinoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoletaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpaceInvadersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MuseuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirAjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'sair
        '
        Me.sair.Location = New System.Drawing.Point(147, 465)
        Me.sair.Margin = New System.Windows.Forms.Padding(4)
        Me.sair.Name = "sair"
        Me.sair.Size = New System.Drawing.Size(100, 28)
        Me.sair.TabIndex = 7
        Me.sair.Text = "Sair"
        Me.sair.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.AjudaToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1359, 28)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CasinoToolStripMenuItem, Me.MuseuToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'CasinoToolStripMenuItem
        '
        Me.CasinoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RoletaToolStripMenuItem, Me.SpaceInvadersToolStripMenuItem})
        Me.CasinoToolStripMenuItem.Name = "CasinoToolStripMenuItem"
        Me.CasinoToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.CasinoToolStripMenuItem.Text = "Casino"
        '
        'RoletaToolStripMenuItem
        '
        Me.RoletaToolStripMenuItem.Name = "RoletaToolStripMenuItem"
        Me.RoletaToolStripMenuItem.Size = New System.Drawing.Size(177, 24)
        Me.RoletaToolStripMenuItem.Text = "Roleta"
        '
        'SpaceInvadersToolStripMenuItem
        '
        Me.SpaceInvadersToolStripMenuItem.Name = "SpaceInvadersToolStripMenuItem"
        Me.SpaceInvadersToolStripMenuItem.Size = New System.Drawing.Size(177, 24)
        Me.SpaceInvadersToolStripMenuItem.Text = "Space Invaders"
        '
        'MuseuToolStripMenuItem
        '
        Me.MuseuToolStripMenuItem.Name = "MuseuToolStripMenuItem"
        Me.MuseuToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.MuseuToolStripMenuItem.Text = "Museu"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirAjudaToolStripMenuItem, Me.SobreToolStripMenuItem})
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.AjudaToolStripMenuItem.Text = "Ajuda"
        '
        'AbrirAjudaToolStripMenuItem
        '
        Me.AbrirAjudaToolStripMenuItem.Name = "AbrirAjudaToolStripMenuItem"
        Me.AbrirAjudaToolStripMenuItem.Size = New System.Drawing.Size(154, 24)
        Me.AbrirAjudaToolStripMenuItem.Text = "Abrir Ajuda"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(154, 24)
        Me.SobreToolStripMenuItem.Text = "Sobre"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(30, 24)
        Me.ToolStripMenuItem1.Text = "X"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(224, 245)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Roleta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(357, 245)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(125, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Space Invaders"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(527, 245)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Museu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Cidade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Cidade1024x728
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1359, 885)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.sair)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1359, 885)
        Me.MinimumSize = New System.Drawing.Size(1359, 885)
        Me.Name = "Cidade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cidade"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sair As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CasinoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MuseuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirAjudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RoletaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpaceInvadersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
