Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Main
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim appfolder As String = My.Computer.FileSystem.GetParentPath(Application.StartupPath)
    Dim rootfs As String = My.Computer.FileSystem.GetParentPath(appfolder)
    Dim errors As String
    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub UpR_MouseMove(sender As Object, e As MouseEventArgs) Handles UpR.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(Me.Size.Width, Me.Size.Height + (Me.Location.Y - MousePosition.Y))
            Me.Location = New Point(Me.Location.X, MousePosition.Y)
        End If
    End Sub

    Private Sub RightR_MouseMove(sender As Object, e As MouseEventArgs) Handles RightR.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(MousePosition.X - Me.Location.X, Me.Size.Height)
        End If
    End Sub

    Private Sub LeftR_MouseMove(sender As Object, e As MouseEventArgs) Handles LeftR.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(Me.Size.Width + (Me.Location.X - MousePosition.X), Me.Size.Height)
            Me.Location = New Point(MousePosition.X, Me.Location.Y)
        End If
    End Sub

    Private Sub DownR_MouseMove(sender As Object, e As MouseEventArgs) Handles DownR.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(Me.Size.Width, MousePosition.Y - Me.Location.Y)
        End If
    End Sub

    Private Sub Main_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        DownR.Location = New Point(0, Me.Size.Height - 2)
        RightR.Location = New Point(Me.Size.Width - 2, 0)
        UpR.Size = New Size(Me.Size.Width, 2)
        DownR.Size = New Size(Me.Size.Width, 2)
        LeftR.Size = New Size(2, Me.Size.Height)
        RightR.Size = New Size(2, Me.Size.Height)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Application.Exit()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dirURL.Text = rootfs
        Loadfiles()
        LoadDisks()
    End Sub

    Public Sub Loadfiles()
        Try
            FileView.Clear()
            For directory = 0 To My.Computer.FileSystem.GetDirectories(dirURL.Text).Count - 1
                FileView.Items.Add(My.Computer.FileSystem.GetName(My.Computer.FileSystem.GetDirectories(dirURL.Text)(directory)), 1)

            Next
            For file = 0 To My.Computer.FileSystem.GetFiles(dirURL.Text).Count - 1
                FileView.Items.Add(My.Computer.FileSystem.GetName(My.Computer.FileSystem.GetFiles(dirURL.Text)(file)), 0)
            Next
        Catch ex As Exception
            errors = errors + vbNewLine + ex.Message
            My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath + "\APP.log", errors, False)
        End Try
    End Sub
    Public Sub LoadDisks()
        Try
            DiskView.Items.Clear()
            DiskView.Items.Add("Root Filesystem", 2)
            For disk = 0 To My.Computer.FileSystem.Drives.Count - 1
                If My.Computer.FileSystem.Drives.Item(disk).IsReady Then
                    DiskView.Items.Add(My.Computer.FileSystem.Drives.Item(disk).ToString, 2)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Failed to load disks: " + ex.Message, "File Manager")
        End Try

    End Sub

    Private Sub DiskView_DoubleClick(sender As Object, e As EventArgs) Handles DiskView.DoubleClick
        If DiskView.SelectedItems(0).Text.ToString = "Root Filesystem" Then
            dirURL.Text = rootfs
            Loadfiles()
        Else
            dirURL.Text = DiskView.SelectedItems(0).Text.ToString
            Loadfiles()
        End If
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Loadfiles()
    End Sub

    Private Sub FileView_DoubleClick(sender As Object, e As EventArgs) Handles FileView.DoubleClick
        Try
            If IO.Directory.Exists(dirURL.Text + "\" + FileView.SelectedItems(0).Text) = True Then
                dirURL.Text = dirURL.Text + "\" + FileView.SelectedItems(0).Text
                FileView.Items.Clear()
                For directory = 0 To My.Computer.FileSystem.GetDirectories(dirURL.Text).Count - 1
                    FileView.Items.Add(My.Computer.FileSystem.GetName(My.Computer.FileSystem.GetDirectories(dirURL.Text)(directory)), 1)
                Next

                For file = 0 To My.Computer.FileSystem.GetFiles(dirURL.Text).Count - 1
                    FileView.Items.Add(My.Computer.FileSystem.GetName(My.Computer.FileSystem.GetFiles(dirURL.Text)(file)), 0)
                Next
            End If

            If IO.File.Exists(dirURL.Text + "\" + FileView.SelectedItems(0).Text) Then

            End If
        Catch ex As Exception
            errors = errors + vbNewLine + ex.Message
            My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath + "\APP.log", errors, False)
        End Try
    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        Try
            If IO.Directory.Exists(My.Computer.FileSystem.GetParentPath(dirURL.Text)) = True Then

                dirURL.Text = My.Computer.FileSystem.GetParentPath(dirURL.Text)
                FileView.Items.Clear()
                For directory = 0 To My.Computer.FileSystem.GetDirectories(dirURL.Text).Count - 1
                    FileView.Items.Add(My.Computer.FileSystem.GetName(My.Computer.FileSystem.GetDirectories(dirURL.Text)(directory)), 1)
                Next

                For file = 0 To My.Computer.FileSystem.GetFiles(dirURL.Text).Count - 1
                    FileView.Items.Add(My.Computer.FileSystem.GetName(My.Computer.FileSystem.GetFiles(dirURL.Text)(file)), 0)
                Next
            End If
        Catch ex As Exception
            errors = errors + vbNewLine + ex.Message
            My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath + "\APP.log", errors, False)
        End Try
    End Sub
End Class
