Public Class Logout
    Private Sub Logout_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value <= ProgressBar1.Maximum Then ProgressBar1.Value += 1
        If ProgressBar1.Value = 1 Then
            MessageBox.Show("Déconnexion...", "")
        End If
        If ProgressBar1.Value = 98 Then
            Label1.Visible = True
        End If
        If ProgressBar1.Value = 100 Then
            MenuPage.Close()
        End If
    End Sub
End Class