using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace aoc_2022_csharp.Day01;


public class Day01Tests
{
    private readonly ITestOutputHelper _testOutputHelper;

    public Day01Tests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void ValidateTest()
    {
        var file = File.ReadLines("./Day01/Day01-test.txt");
        
        Day01.Part1(file).Should().Be(24000);
    }
    
    [Fact]
    public void ValidatePart1()
    {
        var file = File.ReadLines("./Day01/Day01.txt");

        var answer = Day01.Part1(file);
        
        _testOutputHelper.WriteLine(answer.ToString());
        
        Assert.True(true);
        
    }
    
    [Fact]
    public void ValidatePart2()
    {
        var file = File.ReadLines("./Day01/Day01.txt");

        var answer = Day01.Part2(file);
        
        _testOutputHelper.WriteLine(answer.ToString());
        
        Assert.True(true);
        
    }
}