Imports System.Windows.Forms

Public Class PlaybackSettings

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        My.Settings.Save()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        My.Settings.Reload()
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Voice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Voice.SelectedIndexChanged
        My.Settings.PlayVoice = Voice.SelectedItem
    End Sub

    Private Sub PlaybackSettings_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        On Error Resume Next
        tbVolume.Value = My.Settings.PlayVolume
        tbChordSpeed.Value = My.Settings.PlayInterval
        tbStrumSpeed.Value = My.Settings.StrumInterval
        Voice.SelectedIndex = Voice.FindString(My.Settings.PlayVoice)
        txtVolume.Text = tbVolume.Value
        txtChordSpeed.Text = tbChordSpeed.Value
        txtStrumSpeed.Text = tbStrumSpeed.Value
    End Sub

    Private Sub txtVolume_TextChanged(sender As Object, e As EventArgs) Handles txtVolume.TextChanged
        Try
            tbVolume.Value = Val(txtVolume.Text)
        Catch
            '
        End Try

    End Sub

    Private Sub txtChordSpeed_TextChanged(sender As Object, e As EventArgs) Handles txtChordSpeed.TextChanged
        Try
            tbChordSpeed.Value = Val(txtChordSpeed.Text)
            Select Case tbChordSpeed.Value
                Case 1 To 19
                    lblSpeed.Text = "Larghissimo"
                Case 20 To 40
                    lblSpeed.Text = "Grave"
                Case 40 To 45
                    lblSpeed.Text = "Lento"
                Case 45 To 50
                    lblSpeed.Text = "Largo"
                Case 50 To 55
                    lblSpeed.Text = "Larghetto"
                Case 55 To 65
                    lblSpeed.Text = "Adagio"
                Case 65 To 69
                    lblSpeed.Text = "Adagietto"
                Case 69 To 72
                    lblSpeed.Text = "Andante moderato"
                Case 73 To 77
                    lblSpeed.Text = "Andante"
                Case 78 To 83
                    lblSpeed.Text = "Andantino"
                Case 83 To 85
                    lblSpeed.Text = "Marcia moderato"
                Case 86 To 97
                    lblSpeed.Text = "Moderato"
                Case 98 To 109
                    lblSpeed.Text = "Allegretto"
                Case 109 To 132
                    lblSpeed.Text = "Allegro "
                Case 132 To 140
                    lblSpeed.Text = "Vivace"
                Case 140 To 150
                    lblSpeed.Text = "Vivacissimo"
                Case 150 To 167
                    lblSpeed.Text = "Allegrissimo"
                Case 168 To 177
                    lblSpeed.Text = "Presto"
                Case Else
                    lblSpeed.Text = "Prestissimo"
            End Select
        Catch
            '
        End Try

    End Sub

    Private Sub txtStrumSpeed_TextChanged(sender As Object, e As EventArgs) Handles txtStrumSpeed.TextChanged
        Try
            tbStrumSpeed.Value = Val(txtStrumSpeed.Text)
        Catch
            '
        End Try

    End Sub

    Private Sub tbVolume_Scroll(sender As Object, e As EventArgs) Handles tbVolume.Scroll
        My.Settings.PlayVolume = tbVolume.Value
        txtVolume.Text = tbVolume.Value
    End Sub

    Private Sub tbChordSpeed_Scroll(sender As Object, e As EventArgs) Handles tbChordSpeed.Scroll
        My.Settings.PlayInterval = tbChordSpeed.Value
        txtChordSpeed.Text = tbChordSpeed.Value
    End Sub

    Private Sub tbStrumSpeed_Scroll(sender As Object, e As EventArgs) Handles tbStrumSpeed.Scroll
        My.Settings.StrumInterval = tbStrumSpeed.Value
        txtStrumSpeed.Text = tbStrumSpeed.Value
    End Sub
End Class
