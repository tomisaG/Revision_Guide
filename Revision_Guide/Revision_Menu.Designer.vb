<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Revision_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Revision_Menu))
        Me.Cmd_Next = New System.Windows.Forms.Button()
        Me.Cmd_Previous = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Lbl_Content = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Cmd_Next
        '
        Me.Cmd_Next.Location = New System.Drawing.Point(835, 432)
        Me.Cmd_Next.Name = "Cmd_Next"
        Me.Cmd_Next.Size = New System.Drawing.Size(106, 44)
        Me.Cmd_Next.TabIndex = 1
        Me.Cmd_Next.Text = "Next"
        Me.Cmd_Next.UseVisualStyleBackColor = True
        '
        'Cmd_Previous
        '
        Me.Cmd_Previous.Location = New System.Drawing.Point(12, 432)
        Me.Cmd_Previous.Name = "Cmd_Previous"
        Me.Cmd_Previous.Size = New System.Drawing.Size(109, 44)
        Me.Cmd_Previous.TabIndex = 2
        Me.Cmd_Previous.Text = "Previous"
        Me.Cmd_Previous.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(212, 12)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(579, 23)
        Me.ProgressBar1.TabIndex = 3
        '
        'Lbl_Content
        '
        Me.Lbl_Content.AutoSize = True
        Me.Lbl_Content.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Content.Image = CType(resources.GetObject("Lbl_Content.Image"), System.Drawing.Image)
        Me.Lbl_Content.Location = New System.Drawing.Point(103, 92)
        Me.Lbl_Content.Name = "Lbl_Content"
        Me.Lbl_Content.Size = New System.Drawing.Size(0, 18)
        Me.Lbl_Content.TabIndex = 4
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(23, 375)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(204, 13)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Structure and Components of a Processor"
        '
        'Revision_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(953, 488)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Lbl_Content)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Cmd_Previous)
        Me.Controls.Add(Me.Cmd_Next)
        Me.Name = "Revision_Menu"
        Me.Text = "Revision_Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cmd_Next As Button
    Friend WithEvents Cmd_Previous As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Lbl_Content As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
