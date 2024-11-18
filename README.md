# Projeto de Exercícios em VB.NET
Bem-vindo ao repositório de exercícios em VB.NET! Este projeto foi criado para ajudar no aprendizado e aprimoramento das habilidades de programação em Visual Basic .NET (VB.NET) com base nos desafios propostos pelo site Exercism. Cada exercício busca explorar diferentes conceitos e práticas de programação, oferecendo uma base sólida para desenvolvedores iniciantes e intermediários.

## Objetivo do Projeto
Este repositório tem como objetivo resolver e documentar os principais exercícios propostos pelo Exercism, organizando as soluções de forma clara e modular. O objetivo é criar um ambiente de estudos prático, onde cada exercício se torna uma oportunidade de explorar e aplicar conceitos fundamentais do VB.NET, como:

 * Estruturas de controle de fluxo (if, else, switch, loops)
 * Manipulação de strings e arrays
 * Programação orientada a objetos
 * Manipulação de coleções (List, Dictionary, etc.)
 * Implementação de algoritmos e estruturas de dados

## Descrição dos exercicios:
	* TwoFer
		In some English accents, when you say "two for" quickly, it sounds like "two fer". Two-for-one is a way of saying that if you buy one, you also get one for free. So the phrase "two-fer" often implies a two-for-one offer.
		Imagine a bakery that has a holiday offer where you can buy two cookies for the price of one ("two-fer one!"). You take the offer and (very generously) decide to give the extra cookie to someone else in the queue.
		Your task is to determine what you will say as you give away the extra cookie.
		If you know the person's name (e.g. if they're named Do-yun), then you will say:
		One for Do-yun, one for me.
		If you don't know the person's name, you will say you instead.
		One for you, one for me.

		Here are some examples:
		Name	Dialogue
		Alice	One for Alice, one for me.
		Bohdan	One for Bohdan, one for me.
		One for you, one for me.
		Zaphod	One for Zaphod, one for me.*

	* Reverse Strings
		Reversing strings (reading them from right to left, rather than from left to right) is a surprisingly common task in programming.
		For example, in bioinformatics, reversing the sequence of DNA or RNA strings is often important for various analyses,
		such as finding complementary strands or identifying palindromic sequences that have biological significance.
		
		Your task is to reverse a given string.
		Some examples:
		Turn "stressed" into "desserts".
		Turn "strops" into "sports".
		Turn "racecar" into "racecar".*

	*Allergies
		Given a person's allergy score, determine whether or not they're allergic to a given item, and their full list of allergies.
		An allergy test produces a single numeric score which contains the information about all the allergies the person has (that they were tested for).
		The list of items (and their value) that were tested are: 
			eggs(1)
			peanuts (2)
			shellfish (4)
			strawberries (8)
			tomatoes (16)
			chocolate (32)
			pollen (64)
			cats (128)

		So if Tom is allergic to peanuts and chocolate, he gets a score of 34.
		Now, given just that score of 34, your program should be able to say:
			Whether Tom is allergic to any one of those allergens listed above.
			All the allergens Tom is allergic to.

		Note: a given score may include allergens not listed above (i.e. allergens that score 256, 512, 1024, etc.). 
		Your program should ignore those components of the score. For example, if the allergy score is 257, your program should only report the eggs (1) allergy.
		*