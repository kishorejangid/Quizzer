Imports System.Data.OleDb
Imports System.Data
Public Class frmScore
    Dim dConn As New OleDbConnection
    Dim dCmd As OleDbCommand
    Dim dt As New DataTable
    Dim dr As OleDbDataReader

    Private Sub frmScore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dConn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Quizzer.mdb;")
            dConn.Open()
            Dim da As New OleDb.OleDbDataAdapter("SELECT StudName FROM StudDetails", dConn)
            da.Fill(dt)
            Dim i As Integer
            For i = 0 To dt.Rows.Count - 1
                cmbName.Items.Add(dt.Rows(i).Item(0))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        If txtUserName.Text = "mineurmind" And txtPassword.Text = "mineurmind" Then
            grdScoreBoard.Visible = True
            grdLogin.Visible = False
        Else
            MsgBox("Check User Name & Password", MsgBoxStyle.Information, "Quizzer")
            txtPassword.Text = ""
            txtUserName.Text = ""
        End If
    End Sub

    
    Private Sub btnClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    
    Private Sub cmbName_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbName.SelectedIndexChanged
        Dim strSql As String = "SELECT * FROM StudDetails Where StudName= '" & cmbName.SelectedItem.ToString.Trim & "'"
        Dim dCmd As New OleDbCommand(strSql, dConn)
        dr = dCmd.ExecuteReader
        dr.Read()
        lblCollege.Text = dr.Item(1).ToString
        lblScore.Text = dr.Item(3).ToString
        lblStart.Text = dr.Item(4).ToString
        lblEnd.Text = dr.Item(5).ToString
    End Sub
End Class