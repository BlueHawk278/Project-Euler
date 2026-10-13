namespace CSharp;

public static class Problem002
{
    ///
    /// Returns the sum of all the even fibonacci numbers below 4 million.
    /// 

    /// <summary>
    /// Iterates through a standard fibonacci sequence adding to the total if the number is even.
    /// </summary>
    public static long SumEvenFibonacciNumbers(long limit)
    {
        long sum = 0;

        IEnumerable<long> fibonacciNumbers = Numbers.Fibonacci.GetFibonacciNumbers(limit);

        foreach (int num in fibonacciNumbers)
        {
            if (num % 2 == 0)
                sum += num;
        }

        return sum;
    }

    public static string Execute() => $"The sum of all the even fibonacci numbers below 4 million is: {SumEvenFibonacciNumbers(4000000)}";
}