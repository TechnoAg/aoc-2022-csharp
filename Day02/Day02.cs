namespace aoc_2022_csharp.Day02;

public static class GameRules
{
    public static readonly List<GamePlayRound> GamePlay = new List<GamePlayRound>()
    {
        new GamePlayRound(HandType.Rock, HandType.Scissors, GameResultType.Lose),
        new GamePlayRound(HandType.Rock, HandType.Paper, GameResultType.Win),
        new GamePlayRound(HandType.Paper, HandType.Rock, GameResultType.Lose),
        new GamePlayRound(HandType.Paper, HandType.Scissors, GameResultType.Win),
        new GamePlayRound(HandType.Scissors, HandType.Paper, GameResultType.Lose),
        new GamePlayRound(HandType.Scissors, HandType.Rock, GameResultType.Win),
        
        //Draws
        new GamePlayRound(HandType.Paper, HandType.Paper, GameResultType.Draw),
        new GamePlayRound(HandType.Rock, HandType.Rock, GameResultType.Draw),
        new GamePlayRound(HandType.Scissors, HandType.Scissors, GameResultType.Draw)
    };
}

public class HandType
{
    private static readonly List<HandType> _mapping = new List<HandType>();

    public string Name { get; private set; }
    public int Score { get; private set; }
    public string Codes { get; private set; }
    
    private HandType(string name, int score, string codes)
    {
        Name = name;
        Score = score;
        Codes = codes;
        _mapping.Add(this);
    }

    public static HandType Parse(char code)
    {
        return _mapping.Single(x => x.Codes.Contains(code));
    }
    
    public static HandType Rock = new HandType("rock", 1, "AX");
    public static HandType Paper = new HandType("paper", 2, "BY");
    public static HandType Scissors = new HandType("scissors", 3, "CZ");
}

public class GameResultType
{
    private static readonly List<GameResultType> _mapping = new List<GameResultType>();

    public string Name { get; private set; }
    public int Score { get; private set; }
    public string Codes { get; private set; }
    
    private GameResultType(string name, int score, string codes)
    {
        Name = name;
        Score = score;
        Codes = codes;
        _mapping.Add(this);
    }

    public static GameResultType Parse(char code)
    {
        return _mapping.Single(x => x.Codes.Contains(code));
    }
    
    public static GameResultType Win = new GameResultType("win", 6, "Z");
    public static GameResultType Draw = new GameResultType("draw", 3, "Y");
    public static GameResultType Lose = new GameResultType("lose", 0, "X");
}

public class GamePlayRound
{
    public HandType Opponent { get; private set; }
    public HandType Response { get; private set; }
    public GameResultType Result { get; private set; }

    public int Score => Response.Score + Result.Score;

    public GamePlayRound(HandType opponent, HandType response, GameResultType result)
    {
        Opponent = opponent;
        Response = response;
        Result = result;
    }
}

public class Day02
{
    public static int Part1(IEnumerable<string> file)
    {
        var totalScore = file.Select(x => new {opp = HandType.Parse(x[0]), resp = HandType.Parse(x[2])})
            .Select(x => GameRules.GamePlay.Single(y => x.opp == y.Opponent && x.resp == y.Response))
            .Sum(x => x.Score);
        return totalScore;
    }
    
    public static int Part2(IEnumerable<string> file)
    {
        var totalScore = file.Select(x => new {opp = HandType.Parse(x[0]), result = GameResultType.Parse(x[2])})
            .Select(x => GameRules.GamePlay.Single(y => x.opp == y.Opponent && x.result == y.Result))
            .Sum(x => x.Score);
        return totalScore;
    }
   
}