﻿Public Class Start_Page
    Dim File As System.IO.StreamReader
    Private Sub Start_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Cmd_Signup.Click
        My.Forms.Menu_Page.Text = Now.ToString
        My.Forms.CreateUser.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Cmd_Login.Click
        My.Forms.Menu_Page.Text = Now.ToString
        My.Forms.Form1.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.Menu_Page.Text = Now.ToString
        My.Forms.Revision_Menu.Show()
    End Sub
End Class
