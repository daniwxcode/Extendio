namespace Extendio.Tests.Strings;
using Extendio.Strings;
using FluentAssertions;

public class ValidationTests
{
    [Fact]
    public void IsNumeric_ShouldReturnTrue_ForNumericString()
    {
        string value = "12345";

        value.IsNumeric().Should().BeTrue();
    }

    [Fact]
    public void IsNumeric_ShouldReturnFalse_ForNonNumericString()
    {
        string value = "123a45";

        value.IsNumeric().Should().BeFalse();
    }
}