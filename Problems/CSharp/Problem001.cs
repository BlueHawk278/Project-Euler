namespace CSharp;

public static class Problem001
{
    ///
    /// Returns the sum of all the multiples of 3 or 5 below 1000.
    /// 

    /// <summary>
    /// Loops through all the numbers from 1 -> 1000 and adds them to a running total if they are a multiple of 3 or 5
    /// </summary>
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

    public static string Execute() => "The sum of all the multiples of 3 or 5 below 1000 is: " + SumOfMultiples3Or5(1000);
}