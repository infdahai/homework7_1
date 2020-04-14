<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.res_label = New System.Windows.Forms.Label()
        Me.way_box = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'res_label
        '
        Me.res_label.AutoSize = True
        Me.res_label.Location = New System.Drawing.Point(128, 71)
        Me.res_label.Name = "res_label"
        Me.res_label.Size = New System.Drawing.Size(0, 17)
        Me.res_label.TabIndex = 17
        '
        'way_box
        '
        Me.way_box.AutoSize = True
        Me.way_box.Location = New System.Drawing.Point(128, 40)
        Me.way_box.Name = "way_box"
        Me.way_box.Size = New System.Drawing.Size(0, 17)
        Me.way_box.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "way:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "result:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(382, 108)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 43)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 163)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.res_label)
        Me.Controls.Add(Me.way_box)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents res_label As Label
    Friend WithEvents way_box As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
