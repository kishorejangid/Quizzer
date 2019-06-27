<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.pMain = New System.Windows.Forms.Panel
        Me.btnScore = New System.Windows.Forms.Button
        Me.lblQuiz = New System.Windows.Forms.Label
        Me.gpMain = New System.Windows.Forms.GroupBox
        Me.btnSubmit = New System.Windows.Forms.Button
        Me.txtPlace = New System.Windows.Forms.TextBox
        Me.txtCollege = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.lblPlace = New System.Windows.Forms.Label
        Me.lblCollegeName = New System.Windows.Forms.Label
        Me.lblName = New System.Windows.Forms.Label
        Me.lblEvent = New System.Windows.Forms.Label
        Me.lblDept = New System.Windows.Forms.Label
        Me.lblCollege = New System.Windows.Forms.Label
        Me.pMain.SuspendLayout()
        Me.gpMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'pMain
        '
        Me.pMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pMain.BackColor = System.Drawing.Color.Orange
        Me.pMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pMain.Controls.Add(Me.btnScore)
        Me.pMain.Controls.Add(Me.lblQuiz)
        Me.pMain.Controls.Add(Me.gpMain)
        Me.pMain.Controls.Add(Me.lblEvent)
        Me.pMain.Controls.Add(Me.lblDept)
        Me.pMain.Controls.Add(Me.lblCollege)
        Me.pMain.Location = New System.Drawing.Point(12, 12)
        Me.pMain.Name = "pMain"
        Me.pMain.Size = New System.Drawing.Size(779, 399)
        Me.pMain.TabIndex = 0
        '
        'btnScore
        '
        Me.btnScore.Location = New System.Drawing.Point(724, 370)
        Me.btnScore.Name = "btnScore"
        Me.btnScore.Size = New System.Drawing.Size(49, 23)
        Me.btnScore.TabIndex = 5
        Me.btnScore.Text = "Score"
        Me.btnScore.UseVisualStyleBackColor = True
        '
        'lblQuiz
        '
        Me.lblQuiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuiz.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblQuiz.Location = New System.Drawing.Point(26, 344)
        Me.lblQuiz.Name = "lblQuiz"
        Me.lblQuiz.Size = New System.Drawing.Size(727, 26)
        Me.lblQuiz.TabIndex = 4
        Me.lblQuiz.Text = "MINE UR MIND"
        Me.lblQuiz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gpMain
        '
        Me.gpMain.Controls.Add(Me.btnSubmit)
        Me.gpMain.Controls.Add(Me.txtPlace)
        Me.gpMain.Controls.Add(Me.txtCollege)
        Me.gpMain.Controls.Add(Me.txtName)
        Me.gpMain.Controls.Add(Me.lblPlace)
        Me.gpMain.Controls.Add(Me.lblCollegeName)
        Me.gpMain.Controls.Add(Me.lblName)
        Me.gpMain.Location = New System.Drawing.Point(212, 113)
        Me.gpMain.Name = "gpMain"
        Me.gpMain.Size = New System.Drawing.Size(350, 201)
        Me.gpMain.TabIndex = 3
        Me.gpMain.TabStop = False
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(23, 151)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(305, 30)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "START QUIZ"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtPlace
        '
        Me.txtPlace.Location = New System.Drawing.Point(101, 100)
        Me.txtPlace.Name = "txtPlace"
        Me.txtPlace.Size = New System.Drawing.Size(227, 20)
        Me.txtPlace.TabIndex = 5
        '
        'txtCollege
        '
        Me.txtCollege.Location = New System.Drawing.Point(101, 64)
        Me.txtCollege.Name = "txtCollege"
        Me.txtCollege.Size = New System.Drawing.Size(227, 20)
        Me.txtCollege.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(101, 28)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(227, 20)
        Me.txtName.TabIndex = 3
        '
        'lblPlace
        '
        Me.lblPlace.AutoSize = True
        Me.lblPlace.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlace.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPlace.Location = New System.Drawing.Point(20, 104)
        Me.lblPlace.Name = "lblPlace"
        Me.lblPlace.Size = New System.Drawing.Size(52, 16)
        Me.lblPlace.TabIndex = 2
        Me.lblPlace.Text = "Place:"
        '
        'lblCollegeName
        '
        Me.lblCollegeName.AutoSize = True
        Me.lblCollegeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCollegeName.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCollegeName.Location = New System.Drawing.Point(19, 68)
        Me.lblCollegeName.Name = "lblCollegeName"
        Me.lblCollegeName.Size = New System.Drawing.Size(66, 16)
        Me.lblCollegeName.TabIndex = 1
        Me.lblCollegeName.Text = "College:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblName.Location = New System.Drawing.Point(19, 32)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(53, 16)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'lblEvent
        '
        Me.lblEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEvent.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblEvent.Location = New System.Drawing.Point(26, 79)
        Me.lblEvent.Name = "lblEvent"
        Me.lblEvent.Size = New System.Drawing.Size(727, 26)
        Me.lblEvent.TabIndex = 2
        Me.lblEvent.Text = "X-BYTE'10"
        Me.lblEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDept
        '
        Me.lblDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDept.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDept.Location = New System.Drawing.Point(26, 48)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(727, 26)
        Me.lblDept.TabIndex = 1
        Me.lblDept.Text = "DEPARTMENT OF COMPUTER SCIENCE && ENGINEERING"
        Me.lblDept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCollege
        '
        Me.lblCollege.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCollege.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCollege.Location = New System.Drawing.Point(23, 15)
        Me.lblCollege.Name = "lblCollege"
        Me.lblCollege.Size = New System.Drawing.Size(727, 26)
        Me.lblCollege.TabIndex = 0
        Me.lblCollege.Text = "FRANCIS XAVIER ENGINEERING COLLEGE"
        Me.lblCollege.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(803, 423)
        Me.Controls.Add(Me.pMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pMain.ResumeLayout(False)
        Me.gpMain.ResumeLayout(False)
        Me.gpMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pMain As System.Windows.Forms.Panel
    Friend WithEvents lblCollege As System.Windows.Forms.Label
    Friend WithEvents lblEvent As System.Windows.Forms.Label
    Friend WithEvents lblDept As System.Windows.Forms.Label
    Friend WithEvents gpMain As System.Windows.Forms.GroupBox
    Friend WithEvents lblCollegeName As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblPlace As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents txtPlace As System.Windows.Forms.TextBox
    Friend WithEvents txtCollege As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblQuiz As System.Windows.Forms.Label
    Friend WithEvents btnScore As System.Windows.Forms.Button

End Class
