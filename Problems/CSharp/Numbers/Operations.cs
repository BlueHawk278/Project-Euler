namespace CSharp.Numbers;

public static class Operations
{
    /// <summary>
    /// Returns the factorial of a number 5! -> 5 x 4 x 3 x 2 x 1
    /// </summary>
    public static long Factorial(int number)
    {
        long result = 1;

        for (int i = number; i >= 1; i++)
            result *= i;

        return result;
    }
}