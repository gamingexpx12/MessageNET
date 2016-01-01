Imports System
Imports System.Net
Imports MessageNET.ChatModule


Public Class Messenger


    Private Sub Messenger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
#If CONFIG = "Debug" Then
        'My.Settings.Nickname = Nothing
        My.Settings.LastIP = Nothing
#End If
        Nickname()
    End Sub

    Private Sub Nickname()


        If Not String.IsNullOrEmpty(My.Settings.Nickname) Then Return 'If you already have a nickname

        If FirstTimeForm.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            My.Settings.Nickname = FirstTimeForm.nickname
            ChatTextBox.Text = My.Settings.Nickname
        End If


    End Sub
    Private Sub SendButton_Click(sender As Object, e As EventArgs) Handles SendButton.Click

    End Sub

    Private Sub InputField_TextChanged(sender As Object, e As EventArgs) Handles InputField.TextChanged
        If InputField.TextLength > 0 Then 'If there is text
            SendButton.Enabled = True 'Enable the send button
        Else 'If there is no text
            SendButton.Enabled = False 'Disable the send button
        End If
    End Sub
End Class
