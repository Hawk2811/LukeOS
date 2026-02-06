'
' LukeOS SystemDesktop
' Desktop of LukeOS
'
Imports System.DateTime
Imports System.IO


Public Class SystemDesktop

    Dim rootfs As String = My.Computer.FileSystem.GetParentPath(Application.StartupPath) 'Set variable to Root FileSystem of LukeOS
    Dim Application_dir As String = rootfs + "\Apps" ' Set variable to Application Directory of LukeOS

    Private Sub BtnApps_Click(sender As Object, e As EventArgs) Handles btnApps.Click
        If App_Panel.Visible = True Then 'Show and Hide Application Menu
            App_Panel.Visible = False
        Else
            App_Panel.Visible = True
        End If
    End Sub

    Private Sub SystemDesktop_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadApps()
        ClockTimer.Start()
    End Sub

    Private Sub ClockTimer_Tick(sender As Object, e As EventArgs) Handles ClockTimer.Tick
        lbl_Time.Text = Now.ToString("HH:mm") 'Set Time using Windows Time
    End Sub

    Private Sub AppList_Timer_Tick(sender As Object, e As EventArgs) Handles AppList_Timer.Tick
        LoadApps()
    End Sub

    Public Sub LoadApps()
        Try
            AppList.Items.Clear()
            AppIcons.Images.Clear()
            AppIcons.ImageSize = New Point(64, 64)
            For ie = 0 To My.Computer.FileSystem.GetDirectories(Application_dir).Count - 1 'List All Folders on LukeOS Applications Folder
                Try
                    AppIcons.Images.Add(Image.FromFile(Application_dir + "\" + My.Computer.FileSystem.GetName(My.Computer.FileSystem.GetDirectories(Application_dir)(ie)) + "\app_icon.png"))
                Catch ex As Exception
                    AppIcons.Images.Add(Image.FromFile(rootfs + "\System\Icons\executable.png"))
                End Try
                AppList.Items.Add(My.Computer.FileSystem.GetName(My.Computer.FileSystem.GetDirectories(Application_dir)(ie)), AppIcons.Images.Count - 1)
            Next
        Catch ex As Exception ' If get a error show a Error Message
            MessageBox.Show("Failed to Load Apps " + ex.Message, "System Error") 'Show a message error if fail
        End Try
    End Sub

    Private Sub btn_About_Click(sender As Object, e As EventArgs) Handles btn_About.Click
        About.Show()
    End Sub

    Private Sub btn_Shutdown_Click(sender As Object, e As EventArgs) Handles btn_Shutdown.Click
        Application.Exit()
    End Sub

    Private Sub AppList_DoubleClick(sender As Object, e As EventArgs) Handles AppList.DoubleClick
        Try
            'Try Start Executable inside of Folder 
            If File.Exists(Application_dir + "\" + AppList.SelectedItems(0).Text + "\" + AppList.SelectedItems(0).Text + ".exe") Then
                Process.Start(Application_dir + "\" + AppList.SelectedItems(0).Text + "\" + AppList.SelectedItems(0).Text + ".exe")
            ElseIf File.Exists(Application_dir + "\" + AppList.SelectedItems(0).Text + "\" + AppList.SelectedItems(0).Text + ".bat") Then
                Process.Start(Application_dir + "\" + AppList.SelectedItems(0).Text + "\" + AppList.SelectedItems(0).Text + ".bat")
            ElseIf File.Exists(Application_dir + "\" + AppList.SelectedItems(0).Text + "\" + AppList.SelectedItems(0).Text + ".cmd") Then
                Process.Start(Application_dir + "\" + AppList.SelectedItems(0).Text + "\" + AppList.SelectedItems(0).Text + ".cmd")
            Else
                MessageBox.Show("Failed to Start App: Is not valid LukeOS Application", "System Error") ' If fail show a error Message
            End If
        Catch ex As Exception 'If Cause unknown error
            MessageBox.Show("Failed to Start App: " + ex.Message, "System Error")
        End Try
    End Sub
End Class
