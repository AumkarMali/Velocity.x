<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFractionGame
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFractionGame))
        Me.tmrSignSpeed = New System.Windows.Forms.Timer(Me.components)
        Me.prcRoadSign3 = New System.Windows.Forms.PictureBox()
        Me.prcRoadSign2 = New System.Windows.Forms.PictureBox()
        Me.prcRoadSign4 = New System.Windows.Forms.PictureBox()
        Me.prcRoadSign1 = New System.Windows.Forms.PictureBox()
        Me.prcRoadSign5 = New System.Windows.Forms.PictureBox()
        Me.prcCar = New System.Windows.Forms.PictureBox()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.grpQuestionHolder = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbOption2 = New System.Windows.Forms.RadioButton()
        Me.rdbOption4 = New System.Windows.Forms.RadioButton()
        Me.rdbOption3 = New System.Windows.Forms.RadioButton()
        Me.rdbOption1 = New System.Windows.Forms.RadioButton()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblSpeedDisplay = New System.Windows.Forms.Label()
        Me.prbTimer = New System.Windows.Forms.ProgressBar()
        Me.tmrQuestionAlarm = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblGameOver = New System.Windows.Forms.Label()
        Me.prcBoost = New System.Windows.Forms.PictureBox()
        Me.tmrBoostEnabled = New System.Windows.Forms.Timer(Me.components)
        Me.tmrSpeedAccel = New System.Windows.Forms.Timer(Me.components)
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.prcRoadSign3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prcRoadSign2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prcRoadSign4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prcRoadSign1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prcRoadSign5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prcCar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpQuestionHolder.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.prcBoost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrSignSpeed
        '
        Me.tmrSignSpeed.Interval = 10
        '
        'prcRoadSign3
        '
        Me.prcRoadSign3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.prcRoadSign3.Location = New System.Drawing.Point(340, 183)
        Me.prcRoadSign3.Name = "prcRoadSign3"
        Me.prcRoadSign3.Size = New System.Drawing.Size(131, 25)
        Me.prcRoadSign3.TabIndex = 4
        Me.prcRoadSign3.TabStop = False
        '
        'prcRoadSign2
        '
        Me.prcRoadSign2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.prcRoadSign2.Location = New System.Drawing.Point(155, 183)
        Me.prcRoadSign2.Name = "prcRoadSign2"
        Me.prcRoadSign2.Size = New System.Drawing.Size(132, 25)
        Me.prcRoadSign2.TabIndex = 2
        Me.prcRoadSign2.TabStop = False
        '
        'prcRoadSign4
        '
        Me.prcRoadSign4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.prcRoadSign4.Location = New System.Drawing.Point(532, 183)
        Me.prcRoadSign4.Name = "prcRoadSign4"
        Me.prcRoadSign4.Size = New System.Drawing.Size(136, 25)
        Me.prcRoadSign4.TabIndex = 5
        Me.prcRoadSign4.TabStop = False
        '
        'prcRoadSign1
        '
        Me.prcRoadSign1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.prcRoadSign1.Location = New System.Drawing.Point(-25, 183)
        Me.prcRoadSign1.Name = "prcRoadSign1"
        Me.prcRoadSign1.Size = New System.Drawing.Size(127, 25)
        Me.prcRoadSign1.TabIndex = 1
        Me.prcRoadSign1.TabStop = False
        '
        'prcRoadSign5
        '
        Me.prcRoadSign5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.prcRoadSign5.Location = New System.Drawing.Point(724, 183)
        Me.prcRoadSign5.Name = "prcRoadSign5"
        Me.prcRoadSign5.Size = New System.Drawing.Size(127, 25)
        Me.prcRoadSign5.TabIndex = 6
        Me.prcRoadSign5.TabStop = False
        '
        'prcCar
        '
        Me.prcCar.BackColor = System.Drawing.Color.Gray
        Me.prcCar.Image = CType(resources.GetObject("prcCar.Image"), System.Drawing.Image)
        Me.prcCar.Location = New System.Drawing.Point(181, 89)
        Me.prcCar.Name = "prcCar"
        Me.prcCar.Size = New System.Drawing.Size(171, 77)
        Me.prcCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.prcCar.TabIndex = 8
        Me.prcCar.TabStop = False
        '
        'grpQuestionHolder
        '
        Me.grpQuestionHolder.BackColor = System.Drawing.Color.SteelBlue
        Me.grpQuestionHolder.Controls.Add(Me.ProgressBar1)
        Me.grpQuestionHolder.Controls.Add(Me.lblPrompt)
        Me.grpQuestionHolder.Location = New System.Drawing.Point(170, 28)
        Me.grpQuestionHolder.Name = "grpQuestionHolder"
        Me.grpQuestionHolder.Size = New System.Drawing.Size(340, 44)
        Me.grpQuestionHolder.TabIndex = 9
        Me.grpQuestionHolder.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(-40, -10)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(433, 23)
        Me.ProgressBar1.TabIndex = 14
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblPrompt.Location = New System.Drawing.Point(15, 16)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(20, 25)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "*"
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(313, 321)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(0, 13)
        Me.lblAnswer.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.Add(Me.rdbOption2)
        Me.GroupBox1.Controls.Add(Me.rdbOption4)
        Me.GroupBox1.Controls.Add(Me.rdbOption3)
        Me.GroupBox1.Controls.Add(Me.rdbOption1)
        Me.GroupBox1.Location = New System.Drawing.Point(270, 305)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(158, 74)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'rdbOption2
        '
        Me.rdbOption2.AutoSize = True
        Me.rdbOption2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.rdbOption2.Location = New System.Drawing.Point(80, 10)
        Me.rdbOption2.Name = "rdbOption2"
        Me.rdbOption2.Size = New System.Drawing.Size(41, 29)
        Me.rdbOption2.TabIndex = 2
        Me.rdbOption2.TabStop = True
        Me.rdbOption2.Text = "?"
        Me.rdbOption2.UseVisualStyleBackColor = True
        '
        'rdbOption4
        '
        Me.rdbOption4.AutoSize = True
        Me.rdbOption4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.rdbOption4.Location = New System.Drawing.Point(80, 39)
        Me.rdbOption4.Name = "rdbOption4"
        Me.rdbOption4.Size = New System.Drawing.Size(41, 29)
        Me.rdbOption4.TabIndex = 2
        Me.rdbOption4.TabStop = True
        Me.rdbOption4.Text = "?"
        Me.rdbOption4.UseVisualStyleBackColor = True
        '
        'rdbOption3
        '
        Me.rdbOption3.AutoSize = True
        Me.rdbOption3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.rdbOption3.Location = New System.Drawing.Point(6, 39)
        Me.rdbOption3.Name = "rdbOption3"
        Me.rdbOption3.Size = New System.Drawing.Size(41, 29)
        Me.rdbOption3.TabIndex = 1
        Me.rdbOption3.TabStop = True
        Me.rdbOption3.Text = "?"
        Me.rdbOption3.UseVisualStyleBackColor = True
        '
        'rdbOption1
        '
        Me.rdbOption1.AutoSize = True
        Me.rdbOption1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.rdbOption1.Location = New System.Drawing.Point(6, 10)
        Me.rdbOption1.Name = "rdbOption1"
        Me.rdbOption1.Size = New System.Drawing.Size(41, 29)
        Me.rdbOption1.TabIndex = 0
        Me.rdbOption1.TabStop = True
        Me.rdbOption1.Text = "?"
        Me.rdbOption1.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(304, 276)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(87, 23)
        Me.btnSubmit.TabIndex = 12
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblSpeedDisplay
        '
        Me.lblSpeedDisplay.AutoSize = True
        Me.lblSpeedDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblSpeedDisplay.Location = New System.Drawing.Point(527, 28)
        Me.lblSpeedDisplay.Name = "lblSpeedDisplay"
        Me.lblSpeedDisplay.Size = New System.Drawing.Size(92, 25)
        Me.lblSpeedDisplay.TabIndex = 13
        Me.lblSpeedDisplay.Text = "Speed: 1"
        '
        'prbTimer
        '
        Me.prbTimer.BackColor = System.Drawing.Color.Navy
        Me.prbTimer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.prbTimer.Location = New System.Drawing.Point(0, -1)
        Me.prbTimer.Name = "prbTimer"
        Me.prbTimer.Size = New System.Drawing.Size(690, 23)
        Me.prbTimer.TabIndex = 14
        Me.prbTimer.Value = 100
        '
        'tmrQuestionAlarm
        '
        Me.tmrQuestionAlarm.Enabled = True
        Me.tmrQuestionAlarm.Interval = 200
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.BackColor = System.Drawing.Color.Maroon
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblTimer.Location = New System.Drawing.Point(312, 2)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(27, 20)
        Me.lblTimer.TabIndex = 15
        Me.lblTimer.Text = "10"
        '
        'lblGameOver
        '
        Me.lblGameOver.AutoSize = True
        Me.lblGameOver.BackColor = System.Drawing.Color.Black
        Me.lblGameOver.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!)
        Me.lblGameOver.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblGameOver.Location = New System.Drawing.Point(157, 197)
        Me.lblGameOver.Name = "lblGameOver"
        Me.lblGameOver.Size = New System.Drawing.Size(378, 76)
        Me.lblGameOver.TabIndex = 16
        Me.lblGameOver.Text = "Game Over"
        Me.lblGameOver.Visible = False
        '
        'prcBoost
        '
        Me.prcBoost.BackColor = System.Drawing.Color.Transparent
        Me.prcBoost.Image = CType(resources.GetObject("prcBoost.Image"), System.Drawing.Image)
        Me.prcBoost.Location = New System.Drawing.Point(119, 78)
        Me.prcBoost.Name = "prcBoost"
        Me.prcBoost.Size = New System.Drawing.Size(86, 73)
        Me.prcBoost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.prcBoost.TabIndex = 17
        Me.prcBoost.TabStop = False
        Me.prcBoost.Visible = False
        '
        'tmrBoostEnabled
        '
        '
        'tmrSpeedAccel
        '
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 28)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(76, 36)
        Me.btnBack.TabIndex = 18
        Me.btnBack.Text = "Back "
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmFractionGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(687, 396)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.prcBoost)
        Me.Controls.Add(Me.lblGameOver)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.prbTimer)
        Me.Controls.Add(Me.lblSpeedDisplay)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.grpQuestionHolder)
        Me.Controls.Add(Me.prcCar)
        Me.Controls.Add(Me.prcRoadSign5)
        Me.Controls.Add(Me.prcRoadSign4)
        Me.Controls.Add(Me.prcRoadSign1)
        Me.Controls.Add(Me.prcRoadSign3)
        Me.Controls.Add(Me.prcRoadSign2)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFractionGame"
        Me.Text = "Car Fraction Game"
        CType(Me.prcRoadSign3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prcRoadSign2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prcRoadSign4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prcRoadSign1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prcRoadSign5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prcCar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpQuestionHolder.ResumeLayout(False)
        Me.grpQuestionHolder.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.prcBoost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrSignSpeed As System.Windows.Forms.Timer
    Friend WithEvents prcRoadSign3 As System.Windows.Forms.PictureBox
    Friend WithEvents prcRoadSign2 As System.Windows.Forms.PictureBox
    Friend WithEvents prcRoadSign4 As System.Windows.Forms.PictureBox
    Friend WithEvents prcRoadSign1 As System.Windows.Forms.PictureBox
    Friend WithEvents prcRoadSign5 As System.Windows.Forms.PictureBox
    Friend WithEvents prcCar As System.Windows.Forms.PictureBox
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents grpQuestionHolder As System.Windows.Forms.GroupBox
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbOption2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbOption4 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbOption3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbOption1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents lblSpeedDisplay As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents prbTimer As System.Windows.Forms.ProgressBar
    Friend WithEvents tmrQuestionAlarm As System.Windows.Forms.Timer
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents lblGameOver As System.Windows.Forms.Label
    Friend WithEvents prcBoost As System.Windows.Forms.PictureBox
    Friend WithEvents tmrBoostEnabled As System.Windows.Forms.Timer
    Friend WithEvents tmrSpeedAccel As System.Windows.Forms.Timer
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
