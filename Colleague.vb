Public Class Colleague

    Private nameValue As String
    Public ReadOnly Property name() As String
        Get
            Return nameValue
        End Get
    End Property

    Private mediator As IMediator

    Sub New(name As String, mediator As IMediator)
        Me.nameValue = name
        Me.mediator = mediator
    End Sub

    Sub sendMessage(text As String)
        Console.WriteLine(Me.nameValue & ": " & text)
        Me.mediator.sendMessage(text, Me)
    End Sub

    Sub receiveMessage(text As String)
        Console.WriteLine(Me.nameValue & " > " & text)
    End Sub
End Class
