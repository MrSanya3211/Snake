Class Figure
    Protected PList As List(Of Point)

    Public Sub Draw()
        For Each P As Point In PList
            P.Draw()
        Next
    End Sub

    Friend Function IsHit(Figure As Figure) As Boolean
        For Each P In PList
            If Figure.IsHit(P) Then
                Return True
            End If
        Next P
        Return False
    End Function

    Private Function IsHit(Point As Point) As Boolean
        For Each P In PList
            If P.IsHit(Point) Then
                Return True
            End If
        Next
        Return False
    End Function

End Class
