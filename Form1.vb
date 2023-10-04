Public Class Form1
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim height, weight, bmi As Single
        height = Val(txtHeight.Text)
        weight = Val(txtWeight.Text)
        bmi = ((weight) / (height ^ 2)).ToString("F2")

        txtBMI.Text = bmi
        If bmi > 26 Then
            txtComment.Text = "Your are overweight"
        ElseIf bmi >= 18 And bmi <= 26 Then
            txtComment.Text = "You are normal"
        Else
            txtComment.Text = "Your are underweight"
        End If
    End Sub

End Class
