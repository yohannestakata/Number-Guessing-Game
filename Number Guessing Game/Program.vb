Imports System

Module Program
    Sub Main(args As String())
        Dim randomizer As New Random()
        Dim randomNumber As Integer = randomizer.NextInt64(1, 101)

        Console.WriteLine("Guess the generated random number.")
        Console.WriteLine(randomNumber)

        Dim guess As Integer = Integer.Parse(Console.ReadLine())

        While guess <> randomNumber
            If guess > randomNumber Then
                Console.WriteLine("Guess Lower")
            ElseIf guess < randomNumber Then
                Console.WriteLine("Guess higher")
            End If

            guess = Console.ReadLine()
        End While

        Console.WriteLine("You guessed correct!")
        Console.ReadLine()
    End Sub
End Module
