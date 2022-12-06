using System.Diagnostics;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace aoc_2022_csharp.Day02v2;

public class Day02v2Test
{
    private readonly ITestOutputHelper _testOutputHelper;

    public Day02v2Test(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }
    
    [Fact]
    public void ValidateTest4()
    {
        var file = File.ReadLines("./Day02/Day02.txt");
        var totalScore = Day02PM.ExecuteA(file);
        _testOutputHelper.WriteLine(totalScore.ToString());
        totalScore.Should().Be(10310);
    }
    
    [Fact]
    public void ValidateTest5()
    {
        var file = File.ReadLines("./Day02/Day02.txt");
        var totalScore = Day02PM.ExecuteB(file);
        _testOutputHelper.WriteLine(totalScore.ToString());
        totalScore.Should().Be(14859);
    }
}

    
    
    
    

  