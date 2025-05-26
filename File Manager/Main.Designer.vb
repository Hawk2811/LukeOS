<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.UpR = New System.Windows.Forms.Panel()
        Me.DownR = New System.Windows.Forms.Panel()
        Me.LeftR = New System.Windows.Forms.Panel()
        Me.RightR = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dirURL = New System.Windows.Forms.TextBox()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.FileView = New System.Windows.Forms.ListView()
        Me.FileOperation = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenWithToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.DiskView = New System.Windows.Forms.ListView()
        Me.ObjName = New System.Windows.Forms.TextBox()
        Me.OpSrc = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.FileOperation.SuspendLayout()
        Me.SuspendLayout()
        '
        'UpR
        '
        Me.UpR.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.UpR.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.UpR.Dock = System.Windows.Forms.DockStyle.Top
        Me.UpR.Location = New System.Drawing.Point(0, 0)
        Me.UpR.Name = "UpR"
        Me.UpR.Size = New System.Drawing.Size(837, 10)
        Me.UpR.TabIndex = 1
        '
        'DownR
        '
        Me.DownR.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.DownR.Cursor = System.Windows.Forms.Cursors.SizeNS
        Me.DownR.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DownR.Location = New System.Drawing.Point(0, 541)
        Me.DownR.Name = "DownR"
        Me.DownR.Size = New System.Drawing.Size(837, 10)
        Me.DownR.TabIndex = 2
        '
        'LeftR
        '
        Me.LeftR.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.LeftR.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.LeftR.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftR.Location = New System.Drawing.Point(0, 10)
        Me.LeftR.Name = "LeftR"
        Me.LeftR.Size = New System.Drawing.Size(10, 531)
        Me.LeftR.TabIndex = 3
        '
        'RightR
        '
        Me.RightR.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.RightR.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.RightR.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightR.Location = New System.Drawing.Point(827, 10)
        Me.RightR.Name = "RightR"
        Me.RightR.Size = New System.Drawing.Size(10, 531)
        Me.RightR.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(10, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(817, 39)
        Me.Panel1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(28, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "-"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(768, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "[   ]"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "X"
        '
        'dirURL
        '
        Me.dirURL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dirURL.Location = New System.Drawing.Point(94, 55)
        Me.dirURL.Name = "dirURL"
        Me.dirURL.Size = New System.Drawing.Size(525, 20)
        Me.dirURL.TabIndex = 6
        '
        'btnUp
        '
        Me.btnUp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUp.Location = New System.Drawing.Point(13, 53)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(75, 23)
        Me.btnUp.TabIndex = 7
        Me.btnUp.Text = "Up"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.Location = New System.Drawing.Point(625, 53)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 8
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'FileView
        '
        Me.FileView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FileView.ContextMenuStrip = Me.FileOperation
        Me.FileView.HideSelection = False
        Me.FileView.LargeImageList = Me.ImageList1
        Me.FileView.Location = New System.Drawing.Point(180, 81)
        Me.FileView.Name = "FileView"
        Me.FileView.Size = New System.Drawing.Size(633, 454)
        Me.FileView.SmallImageList = Me.ImageList1
        Me.FileView.TabIndex = 9
        Me.FileView.UseCompatibleStateImageBehavior = False
        '
        'FileOperation
        '
        Me.FileOperation.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.OpenWithToolStripMenuItem, Me.UpToolStripMenuItem, Me.ToolStripSeparator1, Me.CopyToolStripMenuItem, Me.CutToolStripMenuItem, Me.PasteToolStripMenuItem, Me.ToolStripSeparator2, Me.DeleteToolStripMenuItem})
        Me.FileOperation.Name = "FileOperation"
        Me.FileOperation.Size = New System.Drawing.Size(132, 170)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'OpenWithToolStripMenuItem
        '
        Me.OpenWithToolStripMenuItem.Name = "OpenWithToolStripMenuItem"
        Me.OpenWithToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.OpenWithToolStripMenuItem.Text = "Open With"
        '
        'UpToolStripMenuItem
        '
        Me.UpToolStripMenuItem.Name = "UpToolStripMenuItem"
        Me.UpToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.UpToolStripMenuItem.Text = "Up"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(128, 6)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(128, 6)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "textxgeneric_92794.png")
        Me.ImageList1.Images.SetKeyName(1, "folderblue_92960.png")
        Me.ImageList1.Images.SetKeyName(2, "hd_disk_harddisk_162.png")
        '
        'DiskView
        '
        Me.DiskView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DiskView.HideSelection = False
        Me.DiskView.LargeImageList = Me.ImageList1
        Me.DiskView.Location = New System.Drawing.Point(21, 82)
        Me.DiskView.Name = "DiskView"
        Me.DiskView.Size = New System.Drawing.Size(153, 453)
        Me.DiskView.SmallImageList = Me.ImageList1
        Me.DiskView.TabIndex = 10
        Me.DiskView.UseCompatibleStateImageBehavior = False
        '
        'ObjName
        '
        Me.ObjName.Location = New System.Drawing.Point(706, 56)
        Me.ObjName.Name = "ObjName"
        Me.ObjName.Size = New System.Drawing.Size(27, 20)
        Me.ObjName.TabIndex = 11
        Me.ObjName.Visible = False
        '
        'OpSrc
        '
        Me.OpSrc.Location = New System.Drawing.Point(734, 56)
        Me.OpSrc.Name = "OpSrc"
        Me.OpSrc.Size = New System.Drawing.Size(27, 20)
        Me.OpSrc.TabIndex = 12
        Me.OpSrc.Visible = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 551)
        Me.Controls.Add(Me.OpSrc)
        Me.Controls.Add(Me.ObjName)
        Me.Controls.Add(Me.DiskView)
        Me.Controls.Add(Me.FileView)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.dirURL)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RightR)
        Me.Controls.Add(Me.LeftR)
        Me.Controls.Add(Me.DownR)
        Me.Controls.Add(Me.UpR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "File Manager"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FileOperation.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UpR As Panel
    Friend WithEvents DownR As Panel
    Friend WithEvents LeftR As Panel
    Friend WithEvents RightR As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dirURL As TextBox
    Friend WithEvents btnUp As Button
    Friend WithEvents btnGo As Button
    Friend WithEvents FileView As ListView
    Friend WithEvents DiskView As ListView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents FileOperation As ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenWithToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ObjName As TextBox
    Friend WithEvents OpSrc As TextBox
End Class
