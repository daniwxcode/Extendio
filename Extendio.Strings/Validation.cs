namespace Extendio.Strings;

public static class Validation
{
    public static bool IsNumeric(this string value)
    {
        return !string.IsNullOrEmpty(value) && value.All(char.IsDigit);
    }

}
