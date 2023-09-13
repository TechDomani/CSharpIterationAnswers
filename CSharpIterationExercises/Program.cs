using CSharpIterationExercises.Classes;

namespace CSharpIterationExercises
{
	internal class Program
	{
		static void Main()
		{
			Console.WriteLine("Iteration Exercises");

			// Add your calling code here for the iteration exercises
			// As a minimum you will need to call Q6: Star Pattern to test it as it is a procedure
			
			// Call Q6 Star Pattern
			IterationExercises.StarPattern(11);

			// Call Q7 Noughts and Crosses
			List<List<char>> board = new()
			{
				new() { 'X', '0', 'X' },
				new() { ' ', '0', ' ' },
				new() { 'X', '0', ' ' }
			};
			Console.WriteLine("The winner is: " + IterationExercises.NoughtsAndCrosses(board));

		}
	}
}