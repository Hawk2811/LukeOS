Imports System.IO

Public Class About
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim rootfs As String = My.Computer.FileSystem.GetParentPath(Application.StartupPath)
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim readVersion As String = File.ReadAllText(rootfs + "\System\Config\sysversion.conf")
        Label2.Text = "Version: " + readVersion
    End Sub
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

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
    End Sub
End Class