Class Walls
    Dim wallList As List(Of Figure)

    Public Sub New(mapWidth As Integer, mapHeight As Integer)
        wallList = New List(Of Figure)

        Dim upLine As HorizontalLine = New HorizontalLine(0, mapWidth - 2, 0, "+")
        Dim downLine As HorizontalLine = New HorizontalLine(0, mapWidth - 2, mapHeight - 1, "+")
        Dim leftLine As VerticalLine = New VerticalLine(0, mapHeight - 1, 0, "+")
        Dim rightLine As VerticalLine = New VerticalLine(0, mapHeight - 1, mapWidth - 2, "+")

        wallList.Add(upLine)
        wallList.Add(downLine)
        wallList.Add(leftLine)
        wallList.Add(rightLine)
    End Sub

    Friend Function IsHit(figure As Figure) As Boolean
        For Each wall In wallList
            If wall.IsHit(figure) Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Sub Draw()
        For Each wall In wallList
            wall.Draw()
        Next
    End Sub
End Class
