Public Class Wait

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Visible = True Then
            Me.BringToFront()
        End If
    End Sub
End Class