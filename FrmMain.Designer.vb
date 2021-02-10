<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LblQuestion = New System.Windows.Forms.Label()
        Me.BtnTrue = New System.Windows.Forms.Button()
        Me.BtnFalse = New System.Windows.Forms.Button()
        Me.LblScore = New System.Windows.Forms.Label()
        Me.LblQCounter = New System.Windows.Forms.Label()
        Me.LblPoints = New System.Windows.Forms.Label()
        Me.LblScr1 = New System.Windows.Forms.Label()
        Me.PicResult = New System.Windows.Forms.PictureBox()
        Me.Btn_Next = New System.Windows.Forms.Button()
        Me.ProgMain = New System.Windows.Forms.ProgressBar()
        CType(Me.PicResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblQuestion
        '
        Me.LblQuestion.AutoSize = True
        Me.LblQuestion.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQuestion.Location = New System.Drawing.Point(12, 190)
        Me.LblQuestion.Name = "LblQuestion"
        Me.LblQuestion.Size = New System.Drawing.Size(269, 27)
        Me.LblQuestion.TabIndex = 0
        Me.LblQuestion.Text = "Question Will Appear Here"
        Me.LblQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LblQuestion.UseMnemonic = False
        '
        'BtnTrue
        '
        Me.BtnTrue.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTrue.Location = New System.Drawing.Point(12, 435)
        Me.BtnTrue.Name = "BtnTrue"
        Me.BtnTrue.Size = New System.Drawing.Size(145, 66)
        Me.BtnTrue.TabIndex = 1
        Me.BtnTrue.Text = "True"
        Me.BtnTrue.UseVisualStyleBackColor = True
        '
        'BtnFalse
        '
        Me.BtnFalse.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.BtnFalse.Location = New System.Drawing.Point(679, 435)
        Me.BtnFalse.Name = "BtnFalse"
        Me.BtnFalse.Size = New System.Drawing.Size(145, 66)
        Me.BtnFalse.TabIndex = 2
        Me.BtnFalse.Text = "False"
        Me.BtnFalse.UseVisualStyleBackColor = True
        '
        'LblScore
        '
        Me.LblScore.AutoSize = True
        Me.LblScore.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblScore.Location = New System.Drawing.Point(12, 9)
        Me.LblScore.Name = "LblScore"
        Me.LblScore.Size = New System.Drawing.Size(75, 27)
        Me.LblScore.TabIndex = 3
        Me.LblScore.Text = "Score:"
        Me.LblScore.UseMnemonic = False
        '
        'LblQCounter
        '
        Me.LblQCounter.AutoSize = True
        Me.LblQCounter.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQCounter.Location = New System.Drawing.Point(645, 524)
        Me.LblQCounter.Name = "LblQCounter"
        Me.LblQCounter.Size = New System.Drawing.Size(160, 27)
        Me.LblQCounter.TabIndex = 4
        Me.LblQCounter.Text = "Question 0 of 0"
        Me.LblQCounter.UseMnemonic = False
        '
        'LblPoints
        '
        Me.LblPoints.AutoSize = True
        Me.LblPoints.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LblPoints.Location = New System.Drawing.Point(238, 455)
        Me.LblPoints.Name = "LblPoints"
        Me.LblPoints.Size = New System.Drawing.Size(332, 27)
        Me.LblPoints.TabIndex = 5
        Me.LblPoints.Text = "This question is worth 000 points"
        '
        'LblScr1
        '
        Me.LblScr1.AutoSize = True
        Me.LblScr1.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblScr1.Location = New System.Drawing.Point(12, 36)
        Me.LblScr1.Name = "LblScr1"
        Me.LblScr1.Size = New System.Drawing.Size(75, 27)
        Me.LblScr1.TabIndex = 3
        Me.LblScr1.Text = "Score:"
        Me.LblScr1.UseMnemonic = False
        '
        'PicResult
        '
        Me.PicResult.Location = New System.Drawing.Point(497, 12)
        Me.PicResult.Name = "PicResult"
        Me.PicResult.Size = New System.Drawing.Size(327, 164)
        Me.PicResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicResult.TabIndex = 6
        Me.PicResult.TabStop = False
        '
        'Btn_Next
        '
        Me.Btn_Next.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Next.Location = New System.Drawing.Point(356, 416)
        Me.Btn_Next.Name = "Btn_Next"
        Me.Btn_Next.Size = New System.Drawing.Size(82, 35)
        Me.Btn_Next.TabIndex = 7
        Me.Btn_Next.Text = "Next"
        Me.Btn_Next.UseVisualStyleBackColor = True
        '
        'ProgMain
        '
        Me.ProgMain.Location = New System.Drawing.Point(12, 528)
        Me.ProgMain.Name = "ProgMain"
        Me.ProgMain.Size = New System.Drawing.Size(627, 23)
        Me.ProgMain.TabIndex = 8
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 563)
        Me.Controls.Add(Me.ProgMain)
        Me.Controls.Add(Me.Btn_Next)
        Me.Controls.Add(Me.PicResult)
        Me.Controls.Add(Me.LblPoints)
        Me.Controls.Add(Me.LblQCounter)
        Me.Controls.Add(Me.LblScr1)
        Me.Controls.Add(Me.LblScore)
        Me.Controls.Add(Me.BtnFalse)
        Me.Controls.Add(Me.BtnTrue)
        Me.Controls.Add(Me.LblQuestion)
        Me.MaximumSize = New System.Drawing.Size(850, 600)
        Me.MinimumSize = New System.Drawing.Size(850, 600)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quiz Game"
        CType(Me.PicResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblQuestion As Label
    Friend WithEvents BtnTrue As Button
    Friend WithEvents BtnFalse As Button
    Friend WithEvents LblScore As Label
    Friend WithEvents LblQCounter As Label
    Friend WithEvents LblPoints As Label
    Friend WithEvents LblScr1 As Label
    Friend WithEvents PicResult As PictureBox
    Friend WithEvents Btn_Next As Button
    Friend WithEvents ProgMain As ProgressBar
End Class
