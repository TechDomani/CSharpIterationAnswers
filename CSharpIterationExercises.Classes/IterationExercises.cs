using System.Data;

namespace CSharpIterationExercises.Classes
{
	public static class IterationExercises
	{
		// Q1: Centuries
		// Calculate the number of times a batter scored a century (100 runs) or more in a match
		public static int NumberOfCenturiesScored(List<int> runsScored)
		{
			throw new NotImplementedException();
		}

		// Q2: Batting Average
		// Calculate the batting average.
		// Exclude any values where the runs scored were negative as a negative value indicates that they did not bat in that match.
		public static double BattingAverage(List<int> runsScored)
		{
			throw new NotImplementedException ();
		}

		// Q3: User Names
		// Determine the user names
		// It will be the first three characters of their name and a number, which will be the order of the name in the list.
		public static List<string> UserNames(List<string> names)
		{
			throw new NotImplementedException();
		}

		// Q4: Calculate Multiples
		// Write a function that will output the multiple of a number from 1 to the max number specified
		// So called with 6 and 10 it would output [6, 12, 18, 24, 30, 36, 42, 48, 54, 60]
		// Please write your own test for this function in IterationExerciseTests
		public static List<int> CalculateMultiples(int number, int maximumMultiple)
		{
			throw new NotImplementedException();
		}


		// Q5: Is Prime
		// Write a function to determine whether a number is prime
		public static bool CalculatePrimes(int number)
		{
			throw new NotImplementedException();
		}


		// Q6: Star Pattern
		// Write a procedure to output a star pattern based on the number of stars input
		// So for example if the user enters 6 then it will output:

		//*
		//**
		//***
		//****
		//*****
		//******
		//*****
		//****
		//***
		//**
		//*

		// Call this procedure from Program.cs in order to test it
		

		// Q7: This function should take a noughts and crosses board represented as an character list,
		// A space represents an empty space as shown below.

		/* List<List<char>> board = new()
		 {
			 new() { 'X', '0', 'X' },
			 new() { ' ', '0', ' ' },
			 new() { 'X', '0', ' ' }
		 };*/

		// The function should return a char: 'X' if player X has won, '0' if the player 0 has won,
		// and ' ' if there is currently no winner.
		public static char NoughtsAndCrosses(List<List<char>> board)
		{	
			throw new NotImplementedException();
		}
	}
}
