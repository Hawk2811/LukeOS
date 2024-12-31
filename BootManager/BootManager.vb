Public Class BootManager

    Dim TimerTick As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDrivers()

    End Sub

    Public Sub LoadDrivers()
        Try
            For Each DriverFiles As String In My.Computer.FileSystem.GetFiles(Application.StartupPath + "\Drivers")
                Process.Start(DriverFiles)
            Next
            Label2.Visible = True
            Timer1.Start()
        Catch ex As Exception
            Label2.Text = "Failed to Start Drivers: " + ex.Message
            Label2.Visible = True
        End Try


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimerTick = TimerTick + 1
        If TimerTick = 3 Then
            Label3.Visible = True
        ElseIf TimerTick = 5 Then
            Timer1.Stop()
            Try
                Process.Start(My.Computer.FileSystem.GetParentPath(Application.StartupPath) + "\SystemDesktop.exe")
                Application.Exit()
            Catch ex As Exception
                Label3.Text = "Error Initializing the Interface: " + ex.Message
            End Try
        End If
    End Sub
End Class
