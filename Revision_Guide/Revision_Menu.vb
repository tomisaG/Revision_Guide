Public Class Revision_Menu
    Dim File As System.IO.StreamReader
    Private Sub Previous()

    End Sub
    Private Sub Revision_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cmd_Previous.Enabled = False
        Previous()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Cmd_Previous.Click
        Previous()
    End Sub

    Private Sub Cmd_Next_Click(sender As Object, e As EventArgs) Handles Cmd_Next.Click
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://www.teach-ict.com/2016/AS_Computing/OCR_H046/OCR_H046_home.html")

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        File = My.Computer.FileSystem.OpenTextFileReader("Questions.txt")
        If Not File.EndOfStream Then
            Label2.Text += File.ReadLine
        End If
        File.Close()
    End Sub
End Class