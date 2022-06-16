<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.btnResetScore = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblhowToplay = New System.Windows.Forms.Label()
        Me.rtbHowToPlay = New System.Windows.Forms.RichTextBox()
        Me.lblCredits = New System.Windows.Forms.Label()
        Me.rtbCredits = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'btnResetScore
        '
        Me.btnResetScore.Location = New System.Drawing.Point(24, 21)
        Me.btnResetScore.Name = "btnResetScore"
        Me.btnResetScore.Size = New System.Drawing.Size(120, 81)
        Me.btnResetScore.TabIndex = 0
        Me.btnResetScore.Text = "Reset High Score"
        Me.btnResetScore.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(477, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 28)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblhowToplay
        '
        Me.lblhowToplay.AutoSize = True
        Me.lblhowToplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblhowToplay.Location = New System.Drawing.Point(355, 76)
        Me.lblhowToplay.Name = "lblhowToplay"
        Me.lblhowToplay.Size = New System.Drawing.Size(129, 26)
        Me.lblhowToplay.TabIndex = 2
        Me.lblhowToplay.Text = "How to Play"
        '
        'rtbHowToPlay
        '
        Me.rtbHowToPlay.BackColor = System.Drawing.Color.Silver
        Me.rtbHowToPlay.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbHowToPlay.Location = New System.Drawing.Point(360, 119)
        Me.rtbHowToPlay.Name = "rtbHowToPlay"
        Me.rtbHowToPlay.Size = New System.Drawing.Size(192, 199)
        Me.rtbHowToPlay.TabIndex = 3
        Me.rtbHowToPlay.Text = resources.GetString("rtbHowToPlay.Text")
        '
        'lblCredits
        '
        Me.lblCredits.AutoSize = True
        Me.lblCredits.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblCredits.Location = New System.Drawing.Point(30, 119)
        Me.lblCredits.Name = "lblCredits"
        Me.lblCredits.Size = New System.Drawing.Size(68, 24)
        Me.lblCredits.TabIndex = 4
        Me.lblCredits.Text = "Credits"
        '
        'rtbCredits
        '
        Me.rtbCredits.BackColor = System.Drawing.Color.Silver
        Me.rtbCredits.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbCredits.Location = New System.Drawing.Point(34, 146)
        Me.rtbCredits.Name = "rtbCredits"
        Me.rtbCredits.Size = New System.Drawing.Size(138, 154)
        Me.rtbCredits.TabIndex = 5
        Me.rtbCredits.Text = "Developed by Aumkar Mali" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Animation " & Global.Microsoft.VisualBasic.ChrW(10) & "Design" & Global.Microsoft.VisualBasic.ChrW(10) & "Mechanics " & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Created by Aumkar Mali" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "P" & _
    "roject Manager: A. Simler"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(564, 358)
        Me.Controls.Add(Me.rtbCredits)
        Me.Controls.Add(Me.lblCredits)
        Me.Controls.Add(Me.rtbHowToPlay)
        Me.Controls.Add(Me.lblhowToplay)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnResetScore)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSettings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnResetScore As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblhowToplay As System.Windows.Forms.Label
    Friend WithEvents rtbHowToPlay As System.Windows.Forms.RichTextBox
    Friend WithEvents lblCredits As System.Windows.Forms.Label
    Friend WithEvents rtbCredits As System.Windows.Forms.RichTextBox
End Class
