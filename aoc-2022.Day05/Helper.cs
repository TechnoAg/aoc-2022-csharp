namespace aoc_2022.Day05;

public class Helper
{
    public static void DumpStacks2(Dictionary<int, Stack<char>> stacks)
    {
        Dictionary<int, List<char>> stackDump = new Dictionary<int, List<char>>();
        //Create Stacks
        for (int i = 1; i <= 9; i++)
        {
            stackDump.Add(i, new List<char>(stacks[i].ToList()));    
            stackDump[i].Reverse();        
        }

        for (int i = 100;i>0;i--)
        {
            string output = " ";

            foreach(var column in stackDump)
            {
                if (i <= column.Value.Count )
                {                    
                    var val = column.Value[i-1];
                    output += " " + val;
                }
                else
                {
                    output += "  ";
                }
            }

            if (!String.IsNullOrWhiteSpace(output))
            {
                Console.WriteLine(output);
            }
        }
    }
}