Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Const TRAINEE As Single = 8.5
        Const WORKER As Single = 12.25
        Const MANAGER As Single = 32.5
        Dim sngOverTime As Single
        Dim sngPay As Single = 0
        Dim intHours As Integer

        intHours = Val(txtHours.Text)
        sngOverTime = (40 * 8.5) + (intHours - 40) * 8.5 * 1.5

        If (radTrainee.Checked = True) Then
            sngPay = intHours * TRAINEE
        ElseIf (radWorker.Checked = True) Then
            sngPay = intHours * WORKER
        ElseIf (radManager.Checked = True) Then
            sngPay = intHours * MANAGER
        End If

        If (radTrainee.Checked = True) And (intHours > 40) Then
            sngOverTime = (40 * TRAINEE) + (intHours - 40) * TRAINEE * 1.5
            sngPay = sngOverTime
        ElseIf (radWorker.Checked = True) And (intHours > 40) Then
            sngOverTime = (40 * WORKER) + (intHours - 40) * WORKER * 1.5
            sngPay = sngOverTime
        ElseIf (radManager.Checked = True) And (intHours > 40) Then
            sngOverTime = (40 * MANAGER) + (intHours - 40) * MANAGER * 1.5
            sngPay = sngOverTime
        End If


        lblPay.Text = "Your Pay: $" & sngPay

    End Sub
End Class
