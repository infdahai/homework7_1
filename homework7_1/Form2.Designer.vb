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
        Me.components = New System.ComponentModel.Container()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grade_text = New System.Windows.Forms.TextBox()
        Me.button_yes = New System.Windows.Forms.Button()
        Me.button_no = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Please input your grade."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "grade:"
        '
        'grade_text
        '
        Me.grade_text.Location = New System.Drawing.Point(127, 77)
        Me.grade_text.Name = "grade_text"
        Me.grade_text.Size = New System.Drawing.Size(96, 22)
        Me.grade_text.TabIndex = 7
        '
        'button_yes
        '
        Me.button_yes.Location = New System.Drawing.Point(328, 44)
        Me.button_yes.Name = "button_yes"
        Me.button_yes.Size = New System.Drawing.Size(57, 27)
        Me.button_yes.TabIndex = 9
        Me.button_yes.Text = "ok"
        Me.button_yes.UseVisualStyleBackColor = True
        '
        'button_no
        '
        Me.button_no.Location = New System.Drawing.Point(328, 77)
        Me.button_no.Name = "button_no"
        Me.button_no.Size = New System.Drawing.Size(57, 27)
        Me.button_no.TabIndex = 10
        Me.button_no.Text = "exit"
        Me.button_no.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 131)
        Me.Controls.Add(Me.button_no)
        Me.Controls.Add(Me.button_yes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grade_text)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "homework7-1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents grade_text As TextBox
    Friend WithEvents button_yes As Button
    Friend WithEvents button_no As Button
End Class
