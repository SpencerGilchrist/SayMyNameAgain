Module SayMyNameAgain

    Sub Main()
        Console.WriteLine("Say Your Name!")

        Dim UserInput As String

        UserInput = Console.ReadLine()

        If UserInput = "Tim" Then
            Console.WriteLine("Hello Tim, can I get an A?")
            GoTo Line1

        ElseIf UserInput = "Joe" Then
            Console.WriteLine("Welcome Back Joe! How was your Vacation?")
            GoTo Line1

        ElseIf UserInput = "Emily" Then
            Console.WriteLine("Welcome back Emily! Its good to see you again!")
            GoTo Line1

        ElseIf UserInput = "Spencer" Then
            Console.WriteLine("Yo, Wassup.")
            GoTo Line1
        End If

        Console.WriteLine($"Hello, {UserInput}!")

Line1:

        Console.ReadLine()
    End Sub

End Module
