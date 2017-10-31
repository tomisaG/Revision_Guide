Imports Microsoft.VisualBasic.FileIO
Public Class CreateUser
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Forms.CreateUser.Text = Now.ToString
        My.Forms.Menu_Page.Show()
    End Sub
    Private Sub CreateCSVfile(ByVal _LogincsvCSVPath As String, ByVal _txt_CreateUsername As String, ByVal _ttx_CreatePassword As String)
        Try
            Dim stLine As String = ""
            Dim objWriter As IO.StreamWriter = IO.File.AppendText(_LogincsvCSVPath)
            If IO.File.Exists(_LogincsvCSVPath) Then
                objWriter.Write(_txt_CreateUsername & ",")
                objWriter.Write(_ttx_CreatePassword & ",")

            End If
            objWriter.Close()
            ClearTextbox()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Create_Account_Click(sender As Object, e As EventArgs) Handles Create_Account.Click
        CreateCSVfile(Application.StartupPath & "\" & "Userinfo.csv", txt_CreateUsername.Text.ToString(), ttx_CreatePassword.Text.ToString())
    End Sub
    Private Sub ClearTextbox()
        ttx_CreatePassword.Text = ""
        txt_CreateUsername.Text = ""
    End Sub
    Private Sub txt_CreateUsername_TextChanged(sender As Object, e As EventArgs) Handles txt_CreateUsername.TextChanged

    End Sub

    Private Sub CreateUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class