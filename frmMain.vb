Imports System.Data.OleDb
Imports System.Data
Imports Quizzer.modMain
Public Class frmMain
    Dim dt As New DataTable
    Dim dConn As OleDbConnection
    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load        
        'Me.Width = Screen.PrimaryScreen.Bounds.Width * 0.8
        'Me.Height = Screen.PrimaryScreen.Bounds.Height * 0.6
        Me.Width = 819
        Me.Height = 461
        Me.CenterToScreen()
        gpMain.Left = (pMain.Width - gpMain.Width) / 2
        lblCollege.Left = (pMain.Width - lblCollege.Width) / 2
        lblDept.Left = (pMain.Width - lblDept.Width) / 2
        lblEvent.Left = (pMain.Width - lblEvent.Width) / 2
        lblQuiz.Left = (pMain.Width - lblQuiz.Width) / 2        
        Try
            dConn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Quizzer.mdb;")
            dConn.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub        

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        If txtName.Text = "" Then
            Exit Sub
        End If
        Try
            Dim strTime As String
            Dim result As String
            strTime = System.DateTime.Now.ToString
            strName = txtName.Text.Trim
            Dim strSql As String = "Insert Into StudDetails (StudName,College,Place,StartTime) values ('" & txtName.Text.Trim & "','" & txtCollege.Text.Trim & "','" & txtPlace.Text.Trim & "','" & strTime & "')"
            Dim dCmd As New OleDbCommand(strSql, dConn)
            result = dCmd.ExecuteNonQuery()
            If result = 1 Then                
                frmQuestions.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Quizzer")
        End Try
    End Sub

    Private Sub btnScore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScore.Click
        frmScore.ShowDialog()
    End Sub

    Private Sub frmMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        gpMain.Left = (pMain.Width - gpMain.Width) / 2
        lblCollege.Left = (pMain.Width - lblCollege.Width) / 2
        lblDept.Left = (pMain.Width - lblDept.Width) / 2
        lblEvent.Left = (pMain.Width - lblEvent.Width) / 2
        lblQuiz.Left = (pMain.Width - lblQuiz.Width) / 2
    End Sub
End Class
