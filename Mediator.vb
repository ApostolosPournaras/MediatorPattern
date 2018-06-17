Public Class Mediator
    Implements IMediator

    Private colleagues As New List(Of Colleague)

    Public Sub addColleague(newColleague As Colleague) Implements IMediator.addColleague
        If Not colleagues.Contains(newColleague) Then
            colleagues.Add(newColleague)
        End If
    End Sub


    Public Sub sendMessage(text As String, fromColleague As Colleague) Implements IMediator.sendMessage
        For Each col As Colleague In colleagues
            If col IsNot fromColleague Then
                col.receiveMessage(fromColleague.name & ": " & text)
            End If
        Next
    End Sub
End Class
