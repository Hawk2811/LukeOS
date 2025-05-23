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

            For ie = 0 To My.Computer.FileSystem.GetDirectories(Application_dir).Count - 1 'List All Folders on LukeOS Applications Folder
                AppList.Items.Add(My.Computer.FileSystem.GetName(My.Computer.FileSystem.GetDirectories(Application_dir)(ie)), 0)
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
            Process.Start(Application_dir + "\" + AppList.SelectedItems(0).Text + "\" + AppList.SelectedItems(0).Text + ".exe") 'Try Start Executable inside of Folder 
        Catch ex As Exception
            MessageBox.Show("Failed to Start App: Is not valid LukeOS Application", "System Error") ' If fail show a error Message
        End Try
    End Sub
End Class
