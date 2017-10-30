Public Class Menu_Page
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SFofP.Click
        My.Forms.Revision_Menu.Text = Now.ToString
        My.Forms.Revision_Menu.Show()
    End Sub
End Class