using System.Globalization;

namespace Extendio.Strings;

public static class Format
{
    /// <summary>
    /// Reverses the characters of the string.
    /// Inverse les caractères de la chaîne.
    /// </summary>
    /// <param name="value">The string to reverse. / La chaîne à inverser.</param>
    /// <returns>
    /// A new string with the characters in reverse order, or the same string if it is null or empty.
    /// Une nouvelle chaîne avec les caractères inversés, ou la même chaîne si elle est nulle ou vide.
    /// </returns>
    public static string Reverse(this string value)
    {
        if (string.IsNullOrEmpty(value)) return value;
        return new string(value.ToCharArray().Reverse().ToArray());
    }
    /// <summary>
    /// Converts the string to title case (first letter of each word capitalized).
    /// Convertit la chaîne en casse de titre (première lettre de chaque mot en majuscule).
    /// </summary>
    /// <param name="value">The string to convert. / La chaîne à convertir.</param>
    /// <returns>
    /// A new string in title case. / Une nouvelle chaîne en casse de titre.
    /// </returns>
    public static string ToTitleCase(this string value)
    {
        if (string.IsNullOrEmpty(value)) return value;
        var cultureInfo = System.Globalization.CultureInfo.CurrentCulture;
        var textInfo = cultureInfo.TextInfo;
        return textInfo.ToTitleCase(value.ToLower());
    }
    /// </summary>
    /// <summary>
    /// Truncates the string to the specified length and adds ellipsis ("...") if the string exceeds the length.
    /// Tronque la chaîne à la longueur spécifiée et ajoute des points de suspension ("...") si la chaîne dépasse cette longueur.
    /// </summary>
    /// <param name="value">The string to truncate. / La chaîne à tronquer.</param>
    /// <param name="maxLength">The maximum length of the truncated string (including ellipsis). / La longueur maximale de la chaîne tronquée (y compris les points de suspension).</param>
    /// <returns>
    /// A truncated string with ellipsis if the original string exceeds the specified length; otherwise, the original string.
    /// Retourne une chaîne tronquée avec des points de suspension si la chaîne d'origine dépasse la longueur spécifiée, sinon retourne la chaîne d'origine.
    /// </returns>
    public static string Truncate(this string value, int maxLength)
    {
        if (string.IsNullOrEmpty(value) || value.Length <= maxLength) return value;
        return value.Substring(0, maxLength) + "...";
    }
    /// <summary>
    /// Truncates the string to the specified number of words and adds ellipsis ("...") if the string exceeds the word limit.
    /// Tronque la chaîne au nombre spécifié de mots et ajoute des points de suspension ("...") si la chaîne dépasse la limite de mots.
    /// </summary>
    /// <param name="value">The string to truncate. / La chaîne à tronquer.</param>
    /// <param name="maxWords">The maximum number of words in the truncated string (including ellipsis). / Le nombre maximum de mots dans la chaîne tronquée (y compris les points de suspension).</param>
    /// <returns>
    /// A truncated string with ellipsis if the original string exceeds the word limit; otherwise, the original string.
    /// Retourne une chaîne tronquée avec des points de suspension si la chaîne d'origine dépasse la limite de mots, sinon retourne la chaîne d'origine.
    /// </returns>
    public static string TruncateWords(this string value, int maxWords)
    {
        if (string.IsNullOrEmpty(value) || maxWords <= 0) return value;

        var words = value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        if (words.Length <= maxWords) return value;

        return string.Join(" ", words.Take(maxWords)) + "...";
    }


}
