<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Exit_rules_btn = New System.Windows.Forms.Button()
        Me.HowToPlay_btn = New System.Windows.Forms.Button()
        Me.Controls_btn = New System.Windows.Forms.Button()
        Me.HardwareRequired_btn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Exit_rules_btn
        '
        Me.Exit_rules_btn.BackColor = System.Drawing.Color.Transparent
        Me.Exit_rules_btn.Font = New System.Drawing.Font("SimSun", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Exit_rules_btn.ForeColor = System.Drawing.Color.Red
        Me.Exit_rules_btn.Location = New System.Drawing.Point(-4, -1)
        Me.Exit_rules_btn.Name = "Exit_rules_btn"
        Me.Exit_rules_btn.Size = New System.Drawing.Size(67, 72)
        Me.Exit_rules_btn.TabIndex = 0
        Me.Exit_rules_btn.Text = "X"
        Me.Exit_rules_btn.UseVisualStyleBackColor = False
        '
        'HowToPlay_btn
        '
        Me.HowToPlay_btn.Location = New System.Drawing.Point(146, 109)
        Me.HowToPlay_btn.Name = "HowToPlay_btn"
        Me.HowToPlay_btn.Size = New System.Drawing.Size(87, 23)
        Me.HowToPlay_btn.TabIndex = 1
        Me.HowToPlay_btn.Text = "How To Play"
        Me.HowToPlay_btn.UseVisualStyleBackColor = True
        '
        'Controls_btn
        '
        Me.Controls_btn.Location = New System.Drawing.Point(345, 109)
        Me.Controls_btn.Name = "Controls_btn"
        Me.Controls_btn.Size = New System.Drawing.Size(87, 23)
        Me.Controls_btn.TabIndex = 2
        Me.Controls_btn.Text = "Controls"
        Me.Controls_btn.UseVisualStyleBackColor = True
        '
        'HardwareRequired_btn
        '
        Me.HardwareRequired_btn.Location = New System.Drawing.Point(500, 109)
        Me.HardwareRequired_btn.Name = "HardwareRequired_btn"
        Me.HardwareRequired_btn.Size = New System.Drawing.Size(87, 23)
        Me.HardwareRequired_btn.TabIndex = 3
        Me.HardwareRequired_btn.Text = "Hardware Required"
        Me.HardwareRequired_btn.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(483, 161)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(130, 23)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(322, 161)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(130, 23)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(129, 161)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(130, 23)
        Me.TextBox3.TabIndex = 6
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.HardwareRequired_btn)
        Me.Controls.Add(Me.Controls_btn)
        Me.Controls.Add(Me.HowToPlay_btn)
        Me.Controls.Add(Me.Exit_rules_btn)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Exit_rules_btn As Button
    Friend WithEvents HowToPlay_btn As Button
    Friend WithEvents Controls_btn As Button
    Friend WithEvents HardwareRequired_btn As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
