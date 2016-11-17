Imports ChordPrinter.Barline

Public Class BarlineEdit
    Public Chord As Barline

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub rbSimple_CheckedChanged(sender As Object, e As EventArgs) Handles rbSimple.CheckedChanged
        Chord.Type = Barline.BarlineType.Simple
    End Sub

    Private Sub rbSection_CheckedChanged(sender As Object, e As EventArgs) Handles rbSection.CheckedChanged
        Chord.Type = Barline.BarlineType.Section
    End Sub

    Private Sub rbStart_CheckedChanged(sender As Object, e As EventArgs) Handles rbStart.CheckedChanged
        Chord.Type = Barline.BarlineType.Start
    End Sub

    Private Sub rbStartDots_CheckedChanged(sender As Object, e As EventArgs) Handles rbStartDots.CheckedChanged
        Chord.Type = Barline.BarlineType.StartDots
    End Sub

    Private Sub rbFinal_CheckedChanged(sender As Object, e As EventArgs) Handles rbFinal.CheckedChanged
        Chord.Type = Barline.BarlineType.Final
    End Sub

    Private Sub rbFinalDots_CheckedChanged(sender As Object, e As EventArgs) Handles rbFinalDots.CheckedChanged
        Chord.Type = Barline.BarlineType.FinalDots
    End Sub

    Private Sub BarlineEdit_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Select Case Chord.Type
            Case BarlineType.Section
                rbSection.Checked = True
            Case BarlineType.Start
                rbStart.Checked = True
            Case BarlineType.StartDots
                rbStartDots.Checked = True
            Case BarlineType.Final
                rbFinal.Checked = True
            Case BarlineType.FinalDots
                rbFinalDots.Checked = True
            Case Else
                rbSimple.Checked = True
        End Select

    End Sub
End Class