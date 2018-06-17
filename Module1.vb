Module Module1

    Sub Main()

        Dim chatMediator As IMediator
        chatMediator = New Mediator()

        Dim John As New Colleague("John", chatMediator)
        Dim George As New Colleague("George", chatMediator)
        Dim Alan As New Colleague("Alan", chatMediator)
        Dim Alice As New Colleague("Alice", chatMediator)
        Dim Maria As New Colleague("Maria", chatMediator)

        chatMediator.addColleague(John)
        chatMediator.addColleague(George)
        chatMediator.addColleague(Alan)
        chatMediator.addColleague(Alice)
        chatMediator.addColleague(Maria)

        George.sendMessage("Guys! check mediator pattern! it's very cool!")
        Maria.sendMessage("WOW! it's amazing george! thanks!")

        Do Until (Console.ReadKey.Key = ConsoleKey.Escape)
            System.Threading.Thread.Sleep(1000)
        Loop

    End Sub

End Module
