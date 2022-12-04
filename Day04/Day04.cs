using System.Text.RegularExpressions;

namespace aoc_2022_csharp.Day04;

public class Day04
{
    public static int Part1(string file)
    {
        var count = 0;
        
        var regexMatch = Regex.Match(file, "(\\w+)-(\\w+),(\\w+)-(\\w+)");
        while (regexMatch.Success)
        {
            var ElfA = new {Low = int.Parse(regexMatch.Groups[1].Value), High = int.Parse(regexMatch.Groups[2].Value)};
            var ElfB = new {Low = int.Parse(regexMatch.Groups[3].Value), High = int.Parse(regexMatch.Groups[4].Value)};

            if ((ElfA.Low >= ElfB.Low && ElfA.High <= ElfB.High) || (ElfB.Low >= ElfA.Low && ElfB.High <= ElfA.High))
            {
                count++;
            }
            regexMatch = regexMatch.NextMatch();
        }
        return count;
    }
    
    public static int Part2(string file)
    {
        var count = 0;
        
        var regexMatch = Regex.Match(file, "(\\w+)-(\\w+),(\\w+)-(\\w+)");
        while (regexMatch.Success)
        {
            var ElfA = new {Low = int.Parse(regexMatch.Groups[1].Value), High = int.Parse(regexMatch.Groups[2].Value)};
            var ElfB = new {Low = int.Parse(regexMatch.Groups[3].Value), High = int.Parse(regexMatch.Groups[4].Value)};

            if ( (ElfA.Low >= ElfB.Low && ElfA.Low <= ElfB.High) || (ElfA.High >= ElfB.Low && ElfA.High <=  ElfB.High) || (ElfA.Low <= ElfB.Low && ElfA.High >= ElfB.High))
            {  
                count++;
            }
            regexMatch = regexMatch.NextMatch();
        }
        return count;
    }
}