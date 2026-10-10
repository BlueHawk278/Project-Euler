namespace CSharp;

public class Problem002
{
    /// <summary>
    /// Returns the sum of all the even fibonacci numbers below 4 million.
    /// </summary>
    /// <returns></returns>
    public static int SumEvenFibonacciNumbers(long number)
    {
        int sum = 0;
        int a = 1;
        int b = 2;

        while (b < number)
        {
            if (b % 2 == 0)
            {
                sum += b;
            }
            int temp = a;
            a = b;
            b = temp + b;
        } 
        
        return sum;
    }

    public static string Execute()
    {
        return $"The sum of all the even fibonacci numbers below 4 million is: {SumEvenFibonacciNumbers(4000000)}";
    }
}