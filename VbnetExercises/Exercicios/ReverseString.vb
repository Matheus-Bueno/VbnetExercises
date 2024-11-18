Namespace Exercicios
    Public Class ReverseString
        Public Shared Function Reverse(ByVal inputString As String) As String
            Dim aux As String = String.Empty
            For Each c As Char In inputString
                aux = c + aux
            Next
            Return aux
        End Function
    End Class
End Namespace

