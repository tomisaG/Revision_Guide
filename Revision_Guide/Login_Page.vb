Imports Microsoft.VisualBasic.FileIO
Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Cmd_Login_Click(sender As Object, e As EventArgs) Handles Cmd_Login.Click
        Dim username As String = ""
        Dim password As String = ""
        Dim loginline As String = ""
        Dim searchstring As String = Console.ReadLine
        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("C:\file-home1\TomOye161$\Computing\Year 2\Revision Guide\Revision_Guide\Revision_Guide\bin\LoginPage.csv")
            Do Until EOF(1)
                loginline = LineInput(1)
                Dim Items() As String = Split(loginline, ",")
                If searchstring = Items(0) Then
                    username = Items(0)
                    password = Items(1)
                    Exit Do
                End If

                If txt_Username.Text = searchstring.ToString And txt_password.Text = searchstring.ToString Then
                    Menu_Page.Show()
                Else
                    MsgBox("Sorry, Username or Password is ", MsgBoxStyle.OkOnly, "Invalid")
                End If
            Loop
        End Using
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txt_Username_TextChanged(sender As Object, e As EventArgs) Handles txt_Username.TextChanged

    End Sub
End Class