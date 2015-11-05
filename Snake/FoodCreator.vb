Class FoodCreator
    Dim mapWidth As Integer
    Dim mapHeight As Integer
    Dim sym As Char

    Dim random As Random = New Random

    Public Sub New(mapWidth As Integer, mapHeight As Integer, sym As Char)
        Me.mapWidth = mapWidth
        Me.mapHeight = mapHeight
        Me.sym = sym
    End Sub

    Public Function CreateFood() As Point
        Dim x As Integer = random.Next(2, mapWidth - 2)
        Dim y As Integer = random.Next(2, mapHeight - 2)
        Return New Point(x, y, sym)
    End Function

End Class
