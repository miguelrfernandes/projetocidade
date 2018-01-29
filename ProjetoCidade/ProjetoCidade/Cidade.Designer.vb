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
        Me.lbSaldo = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.sair = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbSaldo
        '
        Me.lbSaldo.AutoSize = True
        Me.lbSaldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSaldo.Location = New System.Drawing.Point(188, 134)
        Me.lbSaldo.Name = "lbSaldo"
        Me.lbSaldo.Size = New System.Drawing.Size(127, 27)
        Me.lbSaldo.TabIndex = 5
        Me.lbSaldo.Text = "Saldo: 50€"
        Me.lbSaldo.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(96, 239)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Casino"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(291, 239)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 40)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Museu"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'sair
        '
        Me.sair.Location = New System.Drawing.Point(291, 376)
        Me.sair.Name = "sair"
        Me.sair.Size = New System.Drawing.Size(75, 23)
        Me.sair.TabIndex = 7
        Me.sair.Text = "Sair"
        Me.sair.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(167, 239)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(199, 77)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Entrar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Cidade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Cidade1024x728
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1008, 690)
        Me.Controls.Add(Me.sair)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lbSaldo)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1024, 728)
        Me.MinimumSize = New System.Drawing.Size(1024, 728)
        Me.Name = "Cidade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cidade"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbSaldo As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents sair As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
