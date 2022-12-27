Public Class TimelineAdmin
    Private Sub TimelineAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(PictureBox1, "Accueil")
        ToolTip1.SetToolTip(PictureBox3, "Mon compte")
        ToolTip1.SetToolTip(PictureBox5, "Mon compte")
        ToolTip1.SetToolTip(PictureBox6, "Déconnexion")
        ToolTip1.SetToolTip(PictureBox7, "Aide en ligne")
        ToolTip1.SetToolTip(PictureBox8, "Mail")
        ToolTip1.SetToolTip(PictureBox9, "Mes applis")
        ToolTip1.SetToolTip(PictureBox10, "Communauté")
        ToolTip1.SetToolTip(PictureBox11, "Accueil")
        Panel6.Visible = False
        Panel8.Visible = False
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Hide()
        Actualités.Show()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Me.Hide()
        Me.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Panel6.Visible = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Actu1.Show()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Panel8.Visible = True
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Close()
        Logout.Show()
    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Class