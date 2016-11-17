Public Class frmChordPrinter

    Dim DefaultPrintArea As RectangleF
    Dim MyDefaultMargin As Printing.Margins
    Dim PrintAreaPen As Pen

    Public Const PRINT_TYPE_CHORDSONLY As Integer = 0
    Public Const PRINT_TYPE_SUMMARYCHORDSANDRHYTHM As Integer = 1
    Public Const PRINT_TYPE_RHYTHMONLY As Integer = 2
    Public Const PRINT_TYPE_CHORDSANDRHYTHM As Integer = 3

    Public Sub ReorderChords(ChordID As String, After As String)
        Dim Ch As Chord

        If Chords.Contains(ChordID) And Chords.Contains(After) Then
            Ch = Chords(ChordID)
            Chords.Remove(ChordID)
            Chords.Add(Ch, ChordID, , After)
        End If

        'and resort
        AddToDisplayAndSort(Nothing)
        Chords(ChordID).DrawMainFormContainer.Focus()
        BodyArea.Invalidate(True)
        RhythmArea.Invalidate(True)
    End Sub

    Private Sub BodyArea_Click(sender As Object, e As EventArgs)
        FocusChord = ""
        BodyArea.Invalidate(True)
        RhythmArea.Invalidate(True)
    End Sub

    Private Sub BodyArea_Paint(sender As Object, e As PaintEventArgs)
        Dim X As Integer
        X = DefaultPrintArea.Width
        While X < BodyArea.Width
            e.Graphics.DrawLine(PrintAreaPen, X, 0, X, BodyArea.Height)
            X = X + DefaultPrintArea.Width
        End While
        X = DefaultPrintArea.Height
        If BodyArea.VerticalScroll.Enabled Then
            X = X - BodyArea.VerticalScroll.Value
        End If
        While X < BodyArea.DisplayRectangle.Height
            e.Graphics.DrawLine(PrintAreaPen, 0, X, BodyArea.Width, X)
            X = X + DefaultPrintArea.Height
        End While
    End Sub

    Private Sub Sizer_Scroll(sender As Object, e As EventArgs) Handles Sizer.Scroll
        txtSliderVal.Text = Sizer.Value

        For Each Ch As Chord In Chords
            Ch.Resize(Sizer.Value)
        Next
        BodyArea.Invalidate(True)
        RhythmArea.Invalidate(True)
        My.Settings.Sizer = Sizer.Value
        My.Settings.Save()
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        For Each Ch As Chord In Chords
            If Ch.DrawMainFormContainer.Focused Then
                Dim mee As New Windows.Forms.MouseEventArgs(Windows.Forms.MouseButtons.Left, 2, 0, 0, 0)
                Ch.DrawMainFormContainer.OnClickHandler(Me, mee)
                bChanged = False
                SetFilename()
            End If
        Next
    End Sub

    Private Sub BodyArea_Scroll(sender As Object, e As ScrollEventArgs)
        BodyArea.Invalidate(True)
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.ButtonClick

        Dim PrintDialog1 As New PrintDialog()
        PrintDialog1.Document = PrintDoc

        Dim result As DialogResult = PrintDialog1.ShowDialog()

        If (result = DialogResult.OK) Then
            CurrentPrintChord = 1
            PrintedChords.Clear()
            If My.Settings.PrintDefault = PRINT_TYPE_RHYTHMONLY Then
                CurrentPrintPass = 2
            Else
                CurrentPrintPass = 1
            End If
            Try
                PrintDoc.Print()
            Catch ex As Exception
                MsgBox("Sorry, Unable to print\n" & ex.Message)
            End Try
        End If
    End Sub

    Private Sub PrintDoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDoc.PrintPage
        Dim X As Integer, Y As Integer
        Dim Ch As Chord
        Dim Width As Integer, Height As Integer

        Dim G As Graphics
        G = e.Graphics

        X = DefaultPrintArea.Left
        Y = DefaultPrintArea.Top

        If CurrentPrintChord = 1 Then
            If (My.Settings.PrintDefault <> PRINT_TYPE_RHYTHMONLY And CurrentPrintPass = 1) _
                    Or My.Settings.PrintDefault = PRINT_TYPE_RHYTHMONLY Then
                Dim FF As New Font("Arial", 16)

                G.DrawString(Title, FF, Brushes.Black, (DefaultPrintArea.Width - G.MeasureString(Title, FF).Width) / 2, Y)
                Y = Y + G.MeasureString(Title, FF).Height + BodyArea.Margin.Vertical
            End If
        End If

        While CurrentPrintChord <= Chords.Count
            Ch = Chords(CurrentPrintChord)
            If My.Settings.PrintDefault = PRINT_TYPE_SUMMARYCHORDSANDRHYTHM _
                And CurrentPrintPass = 1 Then
                ' Skip over barlines and previously done chords
                If TypeOf Ch Is Barline Or PrintedChords.Contains(Ch.Name) Then
                    CurrentPrintChord = CurrentPrintChord + 1
                    If CurrentPrintChord > Chords.Count Then
                        CurrentPrintChord = 1
                        CurrentPrintPass = 2
                        X = DefaultPrintArea.Left
                        Y = Y + Height + BodyArea.Margin.Vertical
                        If (Y + Height) > DefaultPrintArea.Height Then
                            e.HasMorePages = True
                            Exit While
                        End If
                    End If
                    Continue While
                End If
                PrintedChords.Add(Ch.Name, Ch.Name)
            End If

            If TypeOf Ch Is Barline Then
                Width = Math.Max(Sizer.Value / 10, 15)
                If CurrentPrintPass = 1 Then
                    Height = 2 * Sizer.Value
                Else
                    Height = Sizer.Value / 2
                End If
            Else
                If CurrentPrintPass = 1 Then
                    Width = Sizer.Value
                    Height = 2 * Sizer.Value
                Else
                    Width = ((Sizer.Value * (Ch.Strums.Count - 1)) / 6) + 4
                    Height = Sizer.Value / 2
                End If
            End If
            If CurrentPrintPass = 1 Then
                Ch.Draw(G, X, Y, Width, Height, False)
            Else
                Ch.DrawRhythm(G, X, Y, Width, Height, False)
            End If
            CurrentPrintChord = CurrentPrintChord + 1
            If CurrentPrintChord <= Chords.Count Then
                X = X + Width + BodyArea.Margin.Horizontal
                If X > DefaultPrintArea.Width Then
                    X = DefaultPrintArea.Left
                    Y = Y + Height + BodyArea.Margin.Vertical
                    If (Y + Height) > DefaultPrintArea.Height Then
                        e.HasMorePages = True
                        Exit While
                    End If
                End If
            Else
                If CurrentPrintPass = 1 And _
                        (My.Settings.PrintDefault = PRINT_TYPE_CHORDSANDRHYTHM _
                         Or My.Settings.PrintDefault = PRINT_TYPE_SUMMARYCHORDSANDRHYTHM) Then
                    CurrentPrintChord = 1
                    CurrentPrintPass = 2
                    X = DefaultPrintArea.Left
                    Y = Y + Height + BodyArea.Margin.Vertical
                    If (Y + Height) > DefaultPrintArea.Height Then
                        e.HasMorePages = True
                        Exit While
                    End If
                End If
            End If
        End While
    End Sub

    Private Sub frmChordPrinter_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        PrintAreaPen.Dispose()
    End Sub

    Private Sub frmChordPrinter_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Set up some controls
        DefaultPrintArea = PrintDoc.PrinterSettings.DefaultPageSettings.PrintableArea
        MyDefaultMargin = PrintDoc.PrinterSettings.DefaultPageSettings.Margins
        PrintAreaPen = New Pen(Brushes.Black)
        PrintAreaPen.DashStyle = Drawing2D.DashStyle.Dash
        Sizer.Value = My.Settings.Sizer
        txtSliderVal.Text = Sizer.Value
        bChanged = False

        ' See if we were launched as a default app for a file
        If My.Application.CommandLineArgs.Count > 0 Then
            ' Assume 1st arg is a filename
            Filename = System.IO.Path.GetFileName(My.Application.CommandLineArgs(0))
            FilePath = System.IO.Path.GetDirectoryName(My.Application.CommandLineArgs(0))
            LoadChords()

            ' Now fix up with display...
            BodyArea.Controls.Clear()
            For Each Ch As Chord In Chords
                Ch.Initialise(Sizer.Value)
                BodyArea.Controls.Add(Ch.DrawMainFormContainer)
            Next
        End If

        SetFilename()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If Filename = "" Then
            cmdSaveAs_Click(sender, e)
        Else
            Save()
            bChanged = False
            SetFilename()
        End If
    End Sub

    Private Sub cmdSaveAs_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveDialog.AddExtension = True
        SaveDialog.Filter = "Chords|*.chord|All Files|*.*"
        If SaveDialog.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
        Filename = System.IO.Path.GetFileName(SaveDialog.FileName)
        FilePath = System.IO.Path.GetDirectoryName(SaveDialog.FileName)
        Save()
        bChanged = False
        SetFilename()
    End Sub

    Private Sub cmdLoad_Click(sender As Object, e As EventArgs) Handles cmdOpen.Click
        If bChanged Then
            If DoWeNeedToSave(sender, e) = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If
        End If

        OpenDialog.AddExtension = True
        OpenDialog.Filter = "Chords|*.chord|All Files|*.*"
        OpenDialog.CheckFileExists = True
        If OpenDialog.ShowDialog() = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
        Filename = System.IO.Path.GetFileName(OpenDialog.FileName)
        FilePath = System.IO.Path.GetDirectoryName(OpenDialog.FileName)
        LoadChords()
        bChanged = False
        SetFilename()

        ' Now fix up with display...
        BodyArea.Controls.Clear()
        RhythmArea.Controls.Clear()
        For Each Ch As Chord In Chords
            Ch.Initialise(Sizer.Value)
            BodyArea.Controls.Add(Ch.DrawMainFormContainer)
            RhythmArea.Controls.Add(Ch.DrawRhythmContainer)
        Next
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Dim Ch As New Chord(Sizer.Value, RAND.Next.ToString)

        ' Add to the collection in the correct place
        If Chords.Contains(FocusChord) Then
            Chords.Add(Ch, Ch.Key.ToString, , FocusChord)
        Else
            Chords.Add(Ch, Ch.Key.ToString)
        End If

        ' Add to display and resort
        AddToDisplayAndSort(Ch)
    End Sub

    Private Sub cmdBarline_Click(sender As Object, e As EventArgs) Handles cmdBarline.Click
        Dim Ch As New Barline(Sizer.Value, RAND.Next.ToString)

        ' Add to the collection in the correct place
        If Chords.Contains(FocusChord) Then
            Chords.Add(Ch, Ch.Key.ToString, , FocusChord)
        Else
            Chords.Add(Ch, Ch.Key.ToString)
        End If

        ' Add to display and resort
        AddToDisplayAndSort(Ch)
    End Sub


    Private Sub cmdDup_Click(sender As Object, e As EventArgs) Handles cmdDup.Click
        ' Add to the collection in the correct place
        If Chords.Contains(FocusChord) Then
            Dim Ch As New Chord(Sizer.Value, RAND.Next.ToString)
            Ch.SetFromDeserialisedSkeleton(Chords(FocusChord))
            Chords.Add(Ch, Ch.Key.ToString, , FocusChord)

            ' Add to display and re-sort
            AddToDisplayAndSort(Ch)
        End If
    End Sub

    Private Sub AddToDisplayAndSort(Ch As Chord)
        If Not IsNothing(Ch) Then
            BodyArea.Controls.Add(Ch.DrawMainFormContainer)
            RhythmArea.Controls.Add(Ch.DrawRhythmContainer)
        End If
        For I As Integer = 1 To Chords.Count
            BodyArea.Controls.SetChildIndex(Chords(I).DrawMainFormContainer, I - 1)
            RhythmArea.Controls.SetChildIndex(Chords(I).DrawRhythmContainer, I - 1)
        Next
        If Not IsNothing(Ch) Then
            Ch.DrawMainFormContainer.Focus()
            BodyArea.Invalidate(True)
            Ch.ResizeForStrums(Ch.DrawRhythmContainer)
            RhythmArea.Invalidate(True)
        End If
        bChanged = True
        SetFilename()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        For Each Ch As Chord In Chords
            If Ch.DrawMainFormContainer.Focused Then
                Ch.Dispose()
                Chords.Remove(Ch.Key.ToString)
            End If
        Next
        bChanged = True
        SetFilename()
    End Sub

    Private Sub txtSliderVal_TextChanged(sender As Object, e As EventArgs) Handles txtSliderVal.TextChanged
        Try
            Sizer.Value = Val(txtSliderVal.Text)
        Catch
            '
        End Try
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        cmdLoad_Click(sender, e)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        cmdSave_Click(sender, e)
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        cmdPrint_Click(sender, e)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If bChanged Then
            If DoWeNeedToSave(sender, e) = Windows.Forms.DialogResult.Cancel Then
                Exit Sub
            End If
        End If

        Me.Close()
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Chords.Clear()
        BodyArea.Controls.Clear()
        RhythmArea.Controls.Clear()
        Filename = ""
        bChanged = False
        SetFilename()
    End Sub

    Private Sub AddChordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddChordToolStripMenuItem.Click
        cmdAdd_Click(sender, e)
    End Sub

    Private Sub EditToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem1.Click
        cmdEdit_Click(sender, e)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        cmdDelete_Click(sender, e)
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        CopyToolStripMenuItem_Click(sender, e)
        DeleteToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        For Each Ch As Chord In Chords
            If Ch.DrawMainFormContainer.Focused Then
                Clipboard.SetDataObject(Ch)
            End If
        Next
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        If Clipboard.ContainsData("ChordPrinter.Chord") Then
            Try
                Dim Ch As New Chord(Sizer.Value, RAND.Next.ToString)
                Dim tmpChord As Chord
                tmpChord = Clipboard.GetData("ChordPrinter.Chord")
                Ch.SetFromDeserialisedSkeleton(tmpChord)
                If Chords.Contains(FocusChord) Then
                    Chords.Add(Ch, Ch.Key.ToString, , FocusChord)
                Else
                    Chords.Add(Ch, Ch.Key.ToString)
                End If

                ' Add to display and resort
                AddToDisplayAndSort(Ch)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub SetFilename()
        If Filename = "" Then
            Me.Text = System.Reflection.Assembly.GetExecutingAssembly.GetName().Name
        Else
            Me.Text = System.IO.Path.GetFileNameWithoutExtension(Filename) & " - " & System.Reflection.Assembly.GetExecutingAssembly.GetName().Name
        End If
        If bChanged Then
            Me.Text = "* " & Me.Text
        End If
    End Sub

    Private Sub cmdPlay_Click(sender As Object, e As EventArgs) Handles cmdPlay.Click
        If cmdPlay.Text = "Stop" Then
            MIDIPlayer.STOPAllMIDINotes()
            PlayTimer.Stop()
            Chords(PlayChord).DrawMainFormContainer.Invalidate()
            Chords(PlayChord).DrawRhythmContainer.Invalidate(True)
            PlayChord = ""
            cmdPlay.Text = "Play"
            cmdPlay.Image = My.Resources.control_play
        Else
            If Chords.Count > 0 Then
                MIDIPlayer.OpenDevice()
                MIDIPlayer.CurrentInstrument = My.Settings.PlayVoice
                MIDIPlayer.Volume = My.Settings.PlayVolume
                PlayTimer.Interval = 10
                PlayTimer.Start()
                cmdPlay.Text = "Stop"
                cmdPlay.Image = My.Resources.control_stop
            End If
        End If
    End Sub

    Private Sub PlayTimer_Tick(sender As Object, e As EventArgs) Handles PlayTimer.Tick
        Dim NextPlayChord As String = ""
        Dim Ch As Chord

        If PlayChord = "" Then
            Ch = Chords(1)
            NextPlayChord = Ch.Key
            PlayChordCount = Ch.Strums.Count() - 1
        Else
            PlayChordCount = PlayChordCount - 1
            If PlayChordCount <= 0 Then
                Chords(PlayChord).DrawMainFormContainer.Invalidate()
                Chords(PlayChord).DrawRhythmContainer.Invalidate()
                For i As Integer = 1 To Chords.Count - 1
                    If Chords(i).Key = PlayChord Then
                        Ch = Chords(i + 1)
                        NextPlayChord = Ch.Key
                        PlayChordCount = Ch.Strums.Count() - 1
                        Exit For
                    End If
                Next
            Else
                NextPlayChord = PlayChord
            End If
        End If

        If NextPlayChord = "" Then
            PlayTimer.Stop()
            Chords(PlayChord).DrawMainFormContainer.Invalidate()
            Chords(PlayChord).DrawRhythmContainer.Invalidate()
            PlayChord = ""
            cmdPlay.Text = "Play"
            cmdPlay.Image = My.Resources.control_play
            MIDIPlayer.STOPAllMIDINotes()
        Else
            Ch = Chords(NextPlayChord)
            ' PlayInterval: BPM
            ' Duration: semiquavers 1/4 beat
            ' Timer: ms
            PlayTimer.Interval = (Ch.Strums(Ch.Strums.Count() - PlayChordCount).Duration * 15000) / My.Settings.PlayInterval
            Ch.Play(Ch.Strums(Ch.Strums.Count() - PlayChordCount).StrumDirection)
            PlayChord = NextPlayChord
            BodyArea.ScrollControlIntoView(Chords(PlayChord).DrawMainFormContainer)
            Chords(PlayChord).DrawMainFormContainer.Invalidate()
            Chords(PlayChord).DrawRhythmContainer.Invalidate()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        PlaybackSettings.ShowDialog()
    End Sub

    Private Function DoWeNeedToSave(sender As Object, e As System.EventArgs) As Windows.Forms.DialogResult
        Dim Ret As Windows.Forms.DialogResult

        If Filename = "" Then
            Ret = MsgBox("Do you want to save the changes you made", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Question)
        Else
            Ret = MsgBox("Do you want to save the changes you made to " & Filename, MsgBoxStyle.YesNoCancel + MsgBoxStyle.Question)
        End If
        If Ret = Windows.Forms.DialogResult.Yes Then
            cmdSave_Click(sender, e)
        End If

        DoWeNeedToSave = Ret
    End Function

    Private Sub PrintChordsOnlyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintChordsOnlyToolStripMenuItem.Click
        My.Settings.PrintDefault = PRINT_TYPE_CHORDSONLY
        cmdPrint_Click(sender, e)
    End Sub

    Private Sub PrintSummaryChordsAndRhythmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintSummaryChordsAndRhythmToolStripMenuItem.Click
        My.Settings.PrintDefault = PRINT_TYPE_SUMMARYCHORDSANDRHYTHM
        cmdPrint_Click(sender, e)
    End Sub

    Private Sub PrintRhythmOnlyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintRhythmOnlyToolStripMenuItem.Click
        My.Settings.PrintDefault = PRINT_TYPE_RHYTHMONLY
        cmdPrint_Click(sender, e)
    End Sub

    Private Sub PrintChordsOnlyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PrintChordsOnlyToolStripMenuItem1.Click
        My.Settings.PrintDefault = PRINT_TYPE_CHORDSONLY
        cmdPrint_Click(sender, e)
    End Sub

    Private Sub PrintSummaryChordsAndRhythmToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PrintSummaryChordsAndRhythmToolStripMenuItem1.Click
        My.Settings.PrintDefault = PRINT_TYPE_SUMMARYCHORDSANDRHYTHM
        cmdPrint_Click(sender, e)
    End Sub

    Private Sub PrintRhythmOnlyToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PrintRhythmOnlyToolStripMenuItem1.Click
        My.Settings.PrintDefault = PRINT_TYPE_RHYTHMONLY
        cmdPrint_Click(sender, e)
    End Sub

    Private Sub cmdTitle_Click(sender As Object, e As EventArgs) Handles cmdTitle.Click
        If TitleEdit.ShowDialog() = Windows.Forms.DialogResult.OK Then
            bChanged = True
            SetFilename()
        End If

    End Sub
End Class
