Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Runtime.Serialization
Imports System.IO

Module ChordPrinter
    Public Chords As New Collection
    Public RAND As New Random()
    Public FocusChord As String = ""
    Public PlayChord As String = ""
    Public PlayChordCount As Integer

    Public CurrentPrintChord As Integer
    Public CurrentPrintPass As Integer
    Public PrintedChords As New Collection

    Public Filename As String = ""
    Public FilePath As String = ""
    Public bChanged As Boolean = False

    Public Title As String

    Public MIDIPlayer As New clsMIDI
    Public Tuning As Integer() = {40, 45, 50, 55, 59, 64}

    Public Function ToRoman(value As Integer) As String
        Dim remainder As Integer
        Dim result As Integer
        Dim returnString As String = String.Empty

        ' Get the hundreds digit(s)
        result = Math.DivRem(value, 100, remainder)
        If result > 0 Then returnString = New String("C"c, result)
        value = CByte(remainder)
        ' Get the 50s digit
        result = Math.DivRem(value, 50, remainder)
        If result = 1 Then returnString += "L"
        value = CByte(remainder)
        ' Get the tens digit.
        result = Math.DivRem(value, 10, remainder)
        If result > 0 Then returnString += New String("X"c, result)
        value = CByte(remainder)
        ' Get the fives digit.
        result = Math.DivRem(value, 5, remainder)
        If result > 0 Then returnString += "V"
        value = CByte(remainder)
        ' Add the ones digit. 
        If remainder > 0 Then returnString += New String("I"c, remainder)

        ' Check whether we have too many X characters. 
        Dim pos As Integer = returnString.IndexOf("XXXX")
        If pos >= 0 Then
            Dim xPos As Integer = returnString.IndexOf("L")
            If xPos >= 0 And xPos = pos - 1 Then
                returnString = returnString.Replace("LXXXX", "XC")
            Else
                returnString = returnString.Replace("XXXX", "XL")
            End If
        End If
        ' Check whether we have too many I characters
        pos = returnString.IndexOf("IIII")
        If pos >= 0 Then
            If returnString.IndexOf("V") >= 0 Then
                returnString = returnString.Replace("VIIII", "IX")
            Else
                returnString = returnString.Replace("IIII", "IV")
            End If
        End If
        Return returnString

    End Function

    Public Sub EditChord(Ch As Chord)
        Dim CE As Form

        If TypeOf Ch Is Barline Then
            Dim tmpCE As New BarlineEdit
            tmpCE.Chord = Ch
            CE = tmpCE
        Else
            Dim tmpCE As New ChordEdit
            tmpCE.Chord = Ch
            CE = tmpCE
        End If

        ' Stash state
        Dim ms As New MemoryStream()
        Dim formatter As New BinaryFormatter()
        formatter.Serialize(ms, Ch)

        If CE.ShowDialog() = DialogResult.Cancel Then
            ' Restore state from stash
            ms.Seek(0, IO.SeekOrigin.Begin)
            Ch.SetFromDeserialisedSkeleton(formatter.Deserialize(ms))
        End If
        Ch.DrawMainFormContainer.Invalidate(True)
        Ch.DrawRhythmContainer.Invalidate(True)
        bChanged = True
    End Sub

    Public Sub Save()
        Dim Formatter As New BinaryFormatter
        Dim SaveStream As New FileStream(FilePath + "\" + Filename, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None)

        Formatter.Serialize(SaveStream, Chords)
        Formatter.Serialize(SaveStream, Title)
        SaveStream.Close()

    End Sub

    Public Sub LoadChords()
        Dim Formatter As New BinaryFormatter
        Dim SaveStream As New FileStream(FilePath + "\" + Filename, FileMode.Open, FileAccess.Read, FileShare.Read)

        Chords = Formatter.Deserialize(SaveStream)
        Try
            Title = Formatter.Deserialize(SaveStream)
        Catch ex As Exception
            Title = ""
        End Try
        SaveStream.Close()
    End Sub
End Module
