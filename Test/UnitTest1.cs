using BreakingChocolateProblem;
using FluentAssertions;

namespace Test;

public class UnitTest1
{
    [Fact]
    public void BreakingChocolate_OneByOne_ShouldReturnZero()
    {
        var result = Kata.BreakChocolate(1, 1);
        
        result.Should().Be(0);
    }
    
    [Fact]
    public void BreakingChocolate_TwoByOne_ShouldReturnOne()
    {
        var result = Kata.BreakChocolate(2, 1);
        
        result.Should().Be(1);
    }

}