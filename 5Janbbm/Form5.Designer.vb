<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SignUpUsername = New System.Windows.Forms.TextBox()
        Me.LogInUsername = New System.Windows.Forms.TextBox()
        Me.SignUpPassword = New System.Windows.Forms.TextBox()
        Me.LogInPassword = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(368, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Game over"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(173, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Sign Up"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(500, 78)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Log in"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SignUpUsername
        '
        Me.SignUpUsername.Location = New System.Drawing.Point(155, 135)
        Me.SignUpUsername.Name = "SignUpUsername"
        Me.SignUpUsername.Size = New System.Drawing.Size(129, 23)
        Me.SignUpUsername.TabIndex = 3
        Me.SignUpUsername.Text = "Username"
        '
        'LogInUsername
        '
        Me.LogInUsername.Location = New System.Drawing.Point(475, 135)
        Me.LogInUsername.Name = "LogInUsername"
        Me.LogInUsername.Size = New System.Drawing.Size(129, 23)
        Me.LogInUsername.TabIndex = 4
        Me.LogInUsername.Text = "Username"
        '
        'SignUpPassword
        '
        Me.SignUpPassword.Location = New System.Drawing.Point(155, 198)
        Me.SignUpPassword.Name = "SignUpPassword"
        Me.SignUpPassword.Size = New System.Drawing.Size(129, 23)
        Me.SignUpPassword.TabIndex = 5
        Me.SignUpPassword.Text = "Password"
        '
        'LogInPassword
        '
        Me.LogInPassword.Location = New System.Drawing.Point(475, 198)
        Me.LogInPassword.Name = "LogInPassword"
        Me.LogInPassword.Size = New System.Drawing.Size(129, 23)
        Me.LogInPassword.TabIndex = 6
        Me.LogInPassword.Text = "Password"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._5Janbbm.My.Resources.Resources.Basketball_background_gameover
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LogInPassword)
        Me.Controls.Add(Me.SignUpPassword)
        Me.Controls.Add(Me.LogInUsername)
        Me.Controls.Add(Me.SignUpUsername)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents SignUpUsername As TextBox
    Friend WithEvents LogInUsername As TextBox
    Friend WithEvents SignUpPassword As TextBox
    Friend WithEvents LogInPassword As TextBox
End Class
