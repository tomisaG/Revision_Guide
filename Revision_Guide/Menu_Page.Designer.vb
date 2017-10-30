<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Page
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Page))
        Me.SFofP = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SFofP
        '
        Me.SFofP.Location = New System.Drawing.Point(116, 87)
        Me.SFofP.Name = "SFofP"
        Me.SFofP.Size = New System.Drawing.Size(108, 58)
        Me.SFofP.TabIndex = 0
        Me.SFofP.Text = "Structure and Function of Processor"
        Me.SFofP.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(116, 394)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 58)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Input, Output and Storage"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(116, 291)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 58)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Operating Systems"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(116, 189)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 58)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Types of Processor"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(277, 233)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(108, 58)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "System Software"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Courier New", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(161, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(362, 35)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "Computer Science Topics"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(39, 35)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(109, 23)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Back to Menu"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Menu_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(729, 504)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.SFofP)
        Me.Name = "Menu_Page"
        Me.Text = "Menu_Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SFofP As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button6 As Button
End Class
