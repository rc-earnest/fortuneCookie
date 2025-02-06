



Option Strict On
Option Explicit On
Option Compare Text

Module fortuneCookie

    Sub Main()
        Dim luckyNumber As Integer
        luckyNumber = RandomNumberBetween(0, 5)
        Select Case luckyNumber
            Case 0
                Console.WriteLine("A banana is not always yellow, just as your day is not a great fellow.")
            Case 1
                Console.WriteLine("The grass will fade away, but the memories you made there will always stay... unless.")
            Case 2
                Console.WriteLine("The leaves will fall as the year passes, but will return next year in the masses... maybe.")
            Case 3
                Console.WriteLine("A seed might be small in stature, but eventually grows to ten times of that... eventually.")
            Case 4
                Console.WriteLine("The paint on an old house fades away, but you can just put more on at the end of the day.")
            Case 5
                Console.WriteLine("You are the dragon warrior... What is your name again?")
        End Select

    End Sub

    Function RandomNumberBetween(min As Integer, max As Integer) As Integer
        Dim temp As Single
        Randomize()
        temp = Rnd()
        temp *= max - min
        temp += min
        Return CInt(temp)
    End Function
End Module
