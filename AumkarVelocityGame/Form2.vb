Public Class frmFractionGame

    'Mr. Simler
    'Aumkar Mali
    'ICS2O0-F
    'June 17, 2022

    Dim intSpeed As Decimal = 10
    Dim intSpeedKph As Decimal
    Dim intRoad(4) As PictureBox
    Dim strAnswerToQuestion
    Dim intGCD As Integer

    Dim intBoostCounter As Integer = 0
    Dim intAccelCounter As Integer = 0

    Dim bonusQuestionEnable As Boolean = False

    'Form load
    Private Sub frmFractionGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        

        'Place car over other layers
        prcCar.BringToFront()

        'generate rand question
        genQuestion()
        prbTimer.Value = 100

        'Start movement of road stickers
        tmrSignSpeed.Start()

        'Initialize road stickers
        intRoad(0) = prcRoadSign1
        intRoad(1) = prcRoadSign2
        intRoad(2) = prcRoadSign3
        intRoad(3) = prcRoadSign4
        intRoad(4) = prcRoadSign5

        prcBoost.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)

    End Sub


    'answer correct function
    Function OnAnswerCorrect()

        incSpeedAcceleration()
        genQuestion()

        Return Nothing
    End Function


    'Acceleration physics
    Private Sub tmrSpeedAccel_Tick(sender As Object, e As EventArgs) Handles tmrSpeedAccel.Tick

        'Speed +5, add one speed per tick
        If intAccelCounter >= 5 Then
            Console.WriteLine(intAccelCounter)

            'To continue counting till 5, intAccelCounter must be re-assigned to -1
            intAccelCounter = -1
            tmrSpeedAccel.Stop()
        Else
            intSpeed += 1
        End If

        intAccelCounter += 1
    End Sub


    'Bonus question correct function
    Function OnBonusAnswerCorrect()
        bonusQuestionEnable = False

        tmrBoostEnabled.Start()

        genQuestion()

        Return Nothing
    End Function


    'On submit button clicked
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        'when bonus question; call unique function, else call regular function
        If bonusQuestionEnable Then
            If rdbOption1.Checked And rdbOption1.Text = strAnswerToQuestion Then
                OnBonusAnswerCorrect()
            ElseIf rdbOption2.Checked And rdbOption2.Text = strAnswerToQuestion Then
                OnBonusAnswerCorrect()
            ElseIf rdbOption3.Checked And rdbOption3.Text = strAnswerToQuestion Then
                OnBonusAnswerCorrect()
            ElseIf rdbOption4.Checked And rdbOption4.Text = strAnswerToQuestion Then
                OnBonusAnswerCorrect()
            Else
                intSpeed -= 10
            End If
        Else
            If rdbOption1.Checked And rdbOption1.Text = strAnswerToQuestion Then
                OnAnswerCorrect()
            ElseIf rdbOption2.Checked And rdbOption2.Text = strAnswerToQuestion Then
                OnAnswerCorrect()
            ElseIf rdbOption3.Checked And rdbOption3.Text = strAnswerToQuestion Then
                OnAnswerCorrect()
            ElseIf rdbOption4.Checked And rdbOption4.Text = strAnswerToQuestion Then
                OnAnswerCorrect()
            Else
                gameEnd()
            End If
        End If
    End Sub


    'Gen rand question
    Function genQuestion()
        prbTimer.Value = 100

        Dim intRandOne As Integer
        Dim intRandOneDenominator As Integer

        Dim intRandTwo As Integer
        Dim intRandTwoDenominator As Integer

        Dim intRandOperator
        Dim strOperator As String

        Dim strQuestion As String

        Dim randChanceOfBonus As Integer

        'Define bonus chance
        randChanceOfBonus = Int(Rnd() * 15 + 1)

        'If bonus is True, call unique function
        If randChanceOfBonus = 10 Then
            bonusQuestionEnable = True
            genBonusQuestion()

        Else
            'Define 2 random fractions to be in the question
            intRandOne = Int(Rnd() * 10 + 1)
            intRandTwo = Int(Rnd() * 10 + 1)

            intRandOneDenominator = Int(Rnd() * 10 + 1)
            intRandTwoDenominator = Int(Rnd() * 10 + 1)

            'Choose rand operator
            intRandOperator = Int(Rnd() * 4 + 1)

            'Based on operator, call function to generate the answer
            If intRandOperator = 1 Then
                strOperator = "+"

                solFractionAddition(intRandOne, intRandOneDenominator, intRandTwo, intRandTwoDenominator)


            ElseIf intRandOperator = 2 Then
                strOperator = "-"

                solFractionSubtraction(intRandOne, intRandOneDenominator, intRandTwo, intRandTwoDenominator)

            ElseIf intRandOperator = 3 Then
                strOperator = "x"

                solFractionMultiplication(intRandOne, intRandOneDenominator, intRandTwo, intRandTwoDenominator)

            ElseIf intRandOperator = 4 Then
                strOperator = "/"

                solFractionDivision(intRandOne, intRandOneDenominator, intRandTwo, intRandTwoDenominator)

            End If

            'Generate question
            strQuestion = String.Format("What is {0}/{1} {2} {3}/{4}?", intRandOne, intRandOneDenominator, strOperator, intRandTwo, intRandTwoDenominator)

            lblPrompt.Text = strQuestion

            genRandomAnswers()

            'Start Timer
            tmrQuestionAlarm.Start()
        End If


        Return Nothing
    End Function


    'Gen bonus question
    Function genBonusQuestion()
        prbTimer.Value = 100

        Dim intRandOne As Integer
        Dim intRandOneDenominator As Integer

        Dim intRandTwo As Integer
        Dim intRandTwoDenominator As Integer

        Dim intRandThree As Integer
        Dim intRandThreeDenominator As Integer

        Dim intRandOperator

        Dim strQuestion As String

        'Generate 2 rand fractions
        intRandOne = Int(Rnd() * 5 + 1)
        intRandTwo = Int(Rnd() * 5 + 1)
        intRandThree = Int(Rnd() * 5 + 1)

        intRandOneDenominator = Int(Rnd() * 5 + 1)
        intRandTwoDenominator = Int(Rnd() * 5 + 1)
        intRandThreeDenominator = Int(Rnd() * 5 + 1)

        'Gen rand operator
        intRandOperator = Int(Rnd() * 4 + 1)

        solFractionMultiplicationBonus(intRandOne, intRandOneDenominator, intRandTwo, intRandTwoDenominator, intRandThree, intRandThreeDenominator)


        'Create question
        strQuestion = String.Format("What is {0}/{1} x {2}/{3} x {4}/{5}?", intRandOne, intRandOneDenominator, intRandTwo, intRandTwoDenominator, intRandThree, intRandThreeDenominator)

        lblPrompt.Text = strQuestion

        genRandomAnswers()
        'Start Timer
        tmrQuestionAlarm.Start()
        Return Nothing
    End Function


    'https://www.programmingalgorithms.com/algorithm/greatest-common-divisor/vb-net/ finds GCD of fraction
    Function findGCD(a As Integer, b As Integer) As Integer

        If a = 0 Then
            Return b
        End If

        While b <> 0
            If a > b Then
                a -= b
            Else
                b -= a
            End If
        End While

        intGCD = a

        Return intGCD
    End Function

    'Generate answer to addition fraction problem
    Function solFractionAddition(intRandOne, intRandOneDenominator, intRandTwo, intRandTwoDenominator)
        Dim intAnswerDenominator As Integer
        Dim intAnswerNumerator As Integer

        'Cross multiplies fractions numerator nd denominator
        intAnswerDenominator = intRandOneDenominator * intRandTwoDenominator
        intAnswerNumerator = (intRandOne * intRandTwoDenominator) + (intRandTwo * intRandOneDenominator)

        'Gets GCD of this answer
        findGCD(intAnswerNumerator, intAnswerDenominator)

        'Divides answer numerator and denominator by the GCD
        intAnswerNumerator = intAnswerNumerator / intGCD
        intAnswerDenominator = intAnswerDenominator / intGCD

        'define answer as string
        strAnswerToQuestion = String.Format("{0}/{1}", intAnswerNumerator, intAnswerDenominator)

        Return strAnswerToQuestion
    End Function


    'Generate answer to subtraction fraction problem
    Function solFractionSubtraction(intRandOne, intRandOneDenominator, intRandTwo, intRandTwoDenominator)
        Dim intAnswerDenominator As Integer
        Dim intAnswerNumerator As Integer

        'Cross multiply numerator and denominator
        intAnswerDenominator = intRandOneDenominator * intRandTwoDenominator
        intAnswerNumerator = (intRandOne * intRandTwoDenominator) - (intRandTwo * intRandOneDenominator)

        'if answer to fraction is negative, convert int to positive then get the GCD
        If intAnswerNumerator < 0 Then
            findGCD(-intAnswerNumerator, intAnswerDenominator)
        Else
            findGCD(intAnswerNumerator, intAnswerDenominator)
        End If

        'Divide answer by GCD
        intAnswerNumerator = intAnswerNumerator / intGCD
        intAnswerDenominator = intAnswerDenominator / intGCD

        'Define answer as string
        strAnswerToQuestion = String.Format("{0}/{1}", intAnswerNumerator, intAnswerDenominator)

        Return strAnswerToQuestion
    End Function


    'Generate answer to Multiplication fraction problem
    Function solFractionMultiplication(intRandOne, intRandOneDenominator, intRandTwo, intRandTwoDenominator)
        Dim intAnswerDenominator As Integer
        Dim intAnswerNumerator As Integer

        'Multiply numerators and denominators together
        intAnswerDenominator = intRandOneDenominator * intRandTwoDenominator
        intAnswerNumerator = intRandOne * intRandTwo

        'Get GCD
        findGCD(intAnswerNumerator, intAnswerDenominator)

        'Divide by GCD
        intAnswerNumerator = intAnswerNumerator / intGCD
        intAnswerDenominator = intAnswerDenominator / intGCD

        'Define answer as string
        strAnswerToQuestion = String.Format("{0}/{1}", intAnswerNumerator, intAnswerDenominator)

        Return strAnswerToQuestion
    End Function


    'Generate answer to Division fraction problem
    Function solFractionDivision(intRandOne, intRandOneDenominator, intRandTwo, intRandTwoDenominator)
        Dim intAnswerDenominator As Integer
        Dim intAnswerNumerator As Integer

        'Multiple fraction 1 by reciprocal of fraction 2
        intAnswerDenominator = intRandOneDenominator * intRandTwo
        intAnswerNumerator = intRandOne * intRandTwoDenominator

        'Get GCD
        findGCD(intAnswerNumerator, intAnswerDenominator)

        'Divide answer by GCD
        intAnswerNumerator = intAnswerNumerator / intGCD
        intAnswerDenominator = intAnswerDenominator / intGCD

        'Define answer as string
        strAnswerToQuestion = String.Format("{0}/{1}", intAnswerNumerator, intAnswerDenominator)

        Return strAnswerToQuestion
    End Function


    'BONUS QUESTION: multiplication problem with 3 fractions
    Function solFractionMultiplicationBonus(intRandOne, intRandOneDenominator, intRandTwo, intRandTwoDenominator, intRandThree, intRandThreeDenominator)
        Dim intAnswerDenominator As Integer
        Dim intAnswerNumerator As Integer

        'Multiple all 3 denominators and numerators
        intAnswerDenominator = intRandOneDenominator * intRandTwoDenominator * intRandThreeDenominator
        intAnswerNumerator = intRandOne * intRandTwo * intRandThree

        'Get GCD
        findGCD(intAnswerNumerator, intAnswerDenominator)

        'Divide the answer by GCD
        intAnswerNumerator = intAnswerNumerator / intGCD
        intAnswerDenominator = intAnswerDenominator / intGCD

        'Define answer as string
        strAnswerToQuestion = String.Format("{0}/{1}", intAnswerNumerator, intAnswerDenominator)

        Return strAnswerToQuestion
    End Function


    'Generate random WRONG answers
    Function genRandomAnswers()
        Dim intDigitRightAnswer As Integer

        'Gen random WRONG ansers
        Dim intRandAnswer1 As Integer = Int(Rnd() * 10 + 1)
        Dim intRandAnswer2 As Integer = Int(Rnd() * 10 + 1)
        Dim intRandAnswer3 As Integer = Int(Rnd() * 10 + 1)

        Dim intRandAnswerDen1 As Integer = Int(Rnd() * 10 + 1)
        Dim intRandAnswerDen2 As Integer = Int(Rnd() * 10 + 1)
        Dim intRandAnswerDen3 As Integer = Int(Rnd() * 10 + 1)

        Dim strIncorrectAnswer1 As String = String.Format("{0}/{1}", intRandAnswer1, intRandAnswerDen1)
        Dim strIncorrectAnswer2 As String = String.Format("{0}/{1}", intRandAnswer2, intRandAnswerDen2)
        Dim strIncorrectAnswer3 As String = String.Format("{0}/{1}", intRandAnswer3, intRandAnswerDen3)

        'Randomly decide which radio button will be the right answer
        intDigitRightAnswer = Int(Rnd() * 4 + 1)

        'Assign answers to radio buttons (only one radio button will have the right answer)
        If intDigitRightAnswer = 1 Then
            rdbOption1.Text = strAnswerToQuestion
            rdbOption2.Text = strIncorrectAnswer1
            rdbOption3.Text = strIncorrectAnswer2
            rdbOption4.Text = strIncorrectAnswer3
        ElseIf intDigitRightAnswer = 2 Then
            rdbOption1.Text = strIncorrectAnswer1
            rdbOption2.Text = strAnswerToQuestion
            rdbOption3.Text = strIncorrectAnswer2
            rdbOption4.Text = strIncorrectAnswer3
        ElseIf intDigitRightAnswer = 3 Then
            rdbOption1.Text = strIncorrectAnswer1
            rdbOption2.Text = strIncorrectAnswer2
            rdbOption3.Text = strAnswerToQuestion
            rdbOption4.Text = strIncorrectAnswer3
        ElseIf intDigitRightAnswer = 4 Then
            rdbOption1.Text = strIncorrectAnswer1
            rdbOption2.Text = strIncorrectAnswer2
            rdbOption3.Text = strIncorrectAnswer3
            rdbOption4.Text = strAnswerToQuestion
        End If

        Return Nothing
    End Function

    '--------------------------- Animation and speed functions -----------------------------

    'Accelration function
    Function incSpeedAcceleration()
        tmrSpeedAccel.Start()
        Return Nothing
    End Function


    'Speed animation 
    Private Sub tmrSignSpeed_Tick(sender As Object, e As EventArgs) Handles tmrSignSpeed.Tick
        Dim intTime As Integer
        Dim intSpeedKph As Decimal


        'convert intSpeed val to in game KPH (distance of road is 17.83 meters/705 pixels)
        intSpeedKph = intSpeed / 3.6
        intTime = 17.83 / intSpeedKph
        intSpeedKph = (705 / intTime) / 100

        'Display speed
        lblSpeedDisplay.Text = "Speed: " + Str(intSpeed) + "KPH"

        For x As Integer = 0 To 4
            'Use intSpeedKph to move road stickers 
            intRoad(x).Left -= intSpeedKph

            'If road stickers are beyond screen, move them to right edge of screen
            If intRoad(x).Left <= 0 - intRoad(x).Width Then
                intRoad(x).Left = 664 + intRoad(x).Width
            End If
        Next
    End Sub


    'Function when Boost = True
    Private Sub tmrBoostEnabled_Tick(sender As Object, e As EventArgs) Handles tmrBoostEnabled.Tick

        'Show boost picture
        prcBoost.Show()


        'Accelerate +20 kph (increase speed by 1 every tick to mimic acceleration)
        If intBoostCounter = 20 Then
            intBoostCounter = 0
            prcBoost.Hide()
            tmrBoostEnabled.Stop()
        Else
            intSpeed += 1
        End If

        intBoostCounter += 1
    End Sub


    'Alarm for question
    Private Sub tmrQuestionAlarm_Tick(sender As Object, e As EventArgs) Handles tmrQuestionAlarm.Tick


        'When speed increases, amount of time to answer decreases
        If intSpeed < 30 Then
            tmrQuestionAlarm.Interval = 200
            lblTimer.Text = Str(prbTimer.Value / 5)

        ElseIf intSpeed >= 30 And intSpeed < 60 Then
            tmrQuestionAlarm.Interval = 150
            Dim prbTimerRounded As Decimal

            prbTimerRounded = prbTimer.Value / 7.5

            prbTimerRounded = Math.Round(prbTimerRounded, 2)
            lblTimer.Text = Str(prbTimerRounded)

        ElseIf intSpeed >= 60 Then
            tmrQuestionAlarm.Interval = 100
            Dim prbTimerRounded As Decimal

            prbTimerRounded = prbTimer.Value / 10

            prbTimerRounded = Math.Round(prbTimerRounded, 2)
            lblTimer.Text = Str(prbTimerRounded)
        End If

        'If timer runs out, game over
        If prbTimer.Value <= 0 Then
            gameEnd()
            MsgBox("Time ran out")
        Else
            prbTimer.Value -= 1
        End If
    End Sub


    'game over function
    Function gameEnd()
        Dim intTopSpeed As String = Int(IO.File.ReadAllText("HighScore.txt"))

        tmrQuestionAlarm.Stop()
        tmrSignSpeed.Stop()


        If intSpeed > intTopSpeed Then
            'If high scorew is reached, update txt file with new top speed
            Try
                'This overrites and updates the top speed
                My.Computer.FileSystem.DeleteFile("HighScore.txt")
            Catch ex As Exception
            End Try

            My.Computer.FileSystem.WriteAllText("HighScore.txt", intSpeed, True)
        End If

        lblGameOver.Show()

        MsgBox("GAME OVER")
        MsgBox("high score:" + Str(intSpeed))

        intSpeed = 0

        System.Threading.Thread.Sleep(1000)

        frmIntro.Show()
        Me.Close()

        Return Nothing
    End Function


    'Go back to menu screen
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim intTopSpeed As String = Int(IO.File.ReadAllText("HighScore.txt"))

        tmrQuestionAlarm.Stop()
        tmrSignSpeed.Stop()


        If intSpeed > intTopSpeed Then
            'If high scorew is reached, update txt file with new top speed
            Try
                'This overrites and updates the top speed
                My.Computer.FileSystem.DeleteFile("HighScore.txt")
            Catch ex As Exception
            End Try

            My.Computer.FileSystem.WriteAllText("HighScore.txt", intSpeed, True)
        End If

        lblGameOver.Show()

        intSpeed = 0

        frmIntro.Show()
        Me.Close()
    End Sub
End Class