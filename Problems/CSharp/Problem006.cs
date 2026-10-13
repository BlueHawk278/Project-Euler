namespace CSharp;

public class Problem006
{
    ///
    /// Finds the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
    ///

    /// <summary>
    /// Returns the sum of the squares from 1 -> n.
    /// </summary>
    public static long SumSquares(int n) => n * (n + 1) * (2 * n + 1) / 6;

    /// <summary>
    /// Returns the square of the sum of the numbers from 1 -> 20
    /// </summary>
    public static double SquareOfSum(int n) => Math.Pow(n * (n + 1) / 2, 2);

    public static string Execute() => "The difference between the sum of the squares of the first 100 natural numbers and the square of the sum is: " + (SquareOfSum(100) - SumSquares(100));
}