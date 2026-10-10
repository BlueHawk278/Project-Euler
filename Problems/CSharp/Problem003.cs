namespace CSharp;

public class Problem003
{
    /// <summary>
    /// Returns the largest prime factor of the number 600851475143.
    /// </summary>
    /// <returns></returns>
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

    public static string Execute()
    {
        return "The largest prime factor of the number 600851475143 is: " + LargestPrimeFactor(600851475143);
    }
}