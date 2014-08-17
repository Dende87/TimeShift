Public Class frmShutdownCancel

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            frmTimeShift.CancelShutdown()
            Timer1.Stop()
            Me.Close()
        Catch ex As Exception
            clsErrorHandler.ErrorMessage(ex.ToString)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If Not ProgressBar1.Value = 0 Then
                ProgressBar1.Value = ProgressBar1.Value - 1
                lblTimer.Text = ProgressBar1.Value.ToString
            Else
                Timer1.Stop()
            End If
        Catch ex As Exception
            clsErrorHandler.ErrorMessage(ex.ToString)
        End Try
    End Sub

    Private Sub frmShutdownCancel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class