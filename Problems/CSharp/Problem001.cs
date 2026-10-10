namespace CSharp;

public class Problem001
{
    /// <summary>
    /// Returns the sum of all the multiples of 3 or 5 below 1000.
    /// </summary>
    /// <returns></returns>
    public static int SumOfMultiples3Or5(int number)
    {
        int sum = 0;

        for (int i = 0; i < number; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
            }
        }

        return sum;
    }

    public static string Execute()
    {
        return "The sum of all the multiples of 3 or 5 below 1000 is: " + SumOfMultiples3Or5(1000);
    }
}