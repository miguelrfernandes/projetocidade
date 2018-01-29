<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Casino
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
        Me.bSpaceInvaders = New System.Windows.Forms.Button()
        Me.bRoleta = New System.Windows.Forms.Button()
        Me.bVoltar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bSpaceInvaders
        '
        Me.bSpaceInvaders.Location = New System.Drawing.Point(148, 51)
        Me.bSpaceInvaders.Name = "bSpaceInvaders"
        Me.bSpaceInvaders.Size = New System.Drawing.Size(88, 23)
        Me.bSpaceInvaders.TabIndex = 0
        Me.bSpaceInvaders.Text = "SpaceInvaders"
        Me.bSpaceInvaders.UseVisualStyleBackColor = True
        '
        'bRoleta
        '
        Me.bRoleta.Location = New System.Drawing.Point(50, 51)
        Me.bRoleta.Name = "bRoleta"
        Me.bRoleta.Size = New System.Drawing.Size(75, 23)
        Me.bRoleta.TabIndex = 1
        Me.bRoleta.Text = "Roleta"
        Me.bRoleta.UseVisualStyleBackColor = True
        '
        'bVoltar
        '
        Me.bVoltar.Location = New System.Drawing.Point(99, 176)
        Me.bVoltar.Name = "bVoltar"
        Me.bVoltar.Size = New System.Drawing.Size(75, 23)
        Me.bVoltar.TabIndex = 2
        Me.bVoltar.Text = "Voltar"
        Me.bVoltar.UseVisualStyleBackColor = True
        '
        'Casino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 690)
        Me.Controls.Add(Me.bVoltar)
        Me.Controls.Add(Me.bRoleta)
        Me.Controls.Add(Me.bSpaceInvaders)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1024, 728)
        Me.MinimumSize = New System.Drawing.Size(1024, 728)
        Me.Name = "Casino"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Casino"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bSpaceInvaders As System.Windows.Forms.Button
    Friend WithEvents bRoleta As System.Windows.Forms.Button
    Friend WithEvents bVoltar As System.Windows.Forms.Button
End Class
