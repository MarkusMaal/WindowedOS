Public Class StartfieldEasterEgg

    Private Sub StartfieldEasterEgg_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        i.Location = New Point(i.Location.X + 1, i.Location.Y)
        ii.Location = New Point(ii.Location.X, ii.Location.Y - 1)
        iii.Location = New Point(iii.Location.X - 1, iii.Location.Y)
        iv.Location = New Point(iv.Location.X, iv.Location.Y + 1)

    End Sub
End Class