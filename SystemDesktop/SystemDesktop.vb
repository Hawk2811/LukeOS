Public Class SystemDesktop
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Panel2.Visible = True Then
            Panel2.Visible = False
        Else
            Panel2.Visible = True
        End If
    End Sub
End Class
