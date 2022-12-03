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
    public void ValidateTest()
    {
        var file = File.ReadLines("./Day02/Day02-test.txt");

        int totalScore = 0;

        foreach (var line in file)
        {
            totalScore = totalScore + Play(line);
        }

        _testOutputHelper.WriteLine(totalScore.ToString());
        totalScore.Should().Be(15);
    }
    
    [Fact]
    public void ValidateTest1()
    {
        var file = File.ReadLines("./Day02/Day02.txt");

        var totalScore = file.Select(Play).Sum(x => x);

        _testOutputHelper.WriteLine(totalScore.ToString());
        totalScore.Should().Be(10310);
    }
    
    public static int Play(string line) => line switch
    {
        "A Y" => 2 + 6,
        "A X" => 1 + 3,
        "A Z" => 3 + 0,
        
        "B X" => 1 + 0,
        "B Y" => 2 + 3,
        "B Z" => 3 + 6,
        
        "C X" => 1 + 6,
        "C Y" => 2 + 0,
        "C Z" => 3 + 3
    };
    
    
    
}

    
    
    
    

  