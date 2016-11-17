<Serializable()>
Public Class Chord
    Implements IDisposable

    <NonSerialized()> Public DrawMainFormContainer As ChordPanel
    <NonSerialized()> Public DrawRhythmContainer As RhythmPanel
    Public Key As String
    Public Name As String
    Public Base As Integer
    Public Strings(0 To 5) As GUString
    Public Strums(0 To 0) As Strum

    <NonSerialized()> Protected FocusPen As Pen

    Sub New(Size As Integer, vKey As String)
        Key = vKey
        AddStrum(4)

        Initialise(Size)

        For i As Integer = 0 To 5
            Strings(i) = New GUString
        Next

        Name = "C"
        Base = 0
    End Sub

    Public Sub AddStrum(Duration As Integer)
        Dim I As Integer
        I = Strums.Count
        ReDim Preserve Strums(0 To I)
        Strums(I) = New Strum(Duration)
        ResizeForStrums(DrawRhythmContainer)
    End Sub

    Public Sub RemoveStrum(Index As Integer)
        Dim I As Integer
        Dim J As Integer
        Dim TmpStrums As Strum()
        TmpStrums = Strums.Clone
        ReDim Strums(0 To TmpStrums.Count - 2)
        J = 1
        For I = 1 To TmpStrums.Count - 1
            If I <> Index Then
                Strums(J) = TmpStrums(I)
                J = J + 1
            End If
        Next
        ResizeForStrums(DrawRhythmContainer)
    End Sub

    Public Overridable Sub ResizeForStrums(RP As Panel)
        If Not IsNothing(RP) And Not IsNothing(Strums) Then
            RP.Width = ((RP.Height * (Strums.Count - 1)) / 3) + 4
            If Not IsNothing(RP.Parent) Then
                RP.Parent.Invalidate(True)
            End If
        End If

    End Sub
  
    Sub Initialise(Size As Integer)
        DrawMainFormContainer = New ChordPanel(Key)
        DrawRhythmContainer = New RhythmPanel(Key)
        AddHandler DrawMainFormContainer.Paint, AddressOf Me.PaintHandler
        AddHandler DrawRhythmContainer.Paint, AddressOf Me.RhythmPaintHandler
        Resize(Size)
        FocusPen = New Pen(Color.DarkGray)
        FocusPen.DashStyle = Drawing2D.DashStyle.Dot
        If Strums Is Nothing Then
            ReDim Strums(0 To 0)
            AddStrum(4)
        End If
    End Sub

    Sub SetFromDeserialisedSkeleton(Skeleton As Chord)
        Dim I As Integer
        Name = Skeleton.Name
        Base = Skeleton.Base
        ReDim Strums(0 To Skeleton.Strums.GetUpperBound(0))
        For I = 1 To Skeleton.Strums.GetUpperBound(0)
            Strums(I) = Skeleton.Strums(I).Clone
        Next
        For I = 0 To 5
            Strings(I) = Skeleton.Strings(I).Clone()
        Next
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        DrawMainFormContainer.Parent.Controls.Remove(DrawMainFormContainer)
        DrawMainFormContainer.Dispose()
        DrawRhythmContainer.Parent.Controls.Remove(DrawRhythmContainer)
        DrawRhythmContainer.Dispose()
        FocusPen.Dispose()
    End Sub

    Private Sub PaintHandler(sender As Object, e As PaintEventArgs)
        Draw(e.Graphics, 0, 0, DrawMainFormContainer.Width, DrawMainFormContainer.Height)
    End Sub

    Private Sub RhythmPaintHandler(sender As Object, e As PaintEventArgs)
        DrawRhythm(e.Graphics, 0, 0, DrawRhythmContainer.Width, DrawRhythmContainer.Height)
    End Sub

    Public Sub Draw()
        Draw(DrawMainFormContainer.CreateGraphics, 0, 0, DrawMainFormContainer.Width, DrawMainFormContainer.Height)
    End Sub

    Public Sub DrawRhythm()
        Draw(DrawRhythmContainer.CreateGraphics, 0, 0, DrawRhythmContainer.Width, DrawRhythmContainer.Height)
    End Sub

    Public Sub Draw(DrawControl As Control)
        Draw(DrawControl.CreateGraphics, 0, 0, DrawControl.Width, DrawControl.Height)
    End Sub

    Public Sub DrawRhythm(DrawControl As Control, Optional Focus As Integer = -1)
        DrawRhythm(DrawControl.CreateGraphics, 0, 0, DrawControl.Width, DrawControl.Height, True, Focus)
    End Sub

    Public Overridable Sub Draw(G As Graphics, Left As Integer, Top As Integer, Width As Integer, Height As Integer, Optional bFocus As Boolean = True)
        Dim X As Integer, Y As Integer, XX As Integer, YY As Integer

        ' Clear background
        If Key = PlayChord Then
            G.FillRectangle(Brushes.LightGreen, Left, Top, Width, Height)
        Else
            G.FillRectangle(Brushes.White, Left, Top, Width, Height)
        End If

        ' Work Out string Area
        X = Width / 4
        XX = (Width * 5) / 8
        Y = (Height * 3) / 16
        YY = (Height * 12) / 16
        'G.FillRectangle(Brushes.Aqua, X, Y, XX, YY)

        ' Draw strings
        For i As Integer = 0 To 5
            Strings(i).Draw(G, ((XX * i) / 5) + X + Left, Y + Top, YY)
        Next

        Dim YYY As Integer
        ' Draw Frets
        For i As Integer = 0 To 6
            YYY = Y + ((i * YY) / 7)
            G.DrawLine(Pens.Black, X + Left, YYY + Top, X + XX + Left, YYY + Top)
        Next

        If DrawMainFormContainer.Focused And bFocus Then
            G.DrawRectangle(FocusPen, Left, Top, Width - 1, Height - 1)
        End If

        ' Name and Base
        Dim FF As Font = New Font("Arial", YY / 20)
        G.DrawString(Name, FF, Brushes.Black, (Width / 2) - (G.MeasureString(Name, FF).Width / 2) + Left, Top)
        Dim sBase As String
        sBase = ToRoman(Base)
        G.DrawString(sBase, New Font("Times New Roman", YY / 20), Brushes.Black, Left, Y + Top)

        'G.DrawString(Key, New Font("Arial", 10), Brushes.LightBlue, 0, 0)
    End Sub

    Public Overridable Sub DrawRhythm(G As Graphics, Left As Integer, Top As Integer, Width As Integer, Height As Integer, Optional bFocus As Boolean = True, Optional Focus As Integer = -1)
        Dim R As New Rectangle(Left + 2, Height / 3, Height / 3, Height / 4)

        ' Resize so we can fit...
        Dim FF As Font = New Font("Arial", Height / 4)
        If G.MeasureString(Name, FF).Width > Width Then
            DrawRhythmContainer.Width = G.MeasureString(Name, FF).Width
        End If

        ' Clear background
        G.FillRectangle(Brushes.White, Left, Top, Width, Height)
        If Key = PlayChord Then
            Dim RR As New Rectangle(R.Location, R.Size)
            RR.X = RR.X + (RR.Width * (Strums.Count - PlayChordCount - 1))
            RR.Y = Height / 3
            RR.Height = (2 * Height) / 3
            G.FillRectangle(Brushes.LightGreen, RR)
        End If
        If Focus > 0 Then
            Dim RR As New Rectangle(R.Location, R.Size)
            RR.X = RR.X + (RR.Width * (Focus - 1))
            RR.Y = Height / 3
            RR.Height = (2 * Height) / 3
            G.FillRectangle(Brushes.Pink, RR)
        End If

        If DrawMainFormContainer.Focused And bFocus Then
            G.DrawRectangle(FocusPen, Left, Top, Width - 1, Height - 1)
        End If

        G.DrawString(Name, FF, Brushes.Black, Left, Top)

        For Each St As Strum In Strums
            If Not St Is Nothing Then
                R.Y = Height / 3 + Top
                G.DrawImage(St.GetStrumDirectionImage, R)
                R.Y = 2 * Height / 3 + Top
                G.DrawImage(St.GetStrumDurationImage, R)
                R.X = R.Left + R.Width
            End If
        Next
    End Sub

    Public Overridable Sub Resize(Size As Integer)
        DrawMainFormContainer.Width = Size
        DrawMainFormContainer.Height = Size * 2
        DrawRhythmContainer.Height = Size / 2
        ResizeForStrums(DrawRhythmContainer)
    End Sub

    Public Sub Play(Optional Strum As Strum.Direction = Strum.Direction.StrumUnspecified)
        If Strum = Global.ChordPrinter.Strum.Direction.StrumUp Then
            For i As Integer = 5 To 0 Step -1
                Strings(i).Play(i, Base)
                Threading.Thread.Sleep(My.Settings.StrumInterval)
            Next
        Else
            For i As Integer = 0 To 5
                Strings(i).Play(i, Base)
                Threading.Thread.Sleep(My.Settings.StrumInterval)
            Next
        End If
    End Sub

End Class
