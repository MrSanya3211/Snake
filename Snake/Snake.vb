Class Snake
    Inherits Figure

    Dim direction As Direction

    Public Sub New(tail As Point, length As Integer, _direction As Direction)
        direction = _direction
        PList = New List(Of Point)
        For i As Integer = 0 To length Step 1
            Dim p As Point = New Point(tail)
            p.Move(i, direction)
            PList.Add(p)
        Next
    End Sub

    Public Sub Move()
        Dim tail As Point = PList.First
        PList.Remove(tail)
        Dim head As Point = GetNextPoint()
        PList.Add(head)

        tail.Clear()
        head.Draw()
    End Sub

    Public Function GetNextPoint() As Point
        Dim head As Point = PList.Last
        Dim nextPoint As Point = New Point(head)
        nextPoint.Move(1, direction)
        Return nextPoint
    End Function

    Public Function IsHitTail() As Boolean
        Dim head = PList.Last
        For i As Integer = 0 To PList.Count - 2 Step 1
            If head.IsHit(PList(i)) Then
                Return True
            End If
        Next i
        Return False
    End Function

    Public Sub HandleKey(key As ConsoleKey)
        If key = ConsoleKey.LeftArrow Then
            direction = Direction.LEFT
        ElseIf key = ConsoleKey.RightArrow
            direction = Direction.RIGHT
        ElseIf key = ConsoleKey.DownArrow
            direction = Direction.DOWN
        ElseIf key = ConsoleKey.UpArrow
            direction = Direction.UP
        End If
    End Sub

    Public Function Eat(food As Point) As Boolean
        Dim head As Point = GetNextPoint()
        If head.IsHit(food) Then
            food.Sym = head.Sym
            PList.Add(food)
            Return True
        Else
            Return False
        End If
    End Function
End Class
