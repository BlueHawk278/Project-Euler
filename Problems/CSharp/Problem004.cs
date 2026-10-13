namespace CSharp;

public static class Problem004
{
    ///
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// 

    /// <summary>
    /// Returns the largest palindrome made from the product of 2 3-digit numbers (String Approach).
    /// </summary>
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
                {
                    if (num > max_palindrome)
                        max_palindrome = num;
                }
            }
        }

        return max_palindrome;
    }

    /// <summary>
    /// String-based palindrome check
    /// </summary>
    public static bool IsPalindrome(string text) => new string(text.Reverse().ToArray()) == text;

    /// <summary>
    /// Returns the largest palindrome using Pure Arithmetic Reversal.
    /// </summary>
    public static int LargestPalindromeProduct_ArithmeticReversal()
    {
        int max_palindrome = 0;

        for (int i = 999; i >= 100; i--)
        {
            for (int j = 999; j >= i; j--)
            {
                int num = i * j;

                if (num < max_palindrome)
                    break;

                if (IsPalindrome(num))
                {
                    if (num > max_palindrome)
                        max_palindrome = num;
                }
            }
        }

        return max_palindrome;
    }

    /// <summary>
    /// Integer-based math palindrome check
    /// </summary>
    public static bool IsPalindrome(int n)
    {
        int original_num = n;
        int reversed_num = 0;

        while (n > 0)
        {
            int digit = n % 10;
            reversed_num = (reversed_num * 10) + digit;
            n /= 10;
        }

        return original_num == reversed_num;
    }

    /// <summary>
    /// Returns the largest palindrome using the Multiple of 11 Shortcut.
    /// </summary>
    public static int LargestPalindromeProduct_MultipleShortcut()
    {
        int max_palindrome = 0;

        // Find largest 3-digit number divisible by 11
        int start_i = 999;
        while (start_i % 11 != 0)
        {
            start_i--;
        }

        for (int i = start_i; i >= 100; i -= 11)
        {
            for (int j = 999; j >= i; j--)
            {
                int num = i * j;

                if (num < max_palindrome)
                    break;

                if (IsPalindrome(num) && num > max_palindrome)
                {
                    max_palindrome = num;
                }
            }
        }

        return max_palindrome;
    }

    public static string Execute() => $"The largest palindrome number made from the product of 2 3-digit numbers is " + LargestPalindromeProduct();
}