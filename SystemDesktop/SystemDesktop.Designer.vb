<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SystemDesktop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SystemDesktop))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Shutdown = New System.Windows.Forms.PictureBox()
        Me.lbl_Time = New System.Windows.Forms.Label()
        Me.btnApps = New System.Windows.Forms.Button()
        Me.App_Panel = New System.Windows.Forms.Panel()
        Me.btn_About = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AppList = New System.Windows.Forms.ListView()
        Me.AppIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.ClockTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.btn_Shutdown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.App_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.btn_Shutdown)
        Me.Panel1.Controls.Add(Me.lbl_Time)
        Me.Panel1.Controls.Add(Me.btnApps)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 516)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(990, 38)
        Me.Panel1.TabIndex = 0
        '
        'btn_Shutdown
        '
        Me.btn_Shutdown.Image = Global.SystemDesktop.My.Resources.Resources._1492790919_81power_84209
        Me.btn_Shutdown.Location = New System.Drawing.Point(4, 4)
        Me.btn_Shutdown.Name = "btn_Shutdown"
        Me.btn_Shutdown.Size = New System.Drawing.Size(41, 32)
        Me.btn_Shutdown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Shutdown.TabIndex = 2
        Me.btn_Shutdown.TabStop = False
        '
        'lbl_Time
        '
        Me.lbl_Time.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Time.AutoSize = True
        Me.lbl_Time.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Time.ForeColor = System.Drawing.Color.White
        Me.lbl_Time.Location = New System.Drawing.Point(922, 11)
        Me.lbl_Time.Name = "lbl_Time"
        Me.lbl_Time.Size = New System.Drawing.Size(49, 21)
        Me.lbl_Time.TabIndex = 1
        Me.lbl_Time.Text = "00:00"
        '
        'btnApps
        '
        Me.btnApps.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnApps.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnApps.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApps.ForeColor = System.Drawing.Color.White
        Me.btnApps.Location = New System.Drawing.Point(442, 6)
        Me.btnApps.Margin = New System.Windows.Forms.Padding(2)
        Me.btnApps.Name = "btnApps"
        Me.btnApps.Size = New System.Drawing.Size(110, 30)
        Me.btnApps.TabIndex = 0
        Me.btnApps.Text = "Apps"
        Me.btnApps.UseVisualStyleBackColor = False
        '
        'App_Panel
        '
        Me.App_Panel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.App_Panel.BackColor = System.Drawing.Color.DodgerBlue
        Me.App_Panel.Controls.Add(Me.btn_About)
        Me.App_Panel.Controls.Add(Me.Label1)
        Me.App_Panel.Controls.Add(Me.AppList)
        Me.App_Panel.Location = New System.Drawing.Point(276, 182)
        Me.App_Panel.Margin = New System.Windows.Forms.Padding(2)
        Me.App_Panel.Name = "App_Panel"
        Me.App_Panel.Size = New System.Drawing.Size(427, 338)
        Me.App_Panel.TabIndex = 1
        Me.App_Panel.Visible = False
        '
        'btn_About
        '
        Me.btn_About.BackColor = System.Drawing.Color.RoyalBlue
        Me.btn_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_About.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_About.ForeColor = System.Drawing.Color.White
        Me.btn_About.Location = New System.Drawing.Point(367, 14)
        Me.btn_About.Name = "btn_About"
        Me.btn_About.Size = New System.Drawing.Size(57, 23)
        Me.btn_About.TabIndex = 2
        Me.btn_About.Text = "About"
        Me.btn_About.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Apps"
        '
        'AppList
        '
        Me.AppList.BackColor = System.Drawing.Color.DodgerBlue
        Me.AppList.HideSelection = False
        Me.AppList.LargeImageList = Me.AppIcons
        Me.AppList.Location = New System.Drawing.Point(3, 43)
        Me.AppList.Name = "AppList"
        Me.AppList.Size = New System.Drawing.Size(421, 292)
        Me.AppList.SmallImageList = Me.AppIcons
        Me.AppList.TabIndex = 0
        Me.AppList.UseCompatibleStateImageBehavior = False
        '
        'AppIcons
        '
        Me.AppIcons.ImageStream = CType(resources.GetObject("AppIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.AppIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.AppIcons.Images.SetKeyName(0, "file-exe-icon_34440.png")
        '
        'ClockTimer
        '
        '
        'SystemDesktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(990, 554)
        Me.Controls.Add(Me.App_Panel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "SystemDesktop"
        Me.Text = "LukeOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btn_Shutdown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.App_Panel.ResumeLayout(False)
        Me.App_Panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnApps As Button
    Friend WithEvents App_Panel As Panel
    Friend WithEvents lbl_Time As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AppList As ListView
    Friend WithEvents ClockTimer As Timer
    Friend WithEvents btn_About As Button
    Friend WithEvents btn_Shutdown As PictureBox
    Friend WithEvents AppIcons As ImageList
End Class
