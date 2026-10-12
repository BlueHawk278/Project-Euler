namespace CSharp;

public class Problem003 
{
    ///
    /// Returns the largest prime factor of the number 600851475143
    ///

    /// <summary>
    /// Iterates through every digit from factor 2 until the number has been fully divided.
    /// </summary>
    public static long LargestPrimeFactor(long number)
    {
        long f = 2;
        long n = number;

        while (f * f <= n)
        {
            if (n % f == 0)
                n /= f;
            else
                f++;
        }

        return n > 1 ? n : f;
    }

    /// <summary>
    /// Starts by dividing the number by 2 until the number becomes odd.
    /// Then loops through all the odd digit factors from 3 -> 5 -> 7 etc. until the number has been fully divided.
    /// </summary>
    public static long LargestPrimeFactor_Optimised(long number)
    {
        long n = number;

        while (n % 2 == 0)
            n /= 2;

        if (n == 1)
            return 2;

        long f = 3;

        while (f * f <= n)
        {
            if (n % f == 0)
                n /= f;
            else
                f += 2;
        }

        return n > 1 ? n : f;
    }

    public static string Execute() => "The largest prime factor of the number 600851475143 is: " + LargestPrimeFactor_Optimised(600851475143);
}