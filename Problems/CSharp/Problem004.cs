namespace CSharp;

public class Problem004
{
    /// <summary>
    /// Returns the largest palindrome made from the product of 2 3-digit numbers.
    /// </summary>
    /// <returns></returns>
    public static int LargestPalindromeProduct()
    {
        int max_palindrome = 0;

        for (int i = 999; i >= 100; i--)
        {
            for (int j = 999; j >= i; j--)
            {
                int num = i * j;

                if (num < max_palindrome)
                    break;

                if (IsPalindrome(Convert.ToString(num)))
                    if (num > max_palindrome)
                        max_palindrome = num;
            }
        }

        return max_palindrome;
    }

    public static bool IsPalindrome(string text) => new string(text.Reverse().ToArray()) == text;

    public static string Execute() => $"The largest palindrome number made form the product of 2 3-digit number is " + LargestPalindromeProduct();
}
