using System.Text.RegularExpressions;
using Xunit.Abstractions;

namespace aoc_2022_csharp.Day05;

public class Day05
{
    private readonly ITestOutputHelper _testOutputHelper;

    public Day05(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }
    public static Dictionary<int, Stack<char>> Part1(string file)
    {
         var lines = File.ReadLines(file).ToList();

        var stacks = new Dictionary<int, Stack<char>>();

        //Create Stacks
        for (int i = 1; i <= 9; i++)
        {
            stacks.Add(i, new Stack<char>());
        }

        for (int i = 7; i >= 0; i--)
        {
            if (lines[i][1]  != ' ') stacks[1].Push(lines[i][1]);           
            if (lines[i][5]  != ' ') stacks[2].Push(lines[i][5]);
            if (lines[i][9]  != ' ') stacks[3].Push(lines[i][9]);
            if (lines[i][13] != ' ') stacks[4].Push(lines[i][13]);
            if (lines[i][17] != ' ') stacks[5].Push(lines[i][17]);
            if (lines[i][21] != ' ') stacks[6].Push(lines[i][21]);
            if (lines[i][25] != ' ') stacks[7].Push(lines[i][25]);
            if (lines[i][29] != ' ') stacks[8].Push(lines[i][29]);
            if (lines[i][33] != ' ') stacks[9].Push(lines[i][33]);
        }
        
        //_testOutputHelper.WriteLine(Day05Helper.DumpStacks2(stacks));

        string moveText = string.Join("\r\n", lines.ToArray());

        var regexMatch = Regex.Match(File.ReadAllText(file), "move (\\d+).*(\\d+).*(\\d+)");
        while (regexMatch.Success)
        {
            var move = new
            {
                Quantity = int.Parse(regexMatch.Groups[1].Value),
                From = int.Parse(regexMatch.Groups[2].Value),
                To = int.Parse(regexMatch.Groups[3].Value)
            };

            //Helper.DumpStacks2(stacks);
            Console.WriteLine(move);
           
            //execute move
            for (int i = 1; i <= move.Quantity; i++)
            {
                //Console.WriteLine(move);

                var valToMove = stacks[move.From].Pop();
                stacks[move.To].Push(valToMove);
            }

            //Day05Helper.DumpStacks2(stacks);
            regexMatch = regexMatch.NextMatch();
        }

        //var output = Day05Helper.DumpStacks2(stacks);

        return stacks;

    }
    
    public static string Part2(string file)
    {
        return "soon";
    }
    
}