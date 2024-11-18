Namespace Exercicios
    Public Class Allergies
        Private ReadOnly score As Integer
        Private ReadOnly allergies As Dictionary(Of String, Integer)

        Public Sub New(score As Integer)
            Me.score = score
            allergies = New Dictionary(Of String, Integer) From {
                {"eggs", 1},
                {"peanuts", 2},
                {"shellfish", 4},
                {"strawberries", 8},
                {"tomatoes", 16},
                {"chocolate", 32},
                {"pollen", 64},
                {"cats", 128}
            }
        End Sub

        Public Function AllergicTo(allergy As String) As Boolean
            If allergies.ContainsKey(allergy) Then
                Dim allergyScore As Integer = allergies(allergy)
                Return (score And allergyScore) = allergyScore
            End If
            Return False
        End Function

        Public Function List() As IList(Of String)

            Dim result As New List(Of String)
            For Each item In allergies
                If (score And item.Value) = item.Value Then
                    result.Add(item.Key)
                End If
            Next
            Return result
        End Function
    End Class
End Namespace

