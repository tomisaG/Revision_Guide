<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateUser))
        Me.Create_Account = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_CreateUsername = New System.Windows.Forms.TextBox()
        Me.ttx_CreatePassword = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Create_Account
        '
        Me.Create_Account.Location = New System.Drawing.Point(341, 254)
        Me.Create_Account.Name = "Create_Account"
        Me.Create_Account.Size = New System.Drawing.Size(98, 45)
        Me.Create_Account.TabIndex = 0
        Me.Create_Account.Text = "Create_Account"
        Me.Create_Account.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(106, 254)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(98, 45)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password:"
        '
        'txt_CreateUsername
        '
        Me.txt_CreateUsername.Location = New System.Drawing.Point(183, 75)
        Me.txt_CreateUsername.Name = "txt_CreateUsername"
        Me.txt_CreateUsername.Size = New System.Drawing.Size(200, 20)
        Me.txt_CreateUsername.TabIndex = 5
        '
        'ttx_CreatePassword
        '
        Me.ttx_CreatePassword.Location = New System.Drawing.Point(183, 130)
        Me.ttx_CreatePassword.Name = "ttx_CreatePassword"
        Me.ttx_CreatePassword.Size = New System.Drawing.Size(200, 20)
        Me.ttx_CreatePassword.TabIndex = 6
        '
        'CreateUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(570, 376)
        Me.Controls.Add(Me.ttx_CreatePassword)
        Me.Controls.Add(Me.txt_CreateUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Create_Account)
        Me.Name = "CreateUser"
        Me.Text = "CreateUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Create_Account As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_CreateUsername As TextBox
    Friend WithEvents ttx_CreatePassword As TextBox
End Class
