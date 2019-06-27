<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScore
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScore))
        Me.grdLogin = New System.Windows.Forms.Panel
        Me.btnSubmit = New System.Windows.Forms.Button
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.lblPassword = New System.Windows.Forms.Label
        Me.lblUser = New System.Windows.Forms.Label
        Me.grdScoreBoard = New System.Windows.Forms.Panel
        Me.lblScore = New System.Windows.Forms.Label
        Me.lblEnd = New System.Windows.Forms.Label
        Me.lblStart = New System.Windows.Forms.Label
        Me.lblCollege = New System.Windows.Forms.Label
        Me.cmbName = New System.Windows.Forms.ComboBox
        Me.lblQuizScore = New System.Windows.Forms.Label
        Me.lblEndTime = New System.Windows.Forms.Label
        Me.lblStartTime = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.lblCollegeName = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.grdLogin.SuspendLayout()
        Me.grdScoreBoard.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdLogin
        '
        Me.grdLogin.BackColor = System.Drawing.Color.Orange
        Me.grdLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.grdLogin.Controls.Add(Me.btnSubmit)
        Me.grdLogin.Controls.Add(Me.txtPassword)
        Me.grdLogin.Controls.Add(Me.txtUserName)
        Me.grdLogin.Controls.Add(Me.lblPassword)
        Me.grdLogin.Controls.Add(Me.lblUser)
        Me.grdLogin.Location = New System.Drawing.Point(12, 12)
        Me.grdLogin.Name = "grdLogin"
        Me.grdLogin.Size = New System.Drawing.Size(368, 181)
        Me.grdLogin.TabIndex = 0
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(27, 131)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(314, 30)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "OK"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(120, 78)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(221, 20)
        Me.txtPassword.TabIndex = 5
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(120, 27)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(221, 20)
        Me.txtUserName.TabIndex = 4
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPassword.Location = New System.Drawing.Point(24, 78)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(80, 16)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Password:"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblUser.Location = New System.Drawing.Point(24, 28)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(90, 16)
        Me.lblUser.TabIndex = 2
        Me.lblUser.Text = "User Name:"
        '
        'grdScoreBoard
        '
        Me.grdScoreBoard.BackColor = System.Drawing.Color.Orange
        Me.grdScoreBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.grdScoreBoard.Controls.Add(Me.lblScore)
        Me.grdScoreBoard.Controls.Add(Me.lblEnd)
        Me.grdScoreBoard.Controls.Add(Me.lblStart)
        Me.grdScoreBoard.Controls.Add(Me.lblCollege)
        Me.grdScoreBoard.Controls.Add(Me.cmbName)
        Me.grdScoreBoard.Controls.Add(Me.lblQuizScore)
        Me.grdScoreBoard.Controls.Add(Me.lblEndTime)
        Me.grdScoreBoard.Controls.Add(Me.lblStartTime)
        Me.grdScoreBoard.Controls.Add(Me.btnClose)
        Me.grdScoreBoard.Controls.Add(Me.lblCollegeName)
        Me.grdScoreBoard.Controls.Add(Me.lblName)
        Me.grdScoreBoard.Location = New System.Drawing.Point(12, 12)
        Me.grdScoreBoard.Name = "grdScoreBoard"
        Me.grdScoreBoard.Size = New System.Drawing.Size(368, 181)
        Me.grdScoreBoard.TabIndex = 8
        Me.grdScoreBoard.Visible = False
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblScore.Location = New System.Drawing.Point(117, 122)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(0, 16)
        Me.lblScore.TabIndex = 14
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnd.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblEnd.Location = New System.Drawing.Point(117, 95)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(0, 16)
        Me.lblEnd.TabIndex = 13
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblStart.Location = New System.Drawing.Point(117, 71)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(0, 16)
        Me.lblStart.TabIndex = 12
        '
        'lblCollege
        '
        Me.lblCollege.AutoSize = True
        Me.lblCollege.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCollege.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCollege.Location = New System.Drawing.Point(117, 47)
        Me.lblCollege.Name = "lblCollege"
        Me.lblCollege.Size = New System.Drawing.Size(0, 16)
        Me.lblCollege.TabIndex = 11
        '
        'cmbName
        '
        Me.cmbName.FormattingEnabled = True
        Me.cmbName.Location = New System.Drawing.Point(120, 18)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.Size = New System.Drawing.Size(221, 21)
        Me.cmbName.TabIndex = 10
        '
        'lblQuizScore
        '
        Me.lblQuizScore.AutoSize = True
        Me.lblQuizScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuizScore.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblQuizScore.Location = New System.Drawing.Point(24, 119)
        Me.lblQuizScore.Name = "lblQuizScore"
        Me.lblQuizScore.Size = New System.Drawing.Size(53, 16)
        Me.lblQuizScore.TabIndex = 9
        Me.lblQuizScore.Text = "Score:"
        '
        'lblEndTime
        '
        Me.lblEndTime.AutoSize = True
        Me.lblEndTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndTime.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblEndTime.Location = New System.Drawing.Point(24, 95)
        Me.lblEndTime.Name = "lblEndTime"
        Me.lblEndTime.Size = New System.Drawing.Size(78, 16)
        Me.lblEndTime.TabIndex = 8
        Me.lblEndTime.Text = "End Time:"
        '
        'lblStartTime
        '
        Me.lblStartTime.AutoSize = True
        Me.lblStartTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartTime.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblStartTime.Location = New System.Drawing.Point(24, 71)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(83, 16)
        Me.lblStartTime.TabIndex = 7
        Me.lblStartTime.Text = "Start Time:"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(27, 144)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(314, 25)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblCollegeName
        '
        Me.lblCollegeName.AutoSize = True
        Me.lblCollegeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCollegeName.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCollegeName.Location = New System.Drawing.Point(24, 47)
        Me.lblCollegeName.Name = "lblCollegeName"
        Me.lblCollegeName.Size = New System.Drawing.Size(66, 16)
        Me.lblCollegeName.TabIndex = 3
        Me.lblCollegeName.Text = "College:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblName.Location = New System.Drawing.Point(24, 23)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(53, 16)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name:"
        '
        'frmScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(392, 205)
        Me.Controls.Add(Me.grdScoreBoard)
        Me.Controls.Add(Me.grdLogin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmScore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Score Board"
        Me.grdLogin.ResumeLayout(False)
        Me.grdLogin.PerformLayout()
        Me.grdScoreBoard.ResumeLayout(False)
        Me.grdScoreBoard.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdLogin As System.Windows.Forms.Panel
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents grdScoreBoard As System.Windows.Forms.Panel
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblEnd As System.Windows.Forms.Label
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents lblCollege As System.Windows.Forms.Label
    Friend WithEvents cmbName As System.Windows.Forms.ComboBox
    Friend WithEvents lblQuizScore As System.Windows.Forms.Label
    Friend WithEvents lblEndTime As System.Windows.Forms.Label
    Friend WithEvents lblStartTime As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblCollegeName As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
End Class
