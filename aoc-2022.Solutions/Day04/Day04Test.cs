using System.Diagnostics;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace aoc_2022_csharp.Day04;

public class Day04Test
{
    private readonly ITestOutputHelper _testOutputHelper;

    private string TEST_FILE = "./Day04/Day04input.txt";
    
    public Day04Test(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }
    
    [Fact]
    public void ValidatePart1()
    {
        var sum = Day04.Part1();
        _testOutputHelper.WriteLine(sum.ToString());
        sum.Should().Be(540);
    }
    
    [Fact]
    public void ValidatePart2()
    {
        var sum = Day04.Part2();
        _testOutputHelper.WriteLine(sum.ToString());
        sum.Should().Be(872);
    }
}

    
    
    
    

  