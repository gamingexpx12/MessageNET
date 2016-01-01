Public Class FirstTimeForm
    Public nickname As String = Nothing
    Private Sub OKButton1_Click(sender As Object, e As EventArgs) Handles OKButton1.Click
        nickname = TextBox1.Text
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.TextLength > 0 Then 'If there is text
            OKButton1.Enabled = True
        Else 'No text
            OKButton1.Enabled = False
        End If
    End Sub
End Class