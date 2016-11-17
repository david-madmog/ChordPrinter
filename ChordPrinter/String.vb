<Serializable()>
Public Class GUString
    Implements IDisposable

    Public Frets(0 To 6) As Integer

    Public Enum OpenStringState
        Blank
        Open
        Mute
    End Enum

    Public OpenState As OpenStringState

    <NonSerialized()> Public CheckPen As Pen

    Sub Dispose() Implements IDisposable.Dispose
        If Not CheckPen Is Nothing Then
            CheckPen.Dispose()
        End If
    End Sub

    Sub New()
        '       Frets(RAND.Next(7)) = RAND.Next(6)
        '       Dim I As Integer = RAND.Next(10)
        '       If I < 4 Then
        OpenState = OpenStringState.Open
        ' ElseIf I < 7 Then
        ' OpenState = OpenStringState.Mute
        ' End If
    End Sub

    Function Clone() As GUString
        Dim S As New GUString()

        For i As Integer = 1 To 6
            S.Frets(i) = Me.Frets(i)
        Next
        S.OpenState = Me.OpenState
        Clone = S
    End Function

    Public Sub NextOpenState()
        Select Case OpenState
            Case OpenStringState.Blank
                OpenState = OpenStringState.Open
            Case OpenStringState.Mute
                OpenState = OpenStringState.Blank
            Case OpenStringState.Open
                OpenState = OpenStringState.Mute
        End Select

    End Sub

    Public Sub Draw(G As Graphics, X As Integer, Top As Integer, Height As Integer)
        Dim YY As Integer
        Dim SS As Integer, SSS As Integer

        If CheckPen Is Nothing Then
            CheckPen = New Pen(Color.Black, 3)
        End If

        G.DrawLine(Pens.Black, X, Top, X, Height + Top)

        SS = Height / 50
        SSS = Height / 25
        If SS = 0 Then
            SS = 1
            SSS = 2
        End If

        If OpenState = OpenStringState.Open Then
            G.DrawArc(Pens.Black, X - SS, Top - SSS, SSS, SSS, 0, 360)
        ElseIf OpenState = OpenStringState.Mute Then
            G.DrawLine(Pens.Black, X - SS, Top - SSS, X + SS, Top)
            G.DrawLine(Pens.Black, X - SS, Top, X + SS, Top - SSS)
        End If

        YY = Height / 7

        ' Move everything up by 1/2 fret
        Top = Top - (YY / 2)
        For i As Integer = 1 To 6
            If Frets(i) > 0 Then
                G.DrawLine(CheckPen, X - SS, (i * YY) - SS + Top, X + SS, (i * YY) + SS + Top)
                If Frets(i) < 5 Then
                    G.DrawString(Frets(i).ToString, New Font("Arial", SSS), Brushes.Black, X - SSS, (i * YY) + Top)
                    'G.DrawString(i.ToString, New Font("Arial", SSS), Brushes.Pink, X, (i * YY) + Top)
                End If
            End If
        Next
    End Sub

    Public Function HasAnyFret() As Boolean
        For Fret As Integer = 6 To 1 Step -1
            If Frets(Fret) > 0 Then
                HasAnyFret = True
                Exit Function
            End If
        Next
        HasAnyFret = False
    End Function

    Sub Play(I As Integer, Base As Integer)
        Dim Pitch As Integer

        Pitch = Tuning(I) + Base

        For Fret As Integer = 6 To 1 Step -1
            If Frets(Fret) > 0 Then
                Pitch = Pitch + Fret
                Exit For
            End If
        Next

        If HasAnyFret() Or OpenState = OpenStringState.Open Then
            MIDIPlayer.PlayMIDINote(Pitch, 127)
        End If
    End Sub

End Class
