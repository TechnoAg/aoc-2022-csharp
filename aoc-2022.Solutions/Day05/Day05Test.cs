using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace aoc_2022_csharp.Day05;

public class Day05Test
{
    private readonly ITestOutputHelper _testOutputHelper;

    private string TEST_FILE = "./Day05/Day05input.txt";
    
    public Day05Test(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }
    
    [Fact]
    public void ValidatePart1()
    {
        var stacks  = Day05.Part1(TEST_FILE);
        _testOutputHelper.WriteLine(Day05Helper.DumpStacks2(stacks));
        
        Assert.True(true);
        
        //output.Should().Be("RFFFWBPNS");
    }
    
    [Fact]
    public void ValidatePart2()
    {
        var sum = Day05.Part2(TEST_FILE);
        _testOutputHelper.WriteLine(sum.ToString());
        sum.Should().Be("soon");
    }
}