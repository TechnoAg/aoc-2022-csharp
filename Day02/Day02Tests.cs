using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace aoc_2022_csharp.Day02;


public class Day02Tests
{
    private readonly ITestOutputHelper _testOutputHelper;

    public Day02Tests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void ValidateTest()
    {
        var file = File.ReadLines("./Day02/Day02-test.txt");
        Day02.Part1(file).Should().Be(15);
    }
    
    [Fact]
    public void ValidatePart1()
    {
        var file = File.ReadLines("./Day02/Day02.txt");
        var answer = Day02.Part1(file);
        _testOutputHelper.WriteLine(answer.ToString());
        answer.Should().Be(10310);
    }
    
    [Fact]
    public void ValidatePart2()
    {
        var file = File.ReadLines("./Day02/Day02.txt");
        var answer = Day02.Part2(file);
        _testOutputHelper.WriteLine(answer.ToString());
        answer.Should().Be(14859);
    }
}