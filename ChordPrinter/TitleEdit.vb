Imports System.Windows.Forms

Public Class TitleEdit

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Title = txtTitleEdit.Text
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub TitleEdit_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtTitleEdit.Text = Title
        txtTitleEdit.Focus()
    End Sub
End Class
