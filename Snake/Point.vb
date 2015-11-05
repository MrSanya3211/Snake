Class Point
    Public X As Integer
    Public Y As Integer
    Public Sym As Char

    Public Sub New()

    End Sub

    Public Sub New(X As Integer, Y As Integer, Sym As Char)
        Me.X = X
        Me.Y = Y
        Me.Sym = Sym
    End Sub

    Public Sub New(P As Point)
        X = P.X
        Y = P.Y
        Sym = P.Sym
    End Sub

    Public Sub Move(Offset As Integer, direction As Direction)
        If direction = Direction.RIGHT Then
            X = X + Offset
        ElseIf direction = Direction.LEFT
            X = X - Offset
        ElseIf direction = Direction.UP
            Y = Y - 1
        ElseIf direction = Direction.DOWN
            Y = Y + 1
        End If
    End Sub

    Public Function IsHit(P As Point) As Boolean
        Return P.X = Me.X And P.Y = Me.Y
    End Function

    Public Sub Draw()
        Console.SetCursorPosition(X, Y)
        Console.Write(Sym)
    End Sub

    Public Sub Clear()
        Sym = " "
        Draw()
    End Sub

    Public Overrides Function ToString() As String
        Return X.ToString() + ", " + Y.ToString() + ", " + Sym.ToString()
    End Function
End Class
