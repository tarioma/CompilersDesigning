using CompilersDesigning;

namespace CompilersDesigningTests;

public class DFATests
{
    [Theory]
    [InlineData("01234")]
    [InlineData("12345")]
    [InlineData(" 12345")]
    [InlineData("12345 ")]
    [InlineData("1 2345")]
    [InlineData("0(777)12345")]
    [InlineData("0 (777)12345")]
    [InlineData("0(777) 12345")]
    [InlineData("+373(777)12345")]
    [InlineData("+373 (777)12345")]
    [InlineData("+373(777) 12345")]
    [InlineData("+373(777)1 2345")]
    [InlineData("(777)12345")]
    [InlineData("00(777)12345")]
    public void ConstainsPhone_CorrectPhoneInText_ReturnsTrue(string text)
    {
        // Act
        var result = DFA.ConstainsPhone(text);
        
        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("012345")]
    [InlineData("123456")]
    [InlineData("1234")]
    [InlineData("0(777)123456")]
    [InlineData("+373(777)123456")]
    public void ConstainsPhone_NoPhoneInText_ReturnsFalse(string text)
    {
        // Act
        var result = DFA.ConstainsPhone(text);
        
        // Assert
        Assert.False(result);
    }
}