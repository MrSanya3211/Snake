Class VerticalLine
    Inherits Figure

    Public Sub New(yUp As Integer, yDown As Integer, x As Integer, sym As Char)
        PList = New List(Of Point)
        For y = yUp To yDown Step 1
            Dim p As Point = New Point(x, y, sym)
            PList.Add(p)
        Next
    End Sub

End Class
