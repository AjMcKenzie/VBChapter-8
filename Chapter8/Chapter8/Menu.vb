Public Class Menu

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Box = New SeatingChart
        Box.Show()
    End Sub

    Private Sub btnLottery_Click(sender As Object, e As EventArgs) Handles btnLottery.Click
        Dim Box = New Lottery
        Box.Show()
    End Sub

    Private Sub btnFriends_Click(sender As Object, e As EventArgs) Handles btnFriends.Click
        Dim Box = New FriendsList
        Box.Show()
    End Sub

    Private Sub btnFriends2_Click(sender As Object, e As EventArgs) Handles btnFriends2.Click
        Dim Box = New FriendsListTwo
        Box.Show()
    End Sub
End Class