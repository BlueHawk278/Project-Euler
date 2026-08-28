namespace CSharp._001;

public class Program
{
    /// <summary>
    /// Returns the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    /// <returns></returns>
    public static int Solve()
    {
        int sum = 0;

        for (int i = 0; i < 1000; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
            }
        }

        return sum;
    }
}