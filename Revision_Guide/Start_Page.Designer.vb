<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start_Page
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Start_Page))
        Me.Cmd_Signup = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Cmd_Login = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Cmd_Signup
        '
        Me.Cmd_Signup.Location = New System.Drawing.Point(422, 202)
        Me.Cmd_Signup.Name = "Cmd_Signup"
        Me.Cmd_Signup.Size = New System.Drawing.Size(125, 47)
        Me.Cmd_Signup.TabIndex = 0
        Me.Cmd_Signup.Text = "Signup"
        Me.Cmd_Signup.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Courier New", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(80, 75)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(457, 38)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "Computer Science Revision"
        '
        'Cmd_Login
        '
        Me.Cmd_Login.Location = New System.Drawing.Point(80, 202)
        Me.Cmd_Login.Name = "Cmd_Login"
        Me.Cmd_Login.Size = New System.Drawing.Size(117, 47)
        Me.Cmd_Login.TabIndex = 2
        Me.Cmd_Login.Text = "Login"
        Me.Cmd_Login.UseVisualStyleBackColor = True
        '
        'Start_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(600, 351)
        Me.Controls.Add(Me.Cmd_Login)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Cmd_Signup)
        Me.Name = "Start_Page"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cmd_Signup As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Cmd_Login As Button
End Class
