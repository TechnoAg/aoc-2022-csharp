namespace aoc_2022_csharp.Day03;

public class Day03
{
    private const string PriorityValues = " abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

    public static int ExecuteA(IEnumerable<string> file)
    { 
        var sum = file.Select(x =>
                new
                {
                    A = x.Substring(0, x.Length / 2),
                    B = x.Substring(x.Length / 2, x.Length - (x.Length / 2))
                })
            .Select(x => x.A.Intersect(x.B).Single())
            .Select(x => PriorityValues.IndexOf(x))
            .Sum();
       
        return sum;
    }
    public static int ExecuteB(IEnumerable<string> file)
    {
        var sum = file.Chunk(3)
            .Select(x => x[0].Intersect(x[1]).Intersect(x[2]).Single())
            .Select(x => PriorityValues.IndexOf(x))
            .Sum();

        return sum;
    }
}