'Arjun Hariharan, Period 6, averageScore
Public Class Form1

    Private Sub averageTheScore(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAverage.Click
        Dim userResponse As String
        Dim score As Integer
        Dim totalScore As Integer
        Const FLAG As Integer = -1
        Dim numbScores As Integer
        Dim average As Single

        

        Do
            userResponse = InputBox("Enter score, enter -1 when done", "Average Score")
            score = Val(userResponse)
            If score <> FLAG And userResponse <> Nothing Then

                totalScore += score
                numbScores += 1
                average = totalScore / numbScores
            End If
        Loop While score <> FLAG And userResponse <> Nothing

        If score <> FLAG And userResponse <> Nothing Then
            Me.lblScoresEntered.Text = "You entered " & numbScores & " scores"
            Me.lblResponse.Text = average

        Else
            Me.lblScoresEntered.Text = "You entered " & numbScores & " scores"
            Me.lblResponse.Text = average
        End If

        
        

    End Sub



End Class
