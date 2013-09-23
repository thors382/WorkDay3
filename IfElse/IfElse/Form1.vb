Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click

        Dim num1, num2 As Double

        If IsNumeric(txtFirstNum.Text) And IsNumeric(txtSecondNum.Text) Then
            num1 = CDbl(txtFirstNum.Text)
            num2 = CDbl(txtSecondNum.Text)

            If (num1 > num2) Then
                txtResult.Text = "The Larger Number is " & num1
            ElseIf (num1 < num2) Then
                txtResult.Text = "The Larger Number is " & num2
            Else
                txtResult.Text = "They are Equal"
            End If
        Else
            MessageBox.Show("Error: please type a number")
        End If


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
