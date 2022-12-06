using System.Text.RegularExpressions;

namespace aoc_2022_csharp.Day04;

public class Day04
{
    public class Elf
    {
        public int Low;
        public int High;
    }
    
    private const string TEST_FILE = "./Day04/Day04input.txt";

    public int Main(Func<Elf, Elf, bool> strategy)
    {
        var file = File.ReadAllText(TEST_FILE);
        var count = 0;
        
        var regexMatch = Regex.Match(file, "(\\w+)-(\\w+),(\\w+)-(\\w+)");
        while (regexMatch.Success)
        {
            var ElfA = new Elf(){Low = int.Parse(regexMatch.Groups[1].Value), High = int.Parse(regexMatch.Groups[2].Value)};
            var ElfB = new Elf(){Low = int.Parse(regexMatch.Groups[3].Value), High = int.Parse(regexMatch.Groups[4].Value)};

            if (strategy(ElfA, ElfB))
            {
                count++;
            }

            regexMatch = regexMatch.NextMatch();
        }
        return count;
    }

    public static int Part1()
    {
        var day04 = new Day04();

        var contains = new Func<Elf, Elf, bool>((elfA, elfB) =>
            (elfA.Low >= elfB.Low && elfA.High <= elfB.High) || (elfB.Low >= elfA.Low && elfB.High <= elfA.High));

        return day04.Main(contains);
    }
    
    public static int Part2()
    {
        var day04 = new Day04();

        //My sucky logic
        //var overlap = new Func<Elf, Elf, bool>((elfA, elfB) => (elfA.Low >= elfB.Low && elfA.Low <= elfB.High) || (elfA.High >= elfB.Low && elfA.High <=  elfB.High) || (elfA.Low <= elfB.Low && elfA.High >= elfB.High));
        //Much simplier!
        var overlap =  new Func<Elf, Elf, bool>((elfA, elfB) => (elfA.Low <= elfB.High && elfA.High >= elfB.Low));
        
        return day04.Main(overlap);
    }
}