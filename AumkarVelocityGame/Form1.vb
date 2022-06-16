Public Class frmIntro
    'Mr. Simler
    'Aumkar Mali
    'ICS2O0-F    'June 17, 2022
    
    Private Sub btnStartGame_Click(sender As Object, e As EventArgs) Handles btnStartGame.Click

        'When game starts, show game screen
        frmFractionGame.Show()
        Me.Hide()
    End Sub

    Private Sub frmIntro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Read high score txt file 
        Dim FilePath = "HighScore.txt"

        'If high score file doesnt exit then create one
        If System.IO.File.Exists(FilePath) = False Then
            My.Computer.FileSystem.WriteAllText("HighScore.txt", 0, True)
        End If

        tmrUpdateTopSpeed.Start()

    End Sub

    Private Sub tmrUpdateTopSpeed_Tick(sender As Object, e As EventArgs) Handles tmrUpdateTopSpeed.Tick

        'Update high score
        Dim strTopSpeed As String = IO.File.ReadAllText("HighScore.txt")

        lblTopSpeed.Text = "Top Speed: " + strTopSpeed + " Kph"
    End Sub


    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        frmSettings.Show()
        Me.Hide()
    End Sub
End Class
