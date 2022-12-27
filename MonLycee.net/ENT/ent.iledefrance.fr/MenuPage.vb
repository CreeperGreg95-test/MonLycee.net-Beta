Public Class MenuPage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Authentification.Show()
    End Sub

    Private Sub MenuPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("L'application doit avoir au minimum de 100 Mo de RAM pour fonctionner correctement.", "Message temporaire", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub
End Class
