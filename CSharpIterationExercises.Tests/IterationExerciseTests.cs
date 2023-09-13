using CSharpIterationExercises.Classes;
using System.Collections.Generic;

namespace CSharpIterationExercises.Tests
{

	[TestClass]
	public class IterationExerciseTests
	{

		[TestMethod]
		public void TestNumberOfCenturies()
		{
			List<int> input = new() { 12, 5, -1, 100, 11, 22, 55, 17, 23, -1, 66, 100, 6, 100, 0 };
			int numCenturies = IterationExercises.NumberOfCenturiesScored(input);
			Assert.AreEqual(3, numCenturies);
		}

		[TestMethod]
		public void TestBattingAverage()
		{
			List<int> input = new() { 12, 5, -1, 100, 11, 22, 55, 17, 23, -1, 66, 100, 6, 100, 0 };
			double battingAverage = IterationExercises.BattingAverage(input);
			Assert.AreEqual(39.76923076923077, battingAverage, 0.001);
		}

		[TestMethod]
		public void TestUserNames()
		{
			List<string> input = new() { "Kate", "William", "George", "Charlotte", "Louis" };
			List<string> expected = new() { "Kat1", "Wil2", "Geo3", "Cha4", "Lou5" };
			List<string> result = IterationExercises.UserNames(input);
			CollectionAssert.AreEqual(expected, result);
		}

		[TestMethod]
		public void TestMultiples()
		{
			List<int> expected = new() { 7, 14, 21, 28, 35, 42, 49, 56 };
			List<int> result = IterationExercises.CalculateMultiples(7, 8);
			CollectionAssert.AreEqual(expected, result);
		}

		[TestMethod]
		[DataRow(-1, false)]
		[DataRow(1, false)]
		[DataRow(2, true)]
		[DataRow(3, true)]
		[DataRow(9, false)]
		[DataRow(17, true)]
		[DataRow(22, false)]
		[DataRow(1217, true)]
		[DataRow(1218, false)]
		[DataRow(49, false)]
		public void TestPrimes(int input, bool expectedValue)
		{
			bool isPrime = IterationExercises.CalculatePrimes(input);
			Assert.AreEqual(expectedValue, isPrime);
		}


		[TestMethod]
		public void TestNoughtsAndCrossesXWinsRow()
		{
			List<List<char>> input = new()
			{
				new() { 'X', '0', 'X' },
				new() { ' ', '0', ' ' },
				new() { 'X', 'X', 'X' }
			};
			char winner = IterationExercises.NoughtsAndCrosses(input);
			Assert.AreEqual('X', winner);
		}

		[TestMethod]
		public void TestNoughtsAndCrosses0WinsColumn()
		{
			List<List<char>> input = new()
			{
				new() { 'X', '0', 'X' },
				new() { ' ', '0', ' ' },
				new() { 'X', '0', 'X' }
			};
			char winner = IterationExercises.NoughtsAndCrosses(input);
			Assert.AreEqual('0', winner);
		}

		[TestMethod]
		public void TestNoughtsAndCrossesXWinsDiagonal()
		{
			List<List<char>> input = new()
			{
				new() { 'X', '0', '0' },
				new() { ' ', 'X', ' ' },
				new() { 'X', '0', 'X' }
			};
			char winner = IterationExercises.NoughtsAndCrosses(input);
			Assert.AreEqual('X', winner);
		}

		[TestMethod]
		public void TestNoughtsAndCrosses0WinsDiagonal()
		{
			List<List<char>> input = new()
			{
				new() { 'X', 'X', '0' },
				new() { '0', '0', ' ' },
				new() { '0', 'X', 'X' }
			};
			char winner = IterationExercises.NoughtsAndCrosses(input);
			Assert.AreEqual('0', winner);
		}

		[TestMethod]
		public void TestNoughtsAndCrossesNoWinner()
		{
			List<List<char>> input = new()
			{
				new() { 'X', 'X', '0' },
				new() { ' ', ' ', ' ' },
				new() { '0', 'X', 'X' }
			};
			char winner = IterationExercises.NoughtsAndCrosses(input);
			Assert.AreEqual(' ', winner);
		}


		[TestMethod]
		public void TestNoughtsAndCrossesNoWinnerNoSpaces()
		{
			List<List<char>> input = new()
			{
				new() { 'X', 'X', '0' },
				new() { '0', ' ', ' ' },
				new() { '0', 'X', 'X' }
			};
			char winner = IterationExercises.NoughtsAndCrosses(input);
			Assert.AreEqual(' ', winner);
		}

		[TestMethod]
		public void TestNoughtsAndCrossesXWinsSpacesInTopRow()
		{
			List<List<char>> input = new()
			{
				new() { ' ', ' ', ' ' },
				new() { '0', ' ', '0' },
				new() { 'X', 'X', 'X' }
			};
			char winner = IterationExercises.NoughtsAndCrosses(input);
			Assert.AreEqual('X', winner);
		}
	}

}
