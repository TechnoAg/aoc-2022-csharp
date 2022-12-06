using System.Text.RegularExpressions;

namespace aoc_2022.Day05;

public class Day05B
{
    public static void Run()
    {
        var lines = File.ReadLines("./input.txt").ToList();
        
        var stacks = new Dictionary<int, Stack<char>>();
        
        //Create Stacks
        for (int i = 1; i <= 9; i++)
        {
            stacks.Add(i, new Stack<char>());
        }
        
        for (int i = 7; i >= 0; i--)
        {
            if (lines[i][1] != ' ') stacks[1].Push(lines[i][1]);           
            if (lines[i][5]  != ' ') stacks[2].Push(lines[i][5]);
            if (lines[i][9]  != ' ') stacks[3].Push(lines[i][9]);
            if (lines[i][13] != ' ') stacks[4].Push(lines[i][13]);
            if (lines[i][17] != ' ') stacks[5].Push(lines[i][17]);
            if (lines[i][21] != ' ') stacks[6].Push(lines[i][21]);
            if (lines[i][25] != ' ') stacks[7].Push(lines[i][25]);
            if (lines[i][29] != ' ') stacks[8].Push(lines[i][29]);
            if (lines[i][33] != ' ') stacks[9].Push(lines[i][33]);
        }
        
        //Helper.DumpStacks2(stacks);
        
        string moveText = string.Join("\r\n", lines.ToArray());
        
        var regexMatch = Regex.Match(File.ReadAllText("./input.txt"), "move (\\d+).*(\\d+).*(\\d+)");
        while (regexMatch.Success)
        {
            var move = new
            {
                Quantity = int.Parse(regexMatch.Groups[1].Value),
                From = int.Parse(regexMatch.Groups[2].Value),
                To = int.Parse(regexMatch.Groups[3].Value)
            };
           
            //Console.WriteLine(move);
            var valsToMove = new List<char>();
        
           for (int i = 1; i <= move.Quantity; i++)
           {
                valsToMove.Add(stacks[move.From].Pop());
           }            
        
            valsToMove.Reverse();
            foreach(var val in valsToMove)
            {
                  stacks[move.To].Push(val);
            }
           
            //Helper.DumpStacks2(stacks);
            regexMatch = regexMatch.NextMatch();
        }
        
        //output 
        //Helper.DumpStacks2(stacks);
        
        //Solution
        string output = string.Empty;
        foreach (var stack in stacks)
        {
            output += stack.Value.Pop();
        }
        System.Console.WriteLine(output);

    }
}