Imports System.ComponentModel
Imports System.Net.Sockets

Public Class Game
    Public Sub New(ByVal isHost As Boolean, Optional ByVal ip As String = Nothing)

        ' This call is required by the designer.
        InitializeComponent()
        AddHandler MessageReceiver.DoWork, AddressOf MessageReceiver_DoWork
        CheckForIllegalCrossThreadCalls = False
    
        If (isHost) Then

            WinnerAnnounce.Text = "Play"
            server = New TcpListener(System.Net.IPAddress.Any, 5732)
            server.Start()
            Sock = server.AcceptSocket()

        Else

            Try
                WinnerAnnounce.Text = "Play"
                Client = New TcpClient(ip, 5732)
                Sock = Client.Client


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub MessageReceiver_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)



        ReceiveMove()

        CheckState()



    End Sub

    Dim UserPlay As Integer = 0
    Dim CpuPlay As Integer = 0
    Dim result As Integer

    Dim PlayerScore As Integer = 0
    Dim CpuScore As Integer = 0
    Private Sock As Socket
    Private MessageReceiver As BackgroundWorker = New BackgroundWorker()
    Private server As TcpListener = Nothing
    Private Client As TcpClient

    Private Function CheckState() As Boolean
        result = UserPlay - CpuPlay
        Console.WriteLine("Result: " & result)

        If UserPlay = CpuPlay Then
            WinnerAnnounce.Text = "TIE"
            FreezeBoard()
            Threading.Thread.Sleep(3000)
            WinnerAnnounce.Text = "Play"
            UnFreezeBoard()

            UserPicBox.Image = Nothing
            CpuPicBox.Image = Nothing

            Return True
        ElseIf result = -1 Or result = 2 Then
            WinnerAnnounce.Text = "OPPONENT WINS"


            CpuScore = CpuScore + 1
            CpuScoreLabel.Text = "OPPONENT SCORE: " & CpuScore.ToString()
            FreezeBoard()
            Threading.Thread.Sleep(3000)
            WinnerAnnounce.Text = "Play"
            UnFreezeBoard()

            UserPicBox.Image = Nothing
            CpuPicBox.Image = Nothing
            Return True
        ElseIf result = -2 Or result = 1 Then
            WinnerAnnounce.Text = "PLAYER WINS"


            PlayerScore = PlayerScore + 1
            PlayerScoreLabel.Text = "PLAYER SCORE: " & PlayerScore.ToString()
            FreezeBoard()
            Threading.Thread.Sleep(3000)
            WinnerAnnounce.Text = "Play"
            UnFreezeBoard()

            UserPicBox.Image = Nothing
            CpuPicBox.Image = Nothing
            Return True
        ElseIf result = 1 Then
            WinnerAnnounce.Text = "PLAYER WINS"


            PlayerScore = PlayerScore + 1
            PlayerScoreLabel.Text = "PLAYER SCORE: " & PlayerScore.ToString()
            FreezeBoard()
            Threading.Thread.Sleep(3000)
            WinnerAnnounce.Text = "Play"
            UnFreezeBoard()

            UserPicBox.Image = Nothing
            CpuPicBox.Image = Nothing
            Return True
        End If


        Return False

    End Function



    Private Sub FreezeBoard()
        PaperBtn.Enabled = False
        RockBtn.Enabled = False
        ScissorsBtn.Enabled = False
    End Sub

    Private Sub UnFreezeBoard()
        PaperBtn.Enabled = True
        RockBtn.Enabled = True
        ScissorsBtn.Enabled = True
    End Sub

    Private Sub ReceiveMove()

        Dim buffer As Byte() = New Byte(0) {}
        Sock.Receive(buffer)

        If buffer(0) = 1 Then
            CpuPlay = 1
            CpuPicBox.Image = Global.RPS.My.Resources.Resources.rock
        End If

        If buffer(0) = 2 Then
            CpuPlay = 2
            CpuPicBox.Image = Global.RPS.My.Resources.Resources.paper
        End If

        If buffer(0) = 3 Then
            CpuPlay = 3
            CpuPicBox.Image = Global.RPS.My.Resources.Resources.scissors
        End If



    End Sub

    Private Sub PaperBtn_Click(sender As Object, e As EventArgs) Handles PaperBtn.Click

        Try
            Dim num As Byte() = {2}
            Sock.Send(num)
            UserPlay = 2
            UserPicBox.Image = Global.RPS.My.Resources.Resources.paper
            MessageReceiver.RunWorkerAsync()
        Catch ex As Exception

        End Try
        FreezeBoard()
    End Sub

    Private Sub RockBtn_Click(sender As Object, e As EventArgs) Handles RockBtn.Click

        Try
            Dim num As Byte() = {1}
            Sock.Send(num)
            UserPlay = 1
            UserPicBox.Image = Global.RPS.My.Resources.Resources.rock
            MessageReceiver.RunWorkerAsync()
        Catch ex As Exception

        End Try
        FreezeBoard()

    End Sub

    Private Sub ScissorsBtn_Click(sender As Object, e As EventArgs) Handles ScissorsBtn.Click

        Try
            Dim num As Byte() = {3}
            Sock.Send(num)
            UserPlay = 3
            UserPicBox.Image = Global.RPS.My.Resources.Resources.scissors
            MessageReceiver.RunWorkerAsync()
        Catch ex As Exception

        End Try
        FreezeBoard()
    End Sub

    Private Sub Game_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MessageReceiver.WorkerSupportsCancellation = True
        MessageReceiver.CancelAsync()

        If (server IsNot Nothing) Then
            server.Stop()
        End If
    End Sub
End Class