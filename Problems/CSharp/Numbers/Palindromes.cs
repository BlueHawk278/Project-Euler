namespace CSharp.Numbers;

public static class Palindromes
{
    /// <summary>
    /// Returns all the 6-digit palindrome numbers.
    /// </summary>
    public static IEnumerable<int> GetSixDigitPalindromes()
    {
        for (int i = 999; i > 99; i--)
        {
            int number = i;
            int reverse = 0;
            int palindrome = i * 1000;

            for (int j = 0; j < 3; j++)
            {

                reverse *= 10;
                reverse += number % 10;
                number /= 10;

            }
            yield return palindrome + reverse;
        }
    }
}