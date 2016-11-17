<Serializable()>
Public Class Barline
    Inherits Chord

    Enum BarlineType
        Start
        StartDots
        Simple
        Section
        Final
        FinalDots
    End Enum

    Public Type As BarlineType = BarlineType.Simple
    <NonSerialized()> Protected WideLinePen As Pen

    Sub New(Size As Integer, vKey As String)
        MyBase.New(Size, vKey)
    End Sub

    Overrides Sub Draw(G As Graphics, Left As Integer, Top As Integer, Width As Integer, Height As Integer, Optional bFocus As Boolean = True)
        Dim R As New Rectangle(Left, Top, Width, Height)
        Dim XX As Integer = (Width / 2) + Left
        Dim YY As Integer = (Height / 2) + Top
        Dim DW As Integer = (Width / 2) - 4

        If IsNothing(WideLinePen) Then
            WideLinePen = New Pen(Brushes.Black, 3)
        End If

        ' Clear background
        G.FillRectangle(Brushes.White, R)

        Select Case Type
            Case BarlineType.Section
                G.DrawLine(Pens.Black, XX - 2, Top, XX - 2, Height + Top)
                G.DrawLine(Pens.Black, XX + 2, Top, XX + 2, Height + Top)
            Case BarlineType.Start
                G.DrawLine(WideLinePen, XX - 5, Top, XX - 5, Height + Top)
                G.DrawLine(Pens.Black, XX, Top, XX, Height + Top)
            Case BarlineType.StartDots
                G.DrawLine(WideLinePen, XX - 5, Top, XX - 5, Height + Top)
                G.DrawLine(Pens.Black, XX, Top, XX, Height + Top)
                G.FillEllipse(Brushes.Black, XX + 2, YY - (2 * DW), DW, DW)
                G.FillEllipse(Brushes.Black, XX + 2, YY + DW, DW, DW)
            Case BarlineType.Final
                G.DrawLine(Pens.Black, XX, Top, XX, Height + Top)
                G.DrawLine(WideLinePen, XX + 5, Top, XX + 5, Height + Top)
            Case BarlineType.FinalDots
                G.DrawLine(Pens.Black, XX, Top, XX, Height + Top)
                G.DrawLine(WideLinePen, XX + 5, Top, XX + 5, Height + Top)
                G.FillEllipse(Brushes.Black, XX - 2 - DW, YY - (2 * DW), DW, DW)
                G.FillEllipse(Brushes.Black, XX - 2 - DW, YY + DW, DW, DW)
            Case Else
                G.DrawLine(Pens.Black, XX, Top, XX, Height + Top)
        End Select

        If DrawMainFormContainer.Focused And bFocus Then
            G.DrawRectangle(FocusPen, Left, Top, Width - 1, Height - 1)
        End If

    End Sub

    Public Overrides Sub DrawRhythm(G As Graphics, Left As Integer, Top As Integer, Width As Integer, Height As Integer, Optional bFocus As Boolean = True, Optional Focus As Integer = -1)
        ' Always draw them the same
        Draw(G, Left, Top, Width, Height, bFocus)
    End Sub

    Public Overrides Sub Resize(Size As Integer)
        DrawMainFormContainer.Width = Size / 5
        DrawMainFormContainer.Height = Size * 2
        DrawRhythmContainer.Width = Math.Max(Size / 10, 15)
        DrawRhythmContainer.Height = Size / 2
    End Sub

    Public Overrides Sub ResizeForStrums(RP As Panel)
        If Not IsNothing(RP) Then
            RP.Width = Math.Max(RP.Height / 10, 15)

            If Not IsNothing(RP.Parent) Then
                RP.Parent.Invalidate(True)
            End If
        End If

    End Sub



End Class
