Public Class Menu
    Private Sub HostBtn_Click(sender As Object, e As EventArgs) Handles HostBtn.Click
        Dim newGame As Game = New Game(True)
        Visible = False
        If (Not newGame.IsDisposed) Then
            newGame.ShowDialog()
            Visible = True
        End If
    End Sub

    Private Sub JoinBtn_Click(sender As Object, e As EventArgs) Handles JoinBtn.Click
        Dim newGame As Game = New Game(False, IPTextBox.Text)
        Visible = False

        If (Not newGame.IsDisposed) Then
            newGame.ShowDialog()
            Visible = True
        End If
    End Sub

    Private Sub IPTextBox_GotFocus(sender As Object, e As EventArgs) Handles IPTextBox.GotFocus
        IPTextBox.Text = String.Empty
    End Sub

    Private Sub PlayBtn_Click(sender As Object, e As EventArgs) Handles PlayBtn.Click
        Visible = False
        If (Not RPS.IsDisposed) Then
            RPS.ShowDialog()
            Visible = True
        End If
    End Sub
End Class