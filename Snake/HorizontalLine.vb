Class HorizontalLine
    Inherits Figure

    Public Sub New(xLeft As Integer, xRight As Integer, y As Integer, sym As Char)
        PList = New List(Of Point)
        For x As Integer = xLeft To xRight Step 1
            Dim p As Point = New Point(x, y, sym)
            PList.Add(p)
        Next
    End Sub

End Class
