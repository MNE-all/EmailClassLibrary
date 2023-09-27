using System.Text.RegularExpressions;

namespace EmailClassLibrary;

public static class Email
{
    /// <summary>
    /// Проверяет - является ли строка email-ом
    /// </summary>
    /// <param name="email">строка, которую нужно проверить</param>
    /// <returns></returns>
    public static bool Check(string email)
    {
        return Regex.IsMatch(email, @"^\w+@\w+\..\w+");
    }
}