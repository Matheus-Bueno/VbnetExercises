Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports VbnetExercises.Exercicios


Namespace VbnetExercisesTests
    <TestClass>
    Public Class ReverseStringTest
        'Testes do exercism
        <TestMethod>
        Public Sub An_empty_string()
            Assert.AreEqual("", ReverseString.Reverse(""))
        End Sub

        <TestMethod>
        Public Sub A_word()
            Assert.AreEqual("tobor", ReverseString.Reverse("robot"))
        End Sub

        <TestMethod>
        Public Sub A_capitalized_word()
            Assert.AreEqual("nemaR", ReverseString.Reverse("Ramen"))
        End Sub

        <TestMethod>
        Public Sub A_sentence_with_punctuation()
            Assert.AreEqual("!yrgnuh m'I", ReverseString.Reverse("I'm hungry!"))
        End Sub

        <TestMethod>
        Public Sub A_palindrome()
            Assert.AreEqual("racecar", ReverseString.Reverse("racecar"))
        End Sub

        <TestMethod>
        Public Sub An_even_sized_word()
            Assert.AreEqual("reward", ReverseString.Reverse("drawer"))
        End Sub

    End Class
End Namespace
