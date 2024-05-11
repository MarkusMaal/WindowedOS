Public Class SecondDisp
    Private Sub SecondDisp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SecondDisp_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            Me.BackgroundImage = Desktop.BackgroundImage
            Me.BackgroundImageLayout = BackgroundImageLayout.Zoom
            Me.BackColor = Desktop.appBg.BackColor
        End If
    End Sub
End Class