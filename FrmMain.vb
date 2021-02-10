Imports System.Media
Imports Microsoft.VisualBasic.Devices

Public Class FrmMain
    Dim Current_Index As Integer = -1
    Dim Total_Questions As Integer = 1
    Dim Total_Points As Integer = 0
    Dim Current_Score As Integer = 0
    Dim Final_Score As Integer
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        If My.Application.CommandLineArgs.Count < 0 Then
            Debug.WriteLine("Opening External File")
            MsgBox(My.Application.CommandLineArgs(0).ToString + " ready!", MsgBoxStyle.OkOnly, "Notice")
        Else
            MsgBox("Defaulting to test quiz", MsgBoxStyle.OkOnly, "Notice")
            Main.Create_Main()

        End If


        Total_Questions = Main.AQuiz.Questions.Count - 1
        next_question()
        ProgMain.Maximum = Total_Questions

    End Sub

    Private Sub BtnFalse_Click(sender As Object, e As EventArgs) Handles BtnFalse.Click
        Check_Answer(False)
    End Sub

    Private Sub BtnTrue_Click(sender As Object, e As EventArgs) Handles BtnTrue.Click
        Check_Answer(True)
    End Sub

    Public Function set_label_question_counter(Current As Integer, Total As Integer) As String
        Dim Begin As String = "Question "
        Dim aof As String = "of"

        Dim Final As String = Begin + " " + (Current + 1).ToString + " " + aof + " " + (Total + 1).ToString
        Return Final
    End Function
    Public Function next_question()
        Btn_Next.Enabled = False
        BtnFalse.Enabled = True
        BtnTrue.Enabled = True
        'Debug.WriteLine(Current_Index)
        'Debug.WriteLine(Total_Questions)
        Debug.WriteLine(Current_Index.ToString + " of " + Total_Questions.ToString)

        If Current_Index = Total_Questions Then

            End_Quiz(Final_Score)
            Return "Final"
        Else
            Current_Index += 1
        End If
        'Current_Index = (Current_Index + 1) Mod Total_Questions
        Set_Question_Text()
        LblQCounter.Text = set_label_question_counter(Current_Index, Total_Questions)
    End Function
    Public Function Set_Question_Text()
        LblQuestion.Text = Main.AQuiz.Questions.ElementAt(Current_Index).Text
        ProgMain.Value = Current_Index
        LblPoints.Text = Update_Point_Label()
    End Function

    Public Function Check_Answer(Choice As Boolean)
        Dim Correct_answer = Main.AQuiz.Questions.ElementAt(Current_Index).Answer
        If Correct_answer = Choice Then
            Total_Points += Main.AQuiz.Questions.ElementAt(Current_Index).Points
            Current_Score += Main.AQuiz.Questions.ElementAt(Current_Index).Points
            PicResult.Image = My.Resources.up
        Else
            Total_Points += Main.AQuiz.Questions.ElementAt(Current_Index).Points
            PicResult.Image = My.Resources.down
        End If
        Update_Score()
        If Current_Index = Total_Questions Then
            Btn_Next.Text = "End Quiz"
        End If
        BtnFalse.Enabled = False
        BtnTrue.Enabled = False
        Btn_Next.Enabled = True

    End Function
    Public Function Update_Score()
        Dim Score = ((Current_Score / Total_Points) * 100)
        Dim Round_Score = Math.Round(Score, 2)
        Final_Score = Round_Score
        LblScore.Text = "Score: " + Round_Score.ToString + "%"
        LblScr1.Text = Current_Score.ToString + "/" + Total_Points.ToString
    End Function
    Public Function End_Quiz(Grade)
        BtnFalse.Enabled = False
        BtnTrue.Enabled = False

        Dim Letter_Gade = ""
        Dim bgrade = Math.Round(Grade)
        Select Case bgrade
            Case 0 To 59
                Letter_Gade = "F"
                My.Computer.Audio.Play(My.Resources.fail, AudioPlayMode.Background)
            Case 60 To 69
                Letter_Gade = "D"
                My.Computer.Audio.Play(My.Resources.fail, AudioPlayMode.Background)
            Case 70 To 79
                Letter_Gade = "C"
                My.Computer.Audio.Play(My.Resources.try_again, AudioPlayMode.Background)
            Case 80 To 89
                Letter_Gade = "B"
                My.Computer.Audio.Play(My.Resources.try_again, AudioPlayMode.Background)
            Case 90 To 100
                Letter_Gade = "A"
                My.Computer.Audio.Play(My.Resources.fanfare, AudioPlayMode.Background)
                PicResult.Image = My.Resources.fireworks
            Case Else
                Letter_Gade = "Invalid"
                SystemSounds.Exclamation.Play()
        End Select



        LblQuestion.Text = "Quiz Complete! Your final grade is " + Letter_Gade + "(" + bgrade.ToString + "%)"



    End Function
    Function Update_Point_Label() As String
        Dim Out = "This Question is worth " + Main.AQuiz.Questions.ElementAt(Current_Index).Points.ToString + " points."
        Return Out
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Next.Click
        PicResult.Image = Nothing
        next_question()
    End Sub
End Class
