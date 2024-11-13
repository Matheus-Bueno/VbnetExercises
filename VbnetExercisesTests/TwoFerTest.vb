Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports VbnetExercises.Exercicios

Namespace VbnetExercisesTests
    <TestClass>
    Public Class TwoFerTest
        <TestMethod>
        Sub TwoFerSpeakTest()

            ' Arrange
            Dim speak As New TwoFer()

            'Act
            Dim result As String = speak.Speak()

            'Assert
            Assert.AreEqual("One for you, one for me.", result.ToString)
        End Sub


        'Testes do exercism
        <TestMethod>
        Sub NoNameGiven()
            Assert.AreEqual("One for you, one for me.", TwoFer.Speak())
        End Sub

        <TestMethod>
        Sub ANameGiven()
            Assert.AreEqual("One for Alice, one for me.", TwoFer.Speak("Alice"))
        End Sub

        <TestMethod>
        Sub AnotherNameGiven()
            Assert.AreEqual("One for Bob, one for me.", TwoFer.Speak("Bob"))
        End Sub
    End Class
End Namespace

