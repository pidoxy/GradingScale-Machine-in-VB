Public Class GradingScale
    Dim Score As Double
    Dim Grade


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Score = Val(ScoreBox.Text)

        If Score = 0 Then
            MsgBox("Put a value in the score box")
        Else
            Select Case Score
                Case 0 To 39
                    Grade = "F"
                Case 40 To 44
                    Grade = "E"
                Case 45 To 49
                    Grade = "D"
                Case 50 To 59
                    Grade = "C"
                Case 60 To 69
                    Grade = "B"
                Case 70 To 100
                    Grade = "A"
            End Select
        End If

        GradeBox.Text = Grade
        MsgBox(Grade)

    End Sub
End Class
