<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Start_btn = New System.Windows.Forms.Button()
        Me.Volume_btn = New System.Windows.Forms.Button()
        Me.Rules_btn = New System.Windows.Forms.Button()
        Me.Exit_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Start_btn
        '
        Me.Start_btn.Location = New System.Drawing.Point(345, 116)
        Me.Start_btn.Name = "Start_btn"
        Me.Start_btn.Size = New System.Drawing.Size(75, 23)
        Me.Start_btn.TabIndex = 0
        Me.Start_btn.Text = "Start"
        Me.Start_btn.UseVisualStyleBackColor = True
        '
        'Volume_btn
        '
        Me.Volume_btn.Location = New System.Drawing.Point(345, 184)
        Me.Volume_btn.Name = "Volume_btn"
        Me.Volume_btn.Size = New System.Drawing.Size(75, 23)
        Me.Volume_btn.TabIndex = 1
        Me.Volume_btn.Text = "Volume"
        Me.Volume_btn.UseVisualStyleBackColor = True
        '
        'Rules_btn
        '
        Me.Rules_btn.Location = New System.Drawing.Point(345, 247)
        Me.Rules_btn.Name = "Rules_btn"
        Me.Rules_btn.Size = New System.Drawing.Size(75, 23)
        Me.Rules_btn.TabIndex = 2
        Me.Rules_btn.Text = "Rules"
        Me.Rules_btn.UseVisualStyleBackColor = True
        '
        'Exit_btn
        '
        Me.Exit_btn.Location = New System.Drawing.Point(345, 301)
        Me.Exit_btn.Name = "Exit_btn"
        Me.Exit_btn.Size = New System.Drawing.Size(75, 23)
        Me.Exit_btn.TabIndex = 3
        Me.Exit_btn.Text = "Exit"
        Me.Exit_btn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Exit_btn)
        Me.Controls.Add(Me.Rules_btn)
        Me.Controls.Add(Me.Volume_btn)
        Me.Controls.Add(Me.Start_btn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Start_btn As Button
    Friend WithEvents Volume_btn As Button
    Friend WithEvents Rules_btn As Button
    Friend WithEvents Exit_btn As Button
End Class
