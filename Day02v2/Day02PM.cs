namespace aoc_2022_csharp.Day02v2;

public class Day02PM
{
    public static int ExecuteA(IEnumerable<string> file)
    {
        var sum = file.Select(PlayGameA).Sum();
        return sum;
    }
    
    public static int ExecuteB(IEnumerable<string> file)
    {
        var sum = file.Select(PlayGameB).Sum();
        return sum;
    }
    
    private static int PlayGameA(string line) => line switch
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
    
    private static int PlayGameB(string line) => line switch
    {
        "A X" => 3 + 0,
        "A Y" => 1 + 3,
        "A Z" => 2 + 6,
        
        "B X" => 1 + 0,
        "B Y" => 2 + 3,
        "B Z" => 3 + 6,
        
        "C X" => 2 + 0,
        "C Y" => 3 + 3,
        "C Z" => 1 + 6
    };
    
}