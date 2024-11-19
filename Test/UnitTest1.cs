using BreakingChocolateProblem;
using FluentAssertions;

namespace Test;

public class UnitTest1
{
    [Fact]
    public void BreakingChocolate_OneByone_ShouldReturnZero()
    {
        var result = Kata.BreakChocolate(1, 1);
        
        result.Should().Be(0);
    }
}