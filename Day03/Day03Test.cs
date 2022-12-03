using System.Diagnostics;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace aoc_2022_csharp.Day03;

public class Day03Test
{
    private readonly ITestOutputHelper _testOutputHelper;

    public Day03Test(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }
   
    [Fact]
    public void ValidatePart1()
    {
        var file = File.ReadLines("./Day03/Day03input.txt");
        var sum = Day03.ExecuteB(file);
        _testOutputHelper.WriteLine(sum.ToString());
        sum.Should().Be(2567);
    }
    
    [Fact]
    public void ValidatePart2()
    {
        var file = File.ReadLines("./Day03/Day03input.txt");
        var sum = Day03.ExecuteA(file);
        _testOutputHelper.WriteLine(sum.ToString());
        sum.Should().Be(8072);
    }
}

    
    
    
    

  