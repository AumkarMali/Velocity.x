<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIntro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIntro))
        Me.tmrUpdateTopSpeed = New System.Windows.Forms.Timer(Me.components)
        Me.btnStartGame = New System.Windows.Forms.Button()
        Me.lblTopSpeed = New System.Windows.Forms.Label()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tmrUpdateTopSpeed
        '
        '
        'btnStartGame
        '
        Me.btnStartGame.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStartGame.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartGame.Location = New System.Drawing.Point(12, 251)
        Me.btnStartGame.Name = "btnStartGame"
        Me.btnStartGame.Size = New System.Drawing.Size(125, 62)
        Me.btnStartGame.TabIndex = 0
        Me.btnStartGame.Text = " Start Game"
        Me.btnStartGame.UseVisualStyleBackColor = False
        '
        'lblTopSpeed
        '
        Me.lblTopSpeed.AutoSize = True
        Me.lblTopSpeed.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTopSpeed.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopSpeed.Location = New System.Drawing.Point(12, 9)
        Me.lblTopSpeed.Name = "lblTopSpeed"
        Me.lblTopSpeed.Size = New System.Drawing.Size(0, 28)
        Me.lblTopSpeed.TabIndex = 1
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSettings.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSettings.Location = New System.Drawing.Point(659, 9)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(75, 47)
        Me.btnSettings.TabIndex = 2
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'frmIntro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(746, 355)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.lblTopSpeed)
        Me.Controls.Add(Me.btnStartGame)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmIntro"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrUpdateTopSpeed As System.Windows.Forms.Timer
    Friend WithEvents btnStartGame As System.Windows.Forms.Button
    Friend WithEvents lblTopSpeed As System.Windows.Forms.Label
    Friend WithEvents btnSettings As System.Windows.Forms.Button

End Class
