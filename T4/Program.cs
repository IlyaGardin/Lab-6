

string input = "3667";
bool isPositiveInteger = input.IsPositiveInteger();
Console.WriteLine("Строка является положительным целым числом: " + isPositiveInteger);

public static class StringExtension
{
    public static bool IsPositiveInteger(this string str)
    {
        if (string.IsNullOrWhiteSpace(str))
        {
            return false;
        }

        foreach (char c in str)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }

        return true;
    }
}