<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Roleta
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbSaldo = New System.Windows.Forms.Label()
        Me.tbAposta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rbVermelho = New System.Windows.Forms.RadioButton()
        Me.rbVerde = New System.Windows.Forms.RadioButton()
        Me.rbPreto = New System.Windows.Forms.RadioButton()
        Me.lbNumero = New System.Windows.Forms.Label()
        Me.lbResultado = New System.Windows.Forms.Label()
        Me.voltar = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JogarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FecharToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerAjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.X = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(667, 357)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Jogar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbSaldo
        '
        Me.lbSaldo.AutoSize = True
        Me.lbSaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSaldo.Location = New System.Drawing.Point(636, 145)
        Me.lbSaldo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbSaldo.Name = "lbSaldo"
        Me.lbSaldo.Size = New System.Drawing.Size(190, 33)
        Me.lbSaldo.TabIndex = 4
        Me.lbSaldo.Text = "Dinheiro: 50€"
        '
        'tbAposta
        '
        Me.tbAposta.Location = New System.Drawing.Point(712, 314)
        Me.tbAposta.Margin = New System.Windows.Forms.Padding(4)
        Me.tbAposta.Name = "tbAposta"
        Me.tbAposta.Size = New System.Drawing.Size(132, 22)
        Me.tbAposta.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(632, 314)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Aposta"
        '
        'rbVermelho
        '
        Me.rbVermelho.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbVermelho.AutoSize = True
        Me.rbVermelho.BackColor = System.Drawing.Color.Transparent
        Me.rbVermelho.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbVermelho.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rbVermelho.Location = New System.Drawing.Point(515, 220)
        Me.rbVermelho.Margin = New System.Windows.Forms.Padding(4)
        Me.rbVermelho.Name = "rbVermelho"
        Me.rbVermelho.Size = New System.Drawing.Size(127, 39)
        Me.rbVermelho.TabIndex = 7
        Me.rbVermelho.TabStop = True
        Me.rbVermelho.Text = "Vermelho"
        Me.rbVermelho.UseVisualStyleBackColor = False
        '
        'rbVerde
        '
        Me.rbVerde.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbVerde.AutoSize = True
        Me.rbVerde.BackColor = System.Drawing.Color.Transparent
        Me.rbVerde.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbVerde.Location = New System.Drawing.Point(700, 220)
        Me.rbVerde.Margin = New System.Windows.Forms.Padding(4)
        Me.rbVerde.Name = "rbVerde"
        Me.rbVerde.Size = New System.Drawing.Size(88, 39)
        Me.rbVerde.TabIndex = 8
        Me.rbVerde.TabStop = True
        Me.rbVerde.Text = "Verde"
        Me.rbVerde.UseVisualStyleBackColor = False
        '
        'rbPreto
        '
        Me.rbPreto.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbPreto.AutoSize = True
        Me.rbPreto.BackColor = System.Drawing.Color.Transparent
        Me.rbPreto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPreto.Location = New System.Drawing.Point(851, 220)
        Me.rbPreto.Margin = New System.Windows.Forms.Padding(4)
        Me.rbPreto.Name = "rbPreto"
        Me.rbPreto.Size = New System.Drawing.Size(81, 39)
        Me.rbPreto.TabIndex = 9
        Me.rbPreto.TabStop = True
        Me.rbPreto.Text = "Preto"
        Me.rbPreto.UseVisualStyleBackColor = False
        '
        'lbNumero
        '
        Me.lbNumero.AutoSize = True
        Me.lbNumero.BackColor = System.Drawing.Color.Sienna
        Me.lbNumero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNumero.ForeColor = System.Drawing.Color.LightGray
        Me.lbNumero.Location = New System.Drawing.Point(617, 407)
        Me.lbNumero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNumero.Name = "lbNumero"
        Me.lbNumero.Size = New System.Drawing.Size(164, 48)
        Me.lbNumero.TabIndex = 10
        Me.lbNumero.Text = "Número"
        Me.lbNumero.Visible = False
        '
        'lbResultado
        '
        Me.lbResultado.AutoSize = True
        Me.lbResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbResultado.Location = New System.Drawing.Point(593, 502)
        Me.lbResultado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbResultado.Name = "lbResultado"
        Me.lbResultado.Size = New System.Drawing.Size(202, 48)
        Me.lbResultado.TabIndex = 10
        Me.lbResultado.Text = "Resultado"
        Me.lbResultado.Visible = False
        '
        'voltar
        '
        Me.voltar.Location = New System.Drawing.Point(648, 692)
        Me.voltar.Margin = New System.Windows.Forms.Padding(4)
        Me.voltar.Name = "voltar"
        Me.voltar.Size = New System.Drawing.Size(100, 28)
        Me.voltar.TabIndex = 11
        Me.voltar.Text = "Fechar"
        Me.voltar.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.AjudaToolStripMenuItem, Me.X})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1344, 28)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "X"
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
        Me.FecharToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
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
        'X
        '
        Me.X.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(30, 24)
        Me.X.Text = "X"
        '
        'Roleta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.roletaimagem
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1344, 849)
        Me.Controls.Add(Me.voltar)
        Me.Controls.Add(Me.lbResultado)
        Me.Controls.Add(Me.lbNumero)
        Me.Controls.Add(Me.rbPreto)
        Me.Controls.Add(Me.rbVerde)
        Me.Controls.Add(Me.rbVermelho)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbAposta)
        Me.Controls.Add(Me.lbSaldo)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Roleta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Casino"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbSaldo As System.Windows.Forms.Label
    Friend WithEvents tbAposta As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rbVermelho As System.Windows.Forms.RadioButton
    Friend WithEvents rbVerde As System.Windows.Forms.RadioButton
    Friend WithEvents rbPreto As System.Windows.Forms.RadioButton
    Friend WithEvents lbNumero As System.Windows.Forms.Label
    Friend WithEvents lbResultado As System.Windows.Forms.Label
    Friend WithEvents voltar As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JogarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FecharToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerAjudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents X As System.Windows.Forms.ToolStripMenuItem
End Class
