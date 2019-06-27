Module modMain
    Public strName As String
    Public strNoOfQuestions As String
    Public strQuizTime As String
    Public Function JangidFormat(ByVal str As String) As String
        Dim i As Integer
        Dim newstr As String
        newstr = UCase(Mid$(str, 1, 1))
        For i = 2 To Len(str)
            newstr = newstr & Mid$(str, i, 1)
            If Mid$(str, i, 1) = " " Then
                newstr = newstr & UCase(Mid$(str, i + 1, 1))
                i = i + 1
            End If
        Next
        JangidFormat = newstr
    End Function
End Module

