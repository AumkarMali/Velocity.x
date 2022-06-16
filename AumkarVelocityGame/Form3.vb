Public Class frmSettings

    Private Sub btnResetScore_Click(sender As Object, e As EventArgs) Handles btnResetScore.Click
        Try
            'This overrites and updates the top speed
            My.Computer.FileSystem.DeleteFile("HighScore.txt")
        Catch ex As Exception
        End Try

        My.Computer.FileSystem.WriteAllText("HighScore.txt", 0, True)

        MsgBox("HIGH SCORE RESETTED")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmIntro.Show()
        Me.Close()
    End Sub
End Class