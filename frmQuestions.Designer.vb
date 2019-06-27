<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestions
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuestions))
        Me.pMain = New System.Windows.Forms.Panel
        Me.lblWishes = New System.Windows.Forms.Label
        Me.lblTime = New System.Windows.Forms.Label
        Me.btnSubmit = New System.Windows.Forms.Button
        Me.rbCh4 = New System.Windows.Forms.RadioButton
        Me.rbCh3 = New System.Windows.Forms.RadioButton
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.rbCh2 = New System.Windows.Forms.RadioButton
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.rbCh1 = New System.Windows.Forms.RadioButton
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.txtQuestion = New System.Windows.Forms.TextBox
        Me.tmrQuiz = New System.Windows.Forms.Timer(Me.components)
        Me.pMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'pMain
        '
        Me.pMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pMain.BackColor = System.Drawing.Color.Orange
        Me.pMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pMain.Controls.Add(Me.lblWishes)
        Me.pMain.Controls.Add(Me.lblTime)
        Me.pMain.Controls.Add(Me.btnSubmit)
        Me.pMain.Controls.Add(Me.rbCh4)
        Me.pMain.Controls.Add(Me.rbCh3)
        Me.pMain.Controls.Add(Me.TextBox4)
        Me.pMain.Controls.Add(Me.TextBox3)
        Me.pMain.Controls.Add(Me.rbCh2)
        Me.pMain.Controls.Add(Me.TextBox2)
        Me.pMain.Controls.Add(Me.rbCh1)
        Me.pMain.Controls.Add(Me.TextBox1)
        Me.pMain.Controls.Add(Me.txtQuestion)
        Me.pMain.Location = New System.Drawing.Point(12, 12)
        Me.pMain.Name = "pMain"
        Me.pMain.Size = New System.Drawing.Size(779, 399)
        Me.pMain.TabIndex = 1
        '
        'lblWishes
        '
        Me.lblWishes.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWishes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblWishes.Location = New System.Drawing.Point(26, 186)
        Me.lblWishes.Name = "lblWishes"
        Me.lblWishes.Size = New System.Drawing.Size(727, 26)
        Me.lblWishes.TabIndex = 12
        Me.lblWishes.Text = "Thank you For Participating in ""Mine Ur Mind"""
        Me.lblWishes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblWishes.Visible = False
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTime.Location = New System.Drawing.Point(26, 359)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(727, 26)
        Me.lblTime.TabIndex = 11
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(75, 320)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(626, 30)
        Me.btnSubmit.TabIndex = 10
        Me.btnSubmit.Text = "SUBMIT && GO NEXT"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'rbCh4
        '
        Me.rbCh4.AutoSize = True
        Me.rbCh4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCh4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbCh4.Location = New System.Drawing.Point(416, 231)
        Me.rbCh4.Name = "rbCh4"
        Me.rbCh4.Size = New System.Drawing.Size(28, 28)
        Me.rbCh4.TabIndex = 9
        Me.rbCh4.TabStop = True
        Me.rbCh4.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.rbCh4.UseVisualStyleBackColor = True
        '
        'rbCh3
        '
        Me.rbCh3.AutoSize = True
        Me.rbCh3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCh3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbCh3.Location = New System.Drawing.Point(90, 231)
        Me.rbCh3.Name = "rbCh3"
        Me.rbCh3.Size = New System.Drawing.Size(28, 28)
        Me.rbCh3.TabIndex = 8
        Me.rbCh3.TabStop = True
        Me.rbCh3.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.rbCh3.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.Orange
        Me.TextBox4.Enabled = False
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.Color.White
        Me.TextBox4.Location = New System.Drawing.Point(401, 225)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(300, 40)
        Me.TextBox4.TabIndex = 7
        Me.TextBox4.TabStop = False
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.Orange
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.ForeColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(75, 225)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(300, 40)
        Me.TextBox3.TabIndex = 6
        Me.TextBox3.TabStop = False
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rbCh2
        '
        Me.rbCh2.AutoSize = True
        Me.rbCh2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCh2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbCh2.Location = New System.Drawing.Point(416, 156)
        Me.rbCh2.Name = "rbCh2"
        Me.rbCh2.Size = New System.Drawing.Size(28, 28)
        Me.rbCh2.TabIndex = 5
        Me.rbCh2.TabStop = True
        Me.rbCh2.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.rbCh2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Orange
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(401, 150)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(300, 40)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.TabStop = False
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rbCh1
        '
        Me.rbCh1.AutoSize = True
        Me.rbCh1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCh1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.rbCh1.Location = New System.Drawing.Point(90, 156)
        Me.rbCh1.Name = "rbCh1"
        Me.rbCh1.Size = New System.Drawing.Size(28, 28)
        Me.rbCh1.TabIndex = 3
        Me.rbCh1.TabStop = True
        Me.rbCh1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.rbCh1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Orange
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(75, 150)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(300, 40)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.TabStop = False
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtQuestion
        '
        Me.txtQuestion.BackColor = System.Drawing.Color.Orange
        Me.txtQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuestion.ForeColor = System.Drawing.Color.White
        Me.txtQuestion.Location = New System.Drawing.Point(33, 24)
        Me.txtQuestion.Multiline = True
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.ReadOnly = True
        Me.txtQuestion.Size = New System.Drawing.Size(715, 100)
        Me.txtQuestion.TabIndex = 0
        Me.txtQuestion.TabStop = False
        Me.txtQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tmrQuiz
        '
        Me.tmrQuiz.Interval = 1000
        '
        'frmQuestions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(803, 423)
        Me.Controls.Add(Me.pMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmQuestions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quizzer"
        Me.pMain.ResumeLayout(False)
        Me.pMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pMain As System.Windows.Forms.Panel
    Friend WithEvents txtQuestion As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents rbCh1 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents rbCh4 As System.Windows.Forms.RadioButton
    Friend WithEvents rbCh3 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents rbCh2 As System.Windows.Forms.RadioButton
    Friend WithEvents lblWishes As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents tmrQuiz As System.Windows.Forms.Timer
End Class
