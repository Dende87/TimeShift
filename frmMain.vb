Imports System.Runtime.InteropServices

Public Class frmTimeShift

    Private mobjTimeSpan As TimeSpan
    Private mobjTimeSpanLastSeconds As New TimeSpan(0, 0, 30)
    Private mobjTimeSpanIncrement As New TimeSpan(0, 0, 1)
    Private mobjTimeSpanDay As New TimeSpan(24, 0, 0)
    Private mblnfrmShutdownCancel As Boolean = False

    Private Sub clsTimeShift_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            btnStartShutdown.Enabled = False
            btnCancel.Enabled = False

        Catch ex As Exception
            clsErrorHandler.ErrorMessage(ex.ToString)
        End Try
    End Sub

    Private Sub btnStartShutdown_Click(sender As Object, e As EventArgs) Handles btnStartShutdown.Click
        Try

      ' Testing :)


            pnlTimeSet.Enabled = False
            pnlDayTimeSet.Enabled = False
            btnStartShutdown.Enabled = False

            Dim intHours As Int32
            Dim intMinutes As Int32
            Dim intSeconds As Int32

            intHours = CInt(mobjTimeSpan.Hours)
            intHours = (intHours * 60) * 60

            intMinutes = CInt(mobjTimeSpan.Minutes)
            intMinutes = intMinutes * 60

            intSeconds = CInt(mobjTimeSpan.Seconds)
            intSeconds += intHours + intMinutes

            Dim strArgument As String = "/s -t " & intSeconds.ToString

            System.Diagnostics.Process.Start("Shutdown", strArgument)

            Timer1.Start()

        Catch ex As Exception
            clsErrorHandler.ErrorMessage(ex.ToString)
        End Try
    End Sub

    Private Sub btnSetTime_Click(sender As Object, e As EventArgs) Handles btnSetTime.Click
        Try

            Dim objTimeSpan As New TimeSpan(CInt(numHours.Value), CInt(numMinutes.Value), CInt(numSeconds.Value))
            mobjTimeSpan = objTimeSpan

            lblCountdown.Text = mobjTimeSpan.ToString

            btnStartShutdown.Enabled = True
            btnCancel.Enabled = True

        Catch ex As Exception
            clsErrorHandler.ErrorMessage(ex.ToString)
        End Try
    End Sub

    Private Sub cmdSetDayTime_Click(sender As Object, e As EventArgs) Handles cmdSetDayTime.Click
        Try

            Dim objTimeSpanSet As New TimeSpan(CInt(numHoursDayTime.Value), CInt(numMinutesDayTime.Value), 0)
            Dim objTimeSpanNow As New TimeSpan(Date.Now.Hour, Date.Now.Minute, 0)

            objTimeSpanSet = mobjTimeSpanDay - objTimeSpanNow + objTimeSpanSet
            If objTimeSpanSet > mobjTimeSpanDay Then
                objTimeSpanSet -= mobjTimeSpanDay
            End If

            mobjTimeSpan = objTimeSpanSet

            lblCountdown.Text = mobjTimeSpan.ToString

            btnStartShutdown.Enabled = True
            btnCancel.Enabled = True

        Catch ex As Exception
            clsErrorHandler.ErrorMessage(ex.ToString)
        End Try
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Try

            Me.Show()
            Me.ShowInTaskbar = True

        Catch ex As Exception
            clsErrorHandler.ErrorMessage(ex.ToString)
        End Try
    End Sub

    Private Sub mnuOpenApplication_Click(sender As Object, e As EventArgs) Handles mnuOpenApplication.Click
        Try

            Me.Show()
            Me.ShowInTaskbar = True

        Catch ex As Exception
            clsErrorHandler.ErrorMessage(ex.ToString)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try

            CancelShutdown()

        Catch ex As Exception
            clsErrorHandler.ErrorMessage(ex.ToString)
        End Try
    End Sub

    Public Sub CancelShutdown()
        System.Diagnostics.Process.Start("Shutdown", "/a")

        Timer1.Stop()
        Timer1.Dispose()

        pnlTimeSet.Enabled = True
        pnlDayTimeSet.Enabled = True
        btnCancel.Enabled = False

        NotifyIcon1.Text = "TimeShift"

        mblnfrmShutdownCancel = False
    End Sub

    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click, BeendenToolStripMenuItem.Click
        Try

            System.Diagnostics.Process.Start("Shutdown", "/a")
            Timer1.Dispose()
            Me.Dispose()
            Application.Exit()

        Catch ex As Exception
            clsErrorHandler.ErrorMessage(ex.ToString)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Try

            Me.ShowInTaskbar = False
            Me.Close()

        Catch ex As Exception
            clsErrorHandler.ErrorMessage(ex.ToString)
        End Try
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try

            If e.CloseReason = CloseReason.UserClosing Then

                e.Cancel = True
                Me.Visible = False
                Me.NotifyIcon1.Visible = True

                NotifyIcon1.ShowBalloonTip(500, "TimeShift", "Programm läuft im Hintergrund weiter.", ToolTipIcon.Info)

            End If

        Catch ex As Exception
            clsErrorHandler.ErrorMessage(ex.ToString)
        End Try
    End Sub

    ''' <summary>
    ''' Timer
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            mobjTimeSpan = mobjTimeSpan - mobjTimeSpanIncrement

            If mobjTimeSpan <= mobjTimeSpanLastSeconds Then
                If mblnfrmShutdownCancel = False Then
                    frmShutdownCancel.Show(Me)
                    mblnfrmShutdownCancel = True
                End If
            End If

            lblCountdown.Text = mobjTimeSpan.ToString

            NotifyIcon1.Text = mobjTimeSpan.ToString
        Catch ex As Exception
            clsErrorHandler.ErrorMessage(ex.ToString)
        End Try
    End Sub

#Region "Fenster verschieben"

    Private Sub clsTimeShift_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            DragMove()
        End If
    End Sub

    Public Const HTCAPTION As Integer = 2
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1

    <Security.Permissions.SecurityPermission(Security.Permissions.SecurityAction.Demand, Flags:=Security.Permissions.SecurityPermissionFlag.UnmanagedCode)> Public Sub DragMove()
        ReleaseCapture()
        SendMessage(New System.Runtime.InteropServices.HandleRef(Me, MyBase.Handle), WM_NCLBUTTONDOWN, HTCAPTION, 0)
    End Sub

    Private Declare Auto Function SendMessage Lib "user32" (ByVal hWnd As HandleRef, ByVal msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As IntPtr
    Private Declare Auto Function ReleaseCapture Lib "user32" () As Integer

#End Region

    'Test für GitHub

End Class
