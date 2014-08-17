<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimeShift
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTimeShift))
        Me.btnStartShutdown = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.numHours = New System.Windows.Forms.NumericUpDown()
        Me.numMinutes = New System.Windows.Forms.NumericUpDown()
        Me.numSeconds = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCountdown = New System.Windows.Forms.Label()
        Me.btnSetTime = New System.Windows.Forms.Button()
        Me.pnlTimeSet = New System.Windows.Forms.Panel()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuOpenApplication = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlDayTimeSet = New System.Windows.Forms.Panel()
        Me.cmdSetDayTime = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.numMinutesDayTime = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.numHoursDayTime = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.numHours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSeconds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTimeSet.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnlDayTimeSet.SuspendLayout()
        CType(Me.numMinutesDayTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numHoursDayTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStartShutdown
        '
        Me.btnStartShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStartShutdown.Location = New System.Drawing.Point(8, 68)
        Me.btnStartShutdown.Name = "btnStartShutdown"
        Me.btnStartShutdown.Size = New System.Drawing.Size(75, 23)
        Me.btnStartShutdown.TabIndex = 0
        Me.btnStartShutdown.Text = "Start"
        Me.btnStartShutdown.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Location = New System.Drawing.Point(89, 68)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'numHours
        '
        Me.numHours.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numHours.Location = New System.Drawing.Point(9, 17)
        Me.numHours.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.numHours.Name = "numHours"
        Me.numHours.Size = New System.Drawing.Size(44, 16)
        Me.numHours.TabIndex = 2
        Me.numHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numMinutes
        '
        Me.numMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numMinutes.Location = New System.Drawing.Point(9, 37)
        Me.numMinutes.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.numMinutes.Name = "numMinutes"
        Me.numMinutes.Size = New System.Drawing.Size(44, 16)
        Me.numMinutes.TabIndex = 2
        Me.numMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'numSeconds
        '
        Me.numSeconds.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numSeconds.Location = New System.Drawing.Point(9, 57)
        Me.numSeconds.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.numSeconds.Name = "numSeconds"
        Me.numSeconds.Size = New System.Drawing.Size(44, 16)
        Me.numSeconds.TabIndex = 2
        Me.numSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "h"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "min"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "sec"
        '
        'lblCountdown
        '
        Me.lblCountdown.BackColor = System.Drawing.Color.White
        Me.lblCountdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountdown.Location = New System.Drawing.Point(5, 10)
        Me.lblCountdown.Name = "lblCountdown"
        Me.lblCountdown.Size = New System.Drawing.Size(159, 51)
        Me.lblCountdown.TabIndex = 3
        Me.lblCountdown.Text = "00:00:00"
        Me.lblCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSetTime
        '
        Me.btnSetTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetTime.Location = New System.Drawing.Point(8, 79)
        Me.btnSetTime.Name = "btnSetTime"
        Me.btnSetTime.Size = New System.Drawing.Size(70, 23)
        Me.btnSetTime.TabIndex = 4
        Me.btnSetTime.Text = "Set Time"
        Me.btnSetTime.UseVisualStyleBackColor = True
        '
        'pnlTimeSet
        '
        Me.pnlTimeSet.Controls.Add(Me.btnSetTime)
        Me.pnlTimeSet.Controls.Add(Me.Label7)
        Me.pnlTimeSet.Controls.Add(Me.Label3)
        Me.pnlTimeSet.Controls.Add(Me.Label2)
        Me.pnlTimeSet.Controls.Add(Me.Label1)
        Me.pnlTimeSet.Controls.Add(Me.numSeconds)
        Me.pnlTimeSet.Controls.Add(Me.numMinutes)
        Me.pnlTimeSet.Controls.Add(Me.numHours)
        Me.pnlTimeSet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTimeSet.Location = New System.Drawing.Point(3, 3)
        Me.pnlTimeSet.Name = "pnlTimeSet"
        Me.pnlTimeSet.Size = New System.Drawing.Size(88, 104)
        Me.pnlTimeSet.TabIndex = 5
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "TimeShift"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpenApplication, Me.ToolStripSeparator1, Me.mnuClose})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(133, 54)
        '
        'mnuOpenApplication
        '
        Me.mnuOpenApplication.Name = "mnuOpenApplication"
        Me.mnuOpenApplication.ShortcutKeyDisplayString = ""
        Me.mnuOpenApplication.Size = New System.Drawing.Size(132, 22)
        Me.mnuOpenApplication.Text = "Open TimeShift"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(129, 6)
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(132, 22)
        Me.mnuClose.Text = "Beenden"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(2, 2)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(58, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeendenToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(351, -2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(19, 21)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.MenuStrip1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(74, 1)
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(-5, -1)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(74, 26)
        Me.ToolStripContainer1.TabIndex = 8
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblCountdown)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnStartShutdown)
        Me.Panel1.Location = New System.Drawing.Point(195, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(169, 93)
        Me.Panel1.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Daytime"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.26738!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.73262!))
        Me.TableLayoutPanel1.Controls.Add(Me.pnlTimeSet, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pnlDayTimeSet, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 32)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(187, 110)
        Me.TableLayoutPanel1.TabIndex = 13
        '
        'pnlDayTimeSet
        '
        Me.pnlDayTimeSet.Controls.Add(Me.cmdSetDayTime)
        Me.pnlDayTimeSet.Controls.Add(Me.Label4)
        Me.pnlDayTimeSet.Controls.Add(Me.Label6)
        Me.pnlDayTimeSet.Controls.Add(Me.numMinutesDayTime)
        Me.pnlDayTimeSet.Controls.Add(Me.Label5)
        Me.pnlDayTimeSet.Controls.Add(Me.numHoursDayTime)
        Me.pnlDayTimeSet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDayTimeSet.Location = New System.Drawing.Point(97, 3)
        Me.pnlDayTimeSet.Name = "pnlDayTimeSet"
        Me.pnlDayTimeSet.Size = New System.Drawing.Size(87, 104)
        Me.pnlDayTimeSet.TabIndex = 6
        '
        'cmdSetDayTime
        '
        Me.cmdSetDayTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSetDayTime.Location = New System.Drawing.Point(7, 78)
        Me.cmdSetDayTime.Name = "cmdSetDayTime"
        Me.cmdSetDayTime.Size = New System.Drawing.Size(70, 23)
        Me.cmdSetDayTime.TabIndex = 4
        Me.cmdSetDayTime.Text = "Set Time"
        Me.cmdSetDayTime.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "min"
        '
        'numMinutesDayTime
        '
        Me.numMinutesDayTime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numMinutesDayTime.Location = New System.Drawing.Point(10, 45)
        Me.numMinutesDayTime.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.numMinutesDayTime.Name = "numMinutesDayTime"
        Me.numMinutesDayTime.Size = New System.Drawing.Size(44, 16)
        Me.numMinutesDayTime.TabIndex = 2
        Me.numMinutesDayTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "h"
        '
        'numHoursDayTime
        '
        Me.numHoursDayTime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.numHoursDayTime.Location = New System.Drawing.Point(10, 25)
        Me.numHoursDayTime.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.numHoursDayTime.Name = "numHoursDayTime"
        Me.numHoursDayTime.Size = New System.Drawing.Size(44, 16)
        Me.numHoursDayTime.TabIndex = 2
        Me.numHoursDayTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 1)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Time"
        '
        'frmTimeShift
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(368, 154)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTimeShift"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TimeShift"
        CType(Me.numHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMinutes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSeconds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTimeSet.ResumeLayout(False)
        Me.pnlTimeSet.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.pnlDayTimeSet.ResumeLayout(False)
        Me.pnlDayTimeSet.PerformLayout()
        CType(Me.numMinutesDayTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numHoursDayTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStartShutdown As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents numHours As System.Windows.Forms.NumericUpDown
    Friend WithEvents numMinutes As System.Windows.Forms.NumericUpDown
    Friend WithEvents numSeconds As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCountdown As System.Windows.Forms.Label
    Friend WithEvents btnSetTime As System.Windows.Forms.Button
    Friend WithEvents pnlTimeSet As System.Windows.Forms.Panel
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOpenApplication As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlDayTimeSet As System.Windows.Forms.Panel
    Friend WithEvents cmdSetDayTime As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents numMinutesDayTime As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents numHoursDayTime As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
