namespace aoc_2022_csharp.Day01;

public class Day01
{
    public static int Part1(IEnumerable<string> file)
    {
        var elfCalories = new List<Tuple<int, int>>();

        var elfId = 1;
        var calories = 0;

        var maxCalories = 0;
        var maxCaloriesElfId = 0;
        
        
        foreach (var calorie in file)
        {
            if (!String.IsNullOrEmpty(calorie))
            {
                calories = calories + int.Parse(calorie);
            }
            else
            {
                if (calories > maxCalories)
                {
                    maxCalories = calories;
                    maxCaloriesElfId = elfId;
                }
                elfId++;
                calories = 0; //reset calorie counter
            }
        }

        return maxCalories;
    }
    
    public static int Part2(IEnumerable<string> file)
    {
        var calories = 0;

        var totalElfCalories = new List<int>();
        foreach (var calorie in file)
        {
            if (!String.IsNullOrEmpty(calorie))
            {
                calories = calories + int.Parse(calorie);
            }
            else
            { 
                totalElfCalories.Add(calories);
                calories = 0; //reset calorie counter
            }
        }

        var answer = totalElfCalories.OrderByDescending( x=> x).Take(3).Sum();
        return answer;
    }
}