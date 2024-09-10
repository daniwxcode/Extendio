using FluentAssertions;
using Extendio.Strings;
namespace Extendio.Tests.Strings;

public class FormatTests
{
    /// <summary>
    /// Test that verifies if the string is correctly reversed.
    /// Test qui vérifie si la chaîne est correctement inversée.
    /// </summary>
    [Fact]
    public void Reverse_ShouldReturnReversedString()
    {
        string value = "hello";

        // Assert that "hello" is reversed to "olleh"
        // Vérifie que "hello" devient "olleh"
        value.Reverse().Should().BeEquivalentTo("olleh");
    }

    /// <summary>
    /// Test that verifies if the method handles null or empty strings correctly.
    /// Test qui vérifie si la méthode gère correctement les chaînes nulles ou vides.
    /// </summary>
    [Fact]
    public void Reverse_ShouldReturnSameString_ForEmptyOrNullString()
    {
        string emptyString = "";
        string nullString = null;
        // Assert that empty or null strings are returned unchanged
        // Vérifie que les chaînes vides ou nulles sont retournées inchangées
        emptyString.Reverse().Should().BeEmpty();
        nullString.Reverse().Should().BeNull();
    }
    /// <summary>
    /// Test that verifies the conversion to title case.
    /// Test qui vérifie la conversion en casse de titre.
    /// </summary>
    [Fact]
    public void ToTitleCase_ShouldReturnTitleCaseString()
    {
        string value = "hello world";            
        value.ToTitleCase().Should().Be("Hello World");
    }

    /// <summary>
    /// Test that verifies title case for an empty or null string.
    /// Test qui vérifie la conversion en casse de titre pour une chaîne vide ou nulle.
    /// </summary>
    [Fact]
    public void ToTitleCase_ShouldReturnSameString_ForEmptyOrNullString()
    {
        string emptyString = "";
        string nullString = null;
        emptyString.ToTitleCase().Should().BeEmpty();
        nullString.ToTitleCase().Should().BeNull();
    }

    /// <summary>
    /// Test that verifies truncation of a string with ellipsis when it exceeds the specified length.
    /// Test qui vérifie la troncature d'une chaîne avec des points de suspension lorsque la longueur dépasse la longueur spécifiée.
    /// </summary>
    [Fact]
    public void Truncate_ShouldReturnTruncatedStringWithEllipsis_WhenStringExceedsMaxLength()
    {
        string value = "This is a long string";

        // Vérifie que la chaîne est tronquée à 10 caractères et qu'elle inclut "..."
        value.Truncate(10).Should().Be("This is a ...");
    }

    /// <summary>
    /// Test that verifies no truncation occurs when string is shorter than or equal to the max length.
    /// Test qui vérifie qu'aucune troncature ne se produit lorsque la chaîne est plus courte ou égale à la longueur maximale.
    /// </summary>
    [Fact]
    public void Truncate_ShouldReturnSameString_WhenStringIsShorterThanOrEqualToMaxLength()
    {
        string shortString = "Short";
        string exactLengthString = "ExactLength";

        // Vérifie que la chaîne reste inchangée si elle est plus courte ou égale à 10 caractères
        shortString.Truncate(10).Should().Be(shortString);
        exactLengthString.Truncate(11).Should().Be(exactLengthString);
    }

    /// <summary>
    /// Test that verifies truncation of a string to the specified number of words with ellipsis.
    /// Test qui vérifie la troncature d'une chaîne au nombre spécifié de mots avec des points de suspension.
    /// </summary>
    [Fact]
    public void TruncateWords_ShouldReturnTruncatedStringWithEllipsis_WhenWordCountExceedsMaxWords()
    {
        string value = "This is a long string with many words";

        // Vérifie que la chaîne est tronquée à 5 mots et qu'elle inclut "..."
        value.TruncateWords(5).Should().Be("This is a long string...");
    }

    /// <summary>
    /// Test that verifies no truncation occurs when the number of words is less than or equal to the max words.
    /// Test qui vérifie qu'aucune troncature ne se produit lorsque le nombre de mots est inférieur ou égal au nombre maximal de mots.
    /// </summary>
    [Fact]
    public void TruncateWords_ShouldReturnSameString_WhenWordCountIsLessThanOrEqualToMaxWords()
    {
        string shortValue = "Short text";
        string exactLengthValue = "Exactly the limit";

        // Vérifie que la chaîne reste inchangée si elle est plus courte ou égale à 4 mots
        shortValue.TruncateWords(4).Should().Be(shortValue);
        exactLengthValue.TruncateWords(3).Should().Be(exactLengthValue);
    }
}
