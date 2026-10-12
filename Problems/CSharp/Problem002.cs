namespace CSharp;

public class Problem002
{
    ///
    /// Returns the sum of all the even fibonacci numbers below 4 million.
    /// 

    /// <summary>
    /// Iterates through a standard fibonacci sequence adding to the total if the number is even.
    /// </summary>
    public static long SumEvenFibonacciNumbers(long number)
    {
        long sum = 0;
        long a = 1;
        long b = 2;

        while (b < number)
        {
            if (b % 2 == 0)
            {
                sum += b;
            }
            long temp = a;
            a = b;
            b = temp + b;
        } 
        
        return sum;
    }

    public static string Execute() => $"The sum of all the even fibonacci numbers below 4 million is: {SumEvenFibonacciNumbers(4000000)}";
}