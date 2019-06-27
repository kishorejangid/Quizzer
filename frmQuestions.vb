Imports System.Data.OleDb
Imports System.Data
Imports Quizzer.modMain
Public Class frmQuestions
    Dim dt As New DataTable
    Dim dtSettings As New DataTable
    Dim dConn As OleDbConnection
    Dim iQuesNo As Integer
    Dim iScore As Integer
    Dim iSeconds As Integer
    Dim iMinutes As Integer
    Dim strAnswer As String


    Public Sub New()
        InitializeComponent()
        tmrQuiz.Start()
    End Sub
    

    Private Sub frmQuestions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Width = Screen.PrimaryScreen.Bounds.Width * 0.8
        'Me.Height = Screen.PrimaryScreen.Bounds.Height * 0.6
        Me.Width = 819
        Me.Height = 461
        Me.CenterToScreen()
        iQuesNo = 0
        iScore = 0
        Try
            dConn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Quizzer.mdb;")
            dConn.Open()

            Dim daSettings As New OleDb.OleDbDataAdapter("SELECT * FROM QuizSettings Where SettingNo=1", dConn)
            daSettings.Fill(dtSettings)
            strNoOfQuestions = dtSettings.Rows(0).Item(1).ToString
            strQuizTime = dtSettings.Rows(0).Item(2).ToString

            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Quizzer", dConn)
            da.Fill(dt)            
            txtQuestion.Text = JangidFormat(dt.Rows(iQuesNo).Item(1).ToString)
            rbCh1.Text = dt.Rows(iQuesNo).Item(2).ToString
            rbCh2.Text = dt.Rows(iQuesNo).Item(3).ToString
            rbCh3.Text = dt.Rows(iQuesNo).Item(4).ToString
            rbCh4.Text = dt.Rows(iQuesNo).Item(5).ToString
            strAnswer = dt.Rows(iQuesNo).Item(6).ToString.Trim

            iSeconds = 59
            iMinutes = CInt(strQuizTime) - 1
            lblTime.Text = iMinutes & " Mins " & iSeconds & " Secs Remaining....."



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub QuizOver()
        txtQuestion.Visible = False
        rbCh1.Visible = False
        rbCh2.Visible = False
        rbCh3.Visible = False
        rbCh3.Visible = False
        rbCh4.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        lblTime.Visible = False
        btnSubmit.Visible = False
        lblWishes.Visible = True
        Dim strTime As String
        strTime = System.DateTime.Now.ToString
        Dim dCmd As New OleDbCommand("Update StudDetails Set Score = '" & iScore & "',EndTime =  '" & strTime & "' Where StudName = '" & strName & "'", dConn)
        dCmd.ExecuteNonQuery()
    End Sub
    Private Sub CheckAnswers()
        If rbCh1.Checked Then
            If Trim(rbCh1.Text) = strAnswer Then
                iScore = iScore + 1
            End If
        ElseIf rbCh2.Checked Then
            If Trim(rbCh2.Text) = strAnswer Then
                iScore = iScore + 1
            End If
        ElseIf rbCh3.Checked Then
            If Trim(rbCh3.Text) = strAnswer Then
                iScore = iScore + 1
            End If
        ElseIf rbCh4.Checked Then
            If Trim(rbCh4.Text) = strAnswer Then
                iScore = iScore + 1
            End If
        End If
        rbCh1.Checked = False
        rbCh2.Checked = False
        rbCh3.Checked = False
        rbCh4.Checked = False
    End Sub
    

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        Call CheckAnswers()
        If iQuesNo >= CInt(strNoOfQuestions) - 1 Then
            Try
                Call QuizOver()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Quizzer")
            End Try
            Exit Sub
        End If
        iQuesNo = iQuesNo + 1
        txtQuestion.Text = JangidFormat(dt.Rows(iQuesNo).Item(1).ToString)
        rbCh1.Text = dt.Rows(iQuesNo).Item(2).ToString
        rbCh2.Text = dt.Rows(iQuesNo).Item(3).ToString
        rbCh3.Text = dt.Rows(iQuesNo).Item(4).ToString
        rbCh4.Text = dt.Rows(iQuesNo).Item(5).ToString
        strAnswer = dt.Rows(iQuesNo).Item(6).ToString
    End Sub

    Private Sub tmrQuiz_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrQuiz.Tick
        iSeconds = iSeconds - 1
        If iSeconds < 0 Then
            iSeconds = 59
            iMinutes = iMinutes - 1
        End If
        If iMinutes <= 0 And iSeconds <= 0 Then
            tmrQuiz.Enabled = False
            tmrQuiz.Stop()
            Call CheckAnswers()
            Call QuizOver()
            Exit Sub
        End If
        lblTime.Text = iMinutes & " Mins " & iSeconds & " Secs Remaining....."
    End Sub
End Class