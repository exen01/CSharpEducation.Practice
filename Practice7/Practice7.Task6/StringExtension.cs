using System.Globalization;

namespace Practice7.Task6;

public static class StringExtension
{
  public static bool IsPalindrome(this string str)
  {
    int len = str.Length - 1;
    int halfLen = len / 2;
    bool isPalindrome = true;

    for (int i = 0; i < halfLen; i++)
    {
      if (str.Substring(i, 1) != str.Substring(len - i, 1))
      {
        isPalindrome = false;
      }
    }

    return isPalindrome;
  }

  public static string ToTitleCase(this string str)
  {
    return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
  }
}