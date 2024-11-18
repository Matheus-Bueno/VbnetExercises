Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports VbnetExercises.Exercicios

Namespace VbnetExercisesTests
    <TestClass>
    Public Class AllergiesTest

        'Testes do exercism

        <TestMethod>
        Public Sub NoAllergiesMeansNotAllergic()
            Dim allergies = New Allergies(0)
            Assert.AreEqual(allergies.AllergicTo("peanuts"), False)
            Assert.AreEqual(allergies.AllergicTo("cats"), False)
            Assert.AreEqual(allergies.AllergicTo("strawberries"), False)
        End Sub

        <TestMethod>
        Public Sub AllergicToEggs()
            Dim allergies = New Allergies(1)
            Assert.AreEqual(allergies.AllergicTo("eggs"), True)
        End Sub

        <TestMethod>
        Public Sub AllergicToEggsInAdditionToOtherStuff()
            Dim allergies = New Allergies(5)
            Assert.AreEqual(allergies.AllergicTo("eggs"), True)
            Assert.AreEqual(allergies.AllergicTo("shellfish"), True)
            Assert.AreEqual(allergies.AllergicTo("strawberries"), False)
        End Sub

        <TestMethod>
        Public Sub NoAllergiesAtAll()
            Dim allergies = New Allergies(0)
            Assert.AreEqual(allergies.List().Count, 0)
        End Sub

        <TestMethod>
        Public Sub AllergicToJustEggs()
            Dim allergies = New Allergies(1)
            CollectionAssert.AreEqual(allergies.List(), New List(Of String) From {
                "eggs"
            })
        End Sub

        <TestMethod>
        Public Sub AllergicToJustPeanuts()
            Dim allergies = New Allergies(2)
            CollectionAssert.AreEqual(allergies.List(), New List(Of String) From {
                "peanuts"
            })
        End Sub

        <TestMethod>
        Public Sub AllergicToEggsAndPeanuts()
            Dim allergies = New Allergies(3)
            CollectionAssert.AreEqual(allergies.List(), New List(Of String) From {
                "eggs",
                "peanuts"
            })
        End Sub

        <TestMethod>
        Public Sub AllergicToLotsOfStuff()
            Dim allergies = New Allergies(248)
            CollectionAssert.AreEqual(allergies.List(), New List(Of String)() From {
                "strawberries",
                "tomatoes",
                "chocolate",
                "pollen",
                "cats"
            })
        End Sub

        <TestMethod>
        Public Sub AllergicToEverything()
            Dim allergies = New Allergies(255)
            CollectionAssert.AreEqual(allergies.List(), New List(Of String)() From {
                "eggs",
                "peanuts",
                "shellfish",
                "strawberries",
                "tomatoes",
                "chocolate",
                "pollen",
                "cats"
            })
        End Sub

        <TestMethod>
        Public Sub IgnoreNonAllergenScoreParts()
            Dim allergies = New Allergies(509)
            CollectionAssert.AreEqual(allergies.List(), New List(Of String)() From {
                "eggs",
                "shellfish",
                "strawberries",
                "tomatoes",
                "chocolate",
                "pollen",
                "cats"
            })
        End Sub

    End Class
End Namespace

