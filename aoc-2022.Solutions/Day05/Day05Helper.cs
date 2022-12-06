using System.Text;

namespace aoc_2022_csharp.Day05;

public class Day05Helper
{
    public static string DumpStacks2(Dictionary<int, Stack<char>> stacks)
    {

        var output = new StringBuilder();
        
        Dictionary<int, List<char>> stackDump = new Dictionary<int, List<char>>();
        //Create Stacks
        for (int i = 1; i <= 9; i++)
        {
            stackDump.Add(i, new List<char>(stacks[i].ToList()));    
            stackDump[i].Reverse();        
        }

        for (int i = 100;i>0;i--)
        {
            string lineOutput = " ";

            foreach(var column in stackDump)
            {
                if (i <= column.Value.Count )
                {                    
                    var val = column.Value[i-1];
                    lineOutput += " " + val;
                }
                else
                {
                    lineOutput += "  ";
                }
            }

            if (!String.IsNullOrWhiteSpace(lineOutput))
            {
                output.Append(lineOutput + "\r\n");
                //Console.WriteLine(output);
            }
        }

        return output.ToString();
    }
}