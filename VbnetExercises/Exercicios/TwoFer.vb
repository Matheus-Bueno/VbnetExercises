Namespace Exercicios
	Public Class TwoFer

		Public Shared Function Speak(Optional name As String = "") As String

			If String.IsNullOrEmpty(name) Then
				Return "One for you, one for me."
			Else
				Return $"One for {name}, one for me."
			End If

		End Function

	End Class

End Namespace