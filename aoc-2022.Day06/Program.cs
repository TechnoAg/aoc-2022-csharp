using DequeNet;

var input = File.ReadAllText("./input.txt").ToCharArray();
//var input = "zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw".ToCharArray();

int PartA = 4;
int PartB = 14;
int bufferSize = PartB;

var deque = new Deque<char>();
for (int position = 0; position <= input.Length; position++)
{
    var val = input[position];
    if (deque.Count == bufferSize) deque.PopLeft();
    deque.PushRight(val);
    
    if (deque.Distinct().Count() == bufferSize)
    {
        var indexofDistinct = position + 1;
        Console.WriteLine($"Position: {indexofDistinct}");
        break;
    }
}


