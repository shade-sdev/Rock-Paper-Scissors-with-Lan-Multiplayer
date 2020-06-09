Public Class RPS

    Dim UserPlay As Integer = 0
    Dim CpuPlay As Integer = 0
    Dim result As Integer

    Dim PlayerScore As Integer = 0
    Dim CpuScore As Integer = 0

    Shared random As New Random()
    Private Sub RPS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub GetWinner()

        result = UserPlay - CpuPlay
        Console.WriteLine("Result: " & result)

        If UserPlay = CpuPlay Then
            WinnerAnnounce.Text = "TIE"



        ElseIf result = -1 Or result = 2 Then
            WinnerAnnounce.Text = "CPU WINS"


            CpuScore = CpuScore + 1
        ElseIf result = -2 Or result = 1 Then
            WinnerAnnounce.Text = "PLAYER WINS"


            PlayerScore = PlayerScore + 1
        ElseIf result = 1 Then
            WinnerAnnounce.Text = "PLAYER WINS"


            PlayerScore = PlayerScore + 1
        End If

    End Sub

    Private Sub GetCpuPlay()
        CpuPlay = random.Next(1, 4)
        Console.WriteLine("CpuPlay: " & CpuPlay)
    End Sub



    Private Sub AssignPictureBox()

        If CpuPlay = 1 Then
            CpuPicBox.Image = Global.RPS.My.Resources.Resources.rock
        ElseIf CpuPlay = 2 Then
            CpuPicBox.Image = Global.RPS.My.Resources.Resources.paper
        ElseIf CpuPlay = 3 Then
            CpuPicBox.Image = Global.RPS.My.Resources.Resources.scissors

        End If

        If UserPlay = 1 Then
            UserPicBox.Image = Global.RPS.My.Resources.Resources.rock
        ElseIf UserPlay = 2 Then
            UserPicBox.Image = Global.RPS.My.Resources.Resources.paper
        ElseIf UserPlay = 3 Then
            UserPicBox.Image = Global.RPS.My.Resources.Resources.scissors

        End If


    End Sub

    Private Sub PaperBtn_Click(sender As Object, e As EventArgs) Handles PaperBtn.Click
        UserPlay = 2
        GetCpuPlay()
        AssignPictureBox()
        GetWinner()
        AssignLabelScore()
    End Sub

    Private Sub RockBtn_Click(sender As Object, e As EventArgs) Handles RockBtn.Click
        UserPlay = 1
        GetCpuPlay()
        AssignPictureBox()
        GetWinner()
        AssignLabelScore()
    End Sub

    Private Sub ScissorsBtn_Click(sender As Object, e As EventArgs) Handles ScissorsBtn.Click
        UserPlay = 3
        GetCpuPlay()
        AssignPictureBox()
        GetWinner()
        AssignLabelScore()
    End Sub



    Public Sub AssignLabelScore()
        PlayerScoreLabel.Text = "PLAYER SCORE: " & PlayerScore.ToString()
        CpuScoreLabel.Text = "CPU SCORE: " & CpuScore.ToString()
    End Sub


End Class
