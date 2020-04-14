Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles button_yes.Click
        Dim score As Integer = Val(grade_text.Text)
        If score <> 0 Then
            Dim window_form1 = New Form1
            window_form1.TextBox1.Text = CStr(score)
            window_form1.ShowDialog()
        End If
    End Sub

    Private Sub button_no_Click(sender As Object, e As EventArgs) Handles button_no.Click
        Application.Exit()
    End Sub

End Class