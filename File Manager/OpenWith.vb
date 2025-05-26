Public Class OpenWith
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Public File As String
    Public rootfs As String

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        If SaveCheck.Checked = True Then
            Dim Ext As String = IO.Path.GetExtension(File)
            My.Computer.FileSystem.WriteAllText(rootfs + "\System\Config\Ext\" + Ext, AppURL.Text, True)
            Process.Start(AppURL.Text, File)
            AppURL.Text = ""
            SaveCheck.Checked = False
            Me.Close()
        Else
            Process.Start(AppURL.Text, File)
            AppURL.Text = ""
            Me.Close()
        End If
    End Sub
End Class