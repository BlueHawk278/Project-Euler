namespace CSharp;

public static class Problem005
{
    ///
    /// Returns the smallest number that is evenly divisible by all the numbers from 1 to 20
    /// 

    /// <summary>
    /// Brute forces the check by just looping through the numbers 1 to 20 for each new number to check if its divisible
    /// </summary>
    public static int SmallestMultiple_BruteForce()
    {
        int num = 20; // Start at 20 as it can't be less than 20

        while (true)
        {
            bool evenly_divisible = true;

            for (int i = 1; i <= 20; i++)
            {
                if (num % i != 0)
                { 
                    evenly_divisible = false;
                    break;
                }
            }

            if (evenly_divisible)
                return num;

            num += 20; // Increment by 20 as the number has to be a multiple of 20
        }
    }

    /// <summary>
    /// Uses prime factorisation of all the numbers from 1 to 20 and builds the number from the greatest exponent for each prime number
    /// </summary>
    public static int SmallestMultiple_PrimeFactorisation()
    {
        Dictionary<int, int> maxPrimeCounts = new Dictionary<int, int>();

        for (int i = 2; i <= 20; i++)
        {
            int temp = i;

            for (int divisor = 2; divisor <= temp; divisor++)
            {
                if (temp % divisor == 0)
                {
                    int count = 0;
                    while (temp % divisor == 0)
                    {
                        count++;
                        temp /= divisor;
                    }

                    if (!maxPrimeCounts.ContainsKey(divisor))
                    {
                        maxPrimeCounts[divisor] = count;
                    }
                    else
                    {
                        maxPrimeCounts[divisor] = Math.Max(maxPrimeCounts[divisor], count);
                    }
                }
            }
        }

        int result = 1;
        foreach (var kvp in maxPrimeCounts)
        {
            int prime = kvp.Key;
            int exponent = kvp.Value;
            result *= (int)Math.Pow(prime, exponent);
        }

        return result;
    }


    public static string Execute() => "The smallest number that is evenly divisible by all the numbers from 1 to 20 is: " + SmallestMultiple_PrimeFactorisation();
}