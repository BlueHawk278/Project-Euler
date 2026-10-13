namespace CSharp.Numbers;

public static class Fibonacci
{
    /// <summary>
    /// Returns all the fibonacci numbers beneath an upper limit.
    /// </summary>
    public static IEnumerable<long> GetFibonacciNumbers(long limit)
    {
        long a = 1;
        long b = 1;

        while (true)
        {
            long next = a + b;

            if (next > limit)
            {
                yield break;
            }

            yield return next;

            a = b;
            b = next;
        }
    }

    /// <summary>
    /// Returns the first n fibonacci numbers.
    /// </summary>
    public static IEnumerable<long> GetFirstNFibonacciNumbers(int n)
    {
        long a = 1;
        long b = 1;

        // Return first number
        yield return a;
        n--;

        // Return the second number
        if (n > 0)
        {
            yield return b;
            n--;
        }

        while (n > 0)
        {
            long next = a + b;
            yield return next;
            n--;

            a = b;
            b = next;
        }
    }
}