Imports System.Windows.Forms

Public Class ChordEdit
    Public Chord As Chord
    Private ClickRegion As Rectangle
    Private RhythmEntry As Integer

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ClickRegion = New Rectangle(42, 59, 141, 316)

        ' Add any initialization after the InitializeComponent() call.
        AddHandler pnlChordPic.Paint, AddressOf Me.OnPanelPaint
        AddHandler pnlChordPic.Click, AddressOf Me.OnPanelClick
        AddHandler pnlRhythm.Paint, AddressOf Me.OnRhythmPanelPaint
        AddHandler pnlRhythm.Click, AddressOf Me.OnRhythmPanelClick
    End Sub

    Private Sub OnPanelPaint(sender As Object, e As PaintEventArgs)
        If Not Chord Is Nothing Then
            Chord.Draw(pnlChordPic)
        End If
    End Sub

    Private Sub OnRhythmPanelPaint(sender As Object, e As PaintEventArgs)
        If Not Chord Is Nothing Then
            Chord.DrawRhythm(pnlRhythm, RhythmEntry)
        End If
    End Sub

    Public Sub OnRhythmPanelClick(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim iPelsPerBeat As Integer = pnlRhythm.Width / (Chord.Strums.Count - 1)
        RhythmEntry = (e.X + (iPelsPerBeat / 2)) / iPelsPerBeat
        pnlRhythm.Invalidate()
    End Sub

    Public Sub OnPanelClick(ByVal sender As Object, ByVal e As MouseEventArgs)
        txtBase.Visible = False
        txtTitle.Visible = False
        If txtTitle.Bounds.Contains(e.Location) Then
            txtTitle.Text = Chord.Name
            txtTitle.Visible = True
            txtTitle.Focus()
            txtTitle.SelectAll()
        End If
        If txtBase.Bounds.Contains(e.Location) Then
            txtBase.Text = Chord.Base.ToString
            txtBase.Visible = True
            txtBase.Focus()
            txtBase.SelectAll()
        End If
        If ClickRegion.Contains(e.Location) Then
            Dim StringIndex As Integer
            StringIndex = (e.X - 50) / 25
            If e.Y < 75 Then
                Chord.Strings(StringIndex).NextOpenState()
            Else
                Dim FretIndex As Integer
                FretIndex = ((e.Y - 55) * 7) / 300
                If FretIndex <= 6 Then
                    If e.Button = Windows.Forms.MouseButtons.Left Then
                        Chord.Strings(StringIndex).Frets(FretIndex) = (Chord.Strings(StringIndex).Frets(FretIndex) + 1) Mod 6
                    ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
                        Chord.Strings(StringIndex).Frets(FretIndex) = (Chord.Strings(StringIndex).Frets(FretIndex) - 1)
                        If Chord.Strings(StringIndex).Frets(FretIndex) < 0 Then
                            Chord.Strings(StringIndex).Frets(FretIndex) = 5
                        End If
                    End If
                    If Chord.Strings(StringIndex).HasAnyFret() Then
                        Chord.Strings(StringIndex).OpenState = GUString.OpenStringState.Blank
                    Else
                        Chord.Strings(StringIndex).OpenState = GUString.OpenStringState.Open
                    End If
                End If
            End If
        End If
        pnlChordPic.Invalidate()
    End Sub

    Private Sub txtTitle_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTitle.KeyDown
        If e.KeyCode = Keys.Return Then
            txtTitle.Visible = False
            pnlChordPic.Invalidate()
        End If
    End Sub

    Private Sub txtTitle_Leave(sender As Object, e As EventArgs) Handles txtTitle.Leave
        txtTitle.Visible = False
        pnlChordPic.Invalidate()
    End Sub

    Private Sub txtTitle_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles txtTitle.PreviewKeyDown
        If e.KeyCode = Keys.Return Then
            e.IsInputKey = True
        End If
    End Sub

    Private Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged
        Chord.Name = txtTitle.Text
    End Sub

    Private Sub txtBase_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBase.KeyDown
        If e.KeyCode = Keys.Return Then
            txtBase.Visible = False
            pnlChordPic.Invalidate()
        End If
    End Sub

    Private Sub txtBase_Leave(sender As Object, e As EventArgs) Handles txtBase.Leave
        txtBase.Visible = False
        pnlChordPic.Invalidate()
    End Sub

    Private Sub txtBase_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles txtBase.PreviewKeyDown
        If e.KeyCode = Keys.Return Then
            e.IsInputKey = True
        End If
    End Sub

    Private Sub txtBase_TextChanged(sender As Object, e As EventArgs) Handles txtBase.TextChanged
        Chord.Base = Val(txtBase.Text)
    End Sub

    Private Sub rbDuration24_CheckedChanged(sender As Object, e As EventArgs) Handles rbDuration24.CheckedChanged
        If rbDuration24.Checked Then
            Chord.Strums(RhythmEntry).Duration = 24
            pnlRhythm.Invalidate()
        End If
    End Sub

    Private Sub rbDuration16_CheckedChanged(sender As Object, e As EventArgs) Handles rbDuration16.CheckedChanged
        If rbDuration16.Checked Then
            Chord.Strums(RhythmEntry).Duration = 16
            pnlRhythm.Invalidate()
        End If
    End Sub

    Private Sub rbDuration12_CheckedChanged(sender As Object, e As EventArgs) Handles rbDuration12.CheckedChanged
        If rbDuration12.Checked Then
            Chord.Strums(RhythmEntry).Duration = 12
            pnlRhythm.Invalidate()
        End If
    End Sub

    Private Sub rbDuration8_CheckedChanged(sender As Object, e As EventArgs) Handles rbDuration8.CheckedChanged
        If rbDuration8.Checked Then
            Chord.Strums(RhythmEntry).Duration = 8
            pnlRhythm.Invalidate()
        End If
    End Sub

    Private Sub rbDuration6_CheckedChanged(sender As Object, e As EventArgs) Handles rbDuration6.CheckedChanged
        If rbDuration6.Checked Then
            Chord.Strums(RhythmEntry).Duration = 6
            pnlRhythm.Invalidate()
        End If
    End Sub

    Private Sub rbDuration4_CheckedChanged(sender As Object, e As EventArgs) Handles rbDuration4.CheckedChanged
        If rbDuration4.Checked Then
            Chord.Strums(RhythmEntry).Duration = 4
            pnlRhythm.Invalidate()
        End If
    End Sub

    Private Sub rbDuration3_CheckedChanged(sender As Object, e As EventArgs) Handles rbDuration3.CheckedChanged
        If rbDuration3.Checked Then
            Chord.Strums(RhythmEntry).Duration = 3
            pnlRhythm.Invalidate()
        End If
    End Sub

    Private Sub rbDuration2_CheckedChanged(sender As Object, e As EventArgs) Handles rbDuration2.CheckedChanged
        If rbDuration2.Checked Then
            Chord.Strums(RhythmEntry).Duration = 2
            pnlRhythm.Invalidate()
        End If
    End Sub

    Private Sub rbDuration1_CheckedChanged(sender As Object, e As EventArgs) Handles rbDuration1.CheckedChanged
        If rbDuration1.Checked Then
            Chord.Strums(RhythmEntry).Duration = 1
            pnlRhythm.Invalidate()
        End If
    End Sub

    Private Sub ChordEdit_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        RhythmEntry = 1
        SyncButtonsWithRhythmEntry()
        Chord.ResizeForStrums(pnlRhythm)
    End Sub

    Private Sub SyncButtonsWithRhythmEntry()
        If Not IsNothing(Chord) Then
            If RhythmEntry = 1 Then
                bLeft.Enabled = False
            Else
                bLeft.Enabled = True
            End If
            If RhythmEntry = (Chord.Strums.Count - 1) Then
                bRight.Enabled = False
            Else
                bRight.Enabled = True
            End If
            If Chord.Strums.Count <= 2 Then
                bDeleteStrum.Enabled = False
            Else
                bDeleteStrum.Enabled = True
            End If
            Select Case Chord.Strums(RhythmEntry).Duration
                Case 1
                    rbDuration1.Checked = True
                Case 2
                    rbDuration2.Checked = True
                Case 3
                    rbDuration3.Checked = True
                Case 4
                    rbDuration4.Checked = True
                Case 6
                    rbDuration6.Checked = True
                Case 8
                    rbDuration8.Checked = True
                Case 12
                    rbDuration12.Checked = True
                Case 24
                    rbDuration24.Checked = True
                Case Else
                    rbDuration16.Checked = True
            End Select
            Select Case Chord.Strums(RhythmEntry).StrumDirection
                Case Strum.Direction.StrumDown
                    rbStrokeDown.Checked = True
                Case Strum.Direction.StrumUp
                    rbStrokeUp.Checked = True
                Case Else
                    rbStrumNone.Checked = True
            End Select
        End If
    End Sub

    Private Sub bAddStrum_Click(sender As Object, e As EventArgs) Handles bAddStrum.Click
        Chord.AddStrum(4)
        Chord.ResizeForStrums(pnlRhythm)
        RhythmEntry = (Chord.Strums.Count - 1)
        pnlRhythm.Invalidate()
        SyncButtonsWithRhythmEntry()
    End Sub

    Private Sub bLeft_Click(sender As Object, e As EventArgs) Handles bLeft.Click
        If RhythmEntry > 1 Then
            RhythmEntry = RhythmEntry - 1
            pnlRhythm.Invalidate()
            SyncButtonsWithRhythmEntry()
        End If
    End Sub

    Private Sub bRight_Click(sender As Object, e As EventArgs) Handles bRight.Click
        If RhythmEntry < (Chord.Strums.Count - 1) Then
            RhythmEntry = RhythmEntry + 1
            pnlRhythm.Invalidate()
            SyncButtonsWithRhythmEntry()
        End If
    End Sub

    Private Sub bDeleteStrum_Click(sender As Object, e As EventArgs) Handles bDeleteStrum.Click
        Chord.RemoveStrum(RhythmEntry)
        Chord.ResizeForStrums(pnlRhythm)
        If RhythmEntry > (Chord.Strums.Count - 1) Then
            RhythmEntry = RhythmEntry - 1
        End If
        pnlRhythm.Invalidate()
        SyncButtonsWithRhythmEntry()
    End Sub

    Private Sub rbStrumNone_CheckedChanged(sender As Object, e As EventArgs) Handles rbStrumNone.CheckedChanged
        If rbStrumNone.Checked Then
            Chord.Strums(RhythmEntry).StrumDirection = Strum.Direction.StrumUnspecified
            pnlRhythm.Invalidate()
        End If
    End Sub

    Private Sub rbStrokeDown_CheckedChanged(sender As Object, e As EventArgs) Handles rbStrokeDown.CheckedChanged
        If rbStrokeDown.Checked Then
            Chord.Strums(RhythmEntry).StrumDirection = Strum.Direction.StrumDown
            pnlRhythm.Invalidate()
        End If
    End Sub

    Private Sub rbStrokeUp_CheckedChanged(sender As Object, e As EventArgs) Handles rbStrokeUp.CheckedChanged
        If rbStrokeUp.Checked Then
            Chord.Strums(RhythmEntry).StrumDirection = Strum.Direction.StrumUp
            pnlRhythm.Invalidate()
        End If
    End Sub
End Class
