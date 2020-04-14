Public Class Form1
    Shared res_str As String
    Shared way_str As String
    '   Private Shared window_form3 As New Form3()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub button_if_Click(sender As Object, e As EventArgs) Handles button_if.Click
        Dim score As Integer = Val(TextBox1.Text)
        Dim yr_sc As String = " your score " & score
        res_str = yr_sc
        '   Dim res_str As String = yr_sc
        If (score > 100) Then
            res_str += " is out of upper_bound. " + vbCrLf + "please input number between [0,100]."
        ElseIf (score >= 90) Then
            res_str += " is excellent between [90, 100]."
        ElseIf (score >= 80) Then
            res_str += " is good between [80, 89]."
        ElseIf (score >= 60) Then
            res_str += " is pass between [60, 79]."
        ElseIf (score >= 0) Then
            res_str += " is failed between [0, 59]."
        Else
            res_str += " is out of lower_bound." + vbCrLf + " please input number between [0,100]."
        End If
        way_str = "IF"
        button_event({way_str, res_str}, e)
    End Sub

    Private Sub button_select_Click(sender As Object, e As EventArgs) Handles button_select.Click
        Dim score As Integer = Val(TextBox1.Text)
        Dim yr_sc As String = " your score " & score
        '    Dim res_str As String = yr_sc
        res_str = yr_sc
        Select Case score
            Case 90 To 100
                res_str += " is excellent between [90, 100]."
            Case 80 To 89
                res_str += " is good between [80, 89]."
            Case 60 To 79
                res_str += " is pass between [60, 79]."
            Case 0 To 59
                res_str += " is failed between [0, 59]."
            Case Else
                res_str += " is out of bounds. " + vbCrLf + " please input number between [0,100]."
        End Select
        way_str = "SELECT"
        button_event({way_str, res_str}, e)
    End Sub

    Private Sub button_event(sender As Object(), e As EventArgs)
        Dim window_form3 As New Form3()
        window_form3.way_box.Text = sender(0)
        window_form3.res_label.Text = sender(1)
        window_form3.ShowDialog()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub



    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub way_box_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
