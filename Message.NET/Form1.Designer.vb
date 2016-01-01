<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Messenger
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
        Me.ChatTextBox = New System.Windows.Forms.RichTextBox()
        Me.SendButton = New System.Windows.Forms.Button()
        Me.InputField = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ChatTextBox
        '
        Me.ChatTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChatTextBox.Location = New System.Drawing.Point(12, 12)
        Me.ChatTextBox.Name = "ChatTextBox"
        Me.ChatTextBox.ReadOnly = True
        Me.ChatTextBox.Size = New System.Drawing.Size(371, 231)
        Me.ChatTextBox.TabIndex = 1
        Me.ChatTextBox.Text = ""
        '
        'SendButton
        '
        Me.SendButton.Enabled = False
        Me.SendButton.Location = New System.Drawing.Point(308, 260)
        Me.SendButton.Name = "SendButton"
        Me.SendButton.Size = New System.Drawing.Size(75, 23)
        Me.SendButton.TabIndex = 2
        Me.SendButton.Text = "Send"
        '
        'InputField
        '
        Me.InputField.Location = New System.Drawing.Point(12, 262)
        Me.InputField.Name = "InputField"
        Me.InputField.Size = New System.Drawing.Size(290, 20)
        Me.InputField.TabIndex = 3
        '
        'Messenger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 297)
        Me.Controls.Add(Me.InputField)
        Me.Controls.Add(Me.SendButton)
        Me.Controls.Add(Me.ChatTextBox)
        Me.Name = "Messenger"
        Me.Text = "Messenger.NET"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ChatTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents SendButton As System.Windows.Forms.Button
    Friend WithEvents InputField As System.Windows.Forms.TextBox

End Class
