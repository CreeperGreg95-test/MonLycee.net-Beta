Public Class Actualités
    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Me.Close()
        TimelineAdmin.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Panel8.Visible = True
    End Sub

    Private Sub Actualités_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel8.Visible = False
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Actu1.Show()
        Me.Hide()
    End Sub
End Class