using System.Data;

namespace CSharpIterationExercises.Classes
{
	public static class IterationExercises
	{
		// Q1: Centuries
		// Calculate the number of times a batter scored a century (100 runs) or more in a match
		public static int NumberOfCenturiesScored(List<int> runsScored)
		{
			int centuries = 0;
			foreach (int run in runsScored)
			{
				if (run >= 100)
				{
					centuries++;
				}
			}
			return centuries;
		}

		// Q2: Batting Average
		// Calculate the batting average.
		// Exclude any values where the runs scored were negative as a negative value indicates that they did not bat in that match.
		public static double BattingAverage(List<int> runsScored)
		{
			double total = 0;
			int matches = 0;
			foreach (int run in runsScored)
			{
				if (run >= 0)
				{
					total += run;
					matches++;
				}
			}
			double average = total / matches;
			return average;
		}

		// Q3: User Names
		// Determine the user names
		// It will be the first three characters of their name and a number, which will be the order of the name in the list.
		public static List<string> UserNames(List<string> names)
		{
			List<string> userNames = new();
			for (int i = 0; i < names.Count; i++)
			{
				userNames.Add(names[i].Substring(0,3) + (i+1)); // Alternative userNames.Add(names[i][..3] + (i+1);
			}
			return userNames;
		}

		// Q4: Calculate Multiples
		// Write a function that will output the multiple of a number from 1 to the max number specified
		// So called with 6 and 10 it would output [6, 12, 18, 24, 30, 36, 42, 48, 54, 60]
		public static List<int> CalculateMultiples(int number, int maximumMultiple)
		{
			List<int> multiples = new List<int>();
			for (int i = 1;i <= maximumMultiple; i++)
			{
				multiples.Add(number*i);
			}
			return multiples;
		}


		// Q5: Is Prime
		// Write a function to determine whether a number is prime
		public static bool CalculatePrimes(int number)
		{
			if (number < 2) return false;
			double squareRoot = Math.Sqrt(number);
			for (int i = 2; i <= Math.Floor(squareRoot); i++)
			{
				if (number % i == 0)
				{
					return false;
				}
			}
			return true;
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
		public static void StarPattern(int number)
		{
			string line = "";
			for (int i = 0;i < number;i++)
			{
				line += "*";
				Console.WriteLine(line);
			}
			for (int i = 0; i < number; i++)
			{
				line = line.Remove(line.Length - 1, 1);
				Console.WriteLine(line);
			}
		}

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
			for (int i = 0; i<3; i++)
			{
				// Check row i
				if (board[i][0] != ' ' && board[i][0] == board[i][1] && board[i][1] == board[i][2])
				{ 				 
					return board[i][0];
				}
				// Check column i
				if (board[0][i] != ' ' && board[0][i] == board[1][i] && board[1][i] == board[2][i])
				{
					return board[0][i];
				}
			}
			if (board[1][1] != ' ') // Check for a space in the centre of the board before check diagonals
			{
				if (board[0][0] == board[1][1] && board[1][1] == board[2][2]) 
				{
					return board[0][0];
				}
				if (board[2][0] == board[1][1] && board[1][1] == board[0][2])
				{
					return board[2][0];
				}
			}
			return ' ';
		}
	}
}
