<Serializable()>
Public Class Strum
    Public Duration As Integer

    Public Enum Direction
        StrumUnspecified
        StrumDown
        StrumUp
    End Enum

    Public StrumDirection As Direction = Direction.StrumUnspecified

    Sub New(vDuration As Integer)
        Duration = vDuration
    End Sub

    Function Clone() As Strum
        Dim S As New Strum(Duration)
        S.StrumDirection = Me.StrumDirection
        Clone = S
    End Function

    Public Function GetStrumDurationImage() As Image
        Dim Img As Image
        Select Case Duration
            Case 1
                Img = My.Resources.sixteenthnote
            Case 2
                Img = My.Resources.eightnote
            Case 3
                Img = My.Resources.eightnotedot
            Case 4
                Img = My.Resources.quarternote
            Case 6
                Img = My.Resources.quarternotedot
            Case 8
                Img = My.Resources.halfnote
            Case 12
                Img = My.Resources.halfnotedot
            Case 24
                Img = My.Resources.fullnotedot
            Case Else
                Img = My.Resources.fullnote
        End Select
        Return Img
    End Function

    Public Function GetStrumDirectionImage() As Image
        Dim Img As Image
        Select Case StrumDirection
            Case Direction.StrumDown
                Img = My.Resources.strokedown
            Case Direction.StrumUp
                Img = My.Resources.strokeup
            Case Else
                Img = My.Resources.blank
        End Select
        Return Img
    End Function

End Class
