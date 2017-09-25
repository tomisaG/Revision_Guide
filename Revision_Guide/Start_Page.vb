Public Class Start_Page
    Private Sub Start_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.Menu_Page.Text = Now.ToString
        My.Forms.Menu_Page.Show()
    End Sub
End Class
