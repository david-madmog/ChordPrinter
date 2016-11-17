Public Class RhythmPanel
    Inherits Panel

    Private dragBoxFromMouseDown As Rectangle
    Public Property Key As String

    Sub New(K As String)
        Key = K
        MyBase.AllowDrop = True
    End Sub

    Public Sub OnClickHandler(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.Click
        If (e.Clicks > 1) Then
            EditChord(Chords(Key))
        Else
            Chords(Key).DrawMainFormContainer.Focus()
        End If
        frmChordPrinter.BodyArea.Invalidate(True)
        frmChordPrinter.RhythmArea.Invalidate(True)
    End Sub

    Sub OnDblClickHandler(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.DoubleClick
        EditChord(Chords(Key))
    End Sub


    Public Sub OnMouseDownHandler(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown
        ' Remember the point where the mouse down occurred. The DragSize indicates 
        ' the size that the mouse can move before a drag event should be started.                 
        Dim dragSize As Size = SystemInformation.DragSize

        ' Create a rectangle using the DragSize, with the mouse position being 
        ' at the center of the rectangle.
        dragBoxFromMouseDown = New Rectangle(New Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize)
    End Sub

    Private Sub OnMouseUpHandler(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp
        ' Reset the drag rectangle when the mouse button is raised.
        dragBoxFromMouseDown = Rectangle.Empty
    End Sub

    Private Sub OnMouseMoveHandler(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove
        If ((e.Button And MouseButtons.Left) = MouseButtons.Left) Then
            ' If the mouse moves outside the rectangle, start the drag. 
            If (Rectangle.op_Inequality(dragBoxFromMouseDown, Rectangle.Empty) And Not dragBoxFromMouseDown.Contains(e.X, e.Y)) Then
                ' Proceed with the drag-and-drop, passing in the list item.                     
                Dim dropEffect As DragDropEffects = Me.DoDragDrop(Key, DragDropEffects.Move)
            End If
        End If
    End Sub

    Private Sub OnDragOverHandler(ByVal sender As Object, ByVal e As DragEventArgs) Handles MyBase.DragOver
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub OnDragDropHandler(ByVal sender As Object, ByVal e As DragEventArgs) Handles MyBase.DragDrop
        If (e.Data.GetDataPresent(GetType(System.String))) Then
            Dim DragSrc As String = e.Data.GetData(GetType(System.String))
            frmChordPrinter.ReorderChords(DragSrc, Key)
        End If
    End Sub

End Class
