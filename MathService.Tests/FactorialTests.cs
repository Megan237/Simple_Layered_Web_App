namespace MathService.Tests;

public class UnitTest1
{
    [Fact]
    public void Factorial_BaseValue()
    {
        Assert.Equal(1, FactorialService.GetFactorialValueOf(0));
        Assert.Equal(1, FactorialService.GetFactorialValueOf(1));
    }
    [Fact]
    public void Factorial_PositiveValue()
    {
        Assert.Equal(120, FactorialService.GetFactorialValueOf(5));
        Assert.Equal(5040, FactorialService.GetFactorialValueOf(7));
    }

    [Fact]
    public void Factorial_NegativeValue()
    {
        Assert.Throws<Exception>(() =>
        {
            FactorialService.GetFactorialValueOf(-1);
        });
    }
}