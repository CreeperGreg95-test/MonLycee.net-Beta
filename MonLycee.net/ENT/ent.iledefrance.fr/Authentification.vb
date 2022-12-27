Public Class Authentification
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("La visibilité ne marche pas. Faites attention à ne pas enregistrer en direct cette page !")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "gregory.aubert-maguero" And TextBox2.Text = "amg" Then
            Me.Close()
            TimelineG.Show()
        Else
            Panel2.Show()
        End If
        If TextBox1.Text = "killian.lucbert" And TextBox2.Text = "Klucbert952007*" Then
            Me.Close()
            TimelineK.Show()
        Else
            Panel2.Show()
        End If
        If TextBox1.Text = "admin.ent" And TextBox2.Text = "admin" Then
            Me.Close()
            TimelineAdmin.Show()
        Else
            Panel2.Show()
        End If
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            Panel2.Show()
        End If
    End Sub

    Private Sub Authentification_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class