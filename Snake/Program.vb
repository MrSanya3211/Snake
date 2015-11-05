Module Program

    Sub Main()
        Console.SetBufferSize(80, 25)

        Dim walls As Walls = New Walls(80, 25)
        walls.Draw()

        Dim p As Point = New Point(4, 5, "*")
        Dim snake As Snake = New Snake(p, 4, Direction.RIGHT)
        snake.Draw()

        Dim foodCreator As FoodCreator = New FoodCreator(80, 25, "$")
        Dim food As Point = foodCreator.CreateFood
        food.Draw()

        While True
            If walls.IsHit(snake) Or snake.IsHitTail Then
                Exit While
            End If
            If snake.Eat(food) Then
                food = foodCreator.CreateFood
                food.Draw()
            Else
                snake.Move()
            End If

            Threading.Thread.Sleep(100)
            If Console.KeyAvailable Then
                Dim key As ConsoleKeyInfo = Console.ReadKey
                snake.HandleKey(key.Key)
            End If
        End While
        WriteGameOver()
        Console.ReadKey()
    End Sub

    Sub WriteGameOver()
        Dim xOffset As Integer = 25
        Dim yOffset As Integer = 8
        Console.ForegroundColor = ConsoleColor.Red
        Console.SetCursorPosition(xOffset, yOffset = yOffset + 1)
        WriteText("============================", xOffset, yOffset = yOffset + 1)
        WriteText("И Г Р А    О К О Н Ч Е Н А", xOffset + 1, yOffset = yOffset + 1)
    End Sub

    Private Sub WriteText(text As String, xOffset As Integer, yOffset As Integer)
        Console.SetCursorPosition(xOffset, yOffset)
        Console.WriteLine(text)
    End Sub
End Module
