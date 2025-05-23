<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BootManager
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Drivers = New System.Windows.Forms.Label()
        Me.lbl_ReadyOrError = New System.Windows.Forms.Label()
        Me.BootTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(323, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LukeOS"
        '
        'lbl_Drivers
        '
        Me.lbl_Drivers.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Drivers.AutoSize = True
        Me.lbl_Drivers.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Drivers.Location = New System.Drawing.Point(12, 393)
        Me.lbl_Drivers.Name = "lbl_Drivers"
        Me.lbl_Drivers.Size = New System.Drawing.Size(147, 24)
        Me.lbl_Drivers.TabIndex = 1
        Me.lbl_Drivers.Text = "Drivers Loaded !"
        Me.lbl_Drivers.Visible = False
        '
        'lbl_ReadyOrError
        '
        Me.lbl_ReadyOrError.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_ReadyOrError.AutoSize = True
        Me.lbl_ReadyOrError.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ReadyOrError.Location = New System.Drawing.Point(12, 417)
        Me.lbl_ReadyOrError.Name = "lbl_ReadyOrError"
        Me.lbl_ReadyOrError.Size = New System.Drawing.Size(74, 24)
        Me.lbl_ReadyOrError.TabIndex = 2
        Me.lbl_ReadyOrError.Text = "Ready !"
        Me.lbl_ReadyOrError.Visible = False
        '
        'BootTimer
        '
        Me.BootTimer.Interval = 1000
        '
        'BootManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_ReadyOrError)
        Me.Controls.Add(Me.lbl_Drivers)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BootManager"
        Me.Text = "LukeOS Boot Manager"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_Drivers As Label
    Friend WithEvents lbl_ReadyOrError As Label
    Friend WithEvents BootTimer As Timer
End Class
