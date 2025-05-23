'
' LukeOS BootManager
' Program to Start LukeOS Correctly
'

Public Class BootManager

    Dim TimerTick As Integer = 0 ' Variable to count seconds of Timer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDrivers()

    End Sub

    Public Sub LoadDrivers() 'Fucntion to load drivers
        Try
            For Each DriverFiles As String In My.Computer.FileSystem.GetFiles(Application.StartupPath + "\Drivers") 'Find Drivers do Load
                Process.Start(DriverFiles) 'Load All Drivers
            Next
            lbl_Drivers.Visible = True
            BootTimer.Start() 'Start Wait Time
        Catch ex As Exception
            lbl_Drivers.Text = "Failed to Start Drivers: " + ex.Message
            lbl_Drivers.Visible = True
        End Try


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles BootTimer.Tick
        TimerTick = TimerTick + 1 'Add 1 second to timer variable
        If TimerTick = 3 Then 'If timer equals 3 show driver Loaded message
            lbl_ReadyOrError.Visible = True
        ElseIf TimerTick = 5 Then 'If equals 5 start load desktop process
            BootTimer.Stop()
            Try 'Try Start Desktop
                Process.Start(My.Computer.FileSystem.GetParentPath(Application.StartupPath) + "\SystemDesktop.exe")
                Application.Exit()
            Catch ex As Exception ' If Failed show a message
                lbl_ReadyOrError.Text = "Error Initializing the Interface: " + ex.Message
            End Try
        End If
    End Sub
End Class
