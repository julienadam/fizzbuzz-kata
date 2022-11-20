namespace FizzBuzz;

public class Game
{
    public int Turn { get; }

    public Game(int turn)
    {
        Turn = turn;
    }

    public Game() : this (1)
    {
    }

    public virtual Game Play(string input)
    {
        if (int.TryParse(input, out int parsed))
        {
            return parsed == Turn ? Continue() : End();
        }
        else if(input == "Fizz")
        {
            return Turn % 3 == 0 ? Continue() : End();
        }
        else
        {
            return End();
        }
    }

    private EndedGame End()
    {
        return new EndedGame(this);
    }

    private Game Continue()
    {
        return new Game(Turn + 1);
    }
}

public class EndedGame : Game
{
    public EndedGame(Game g) : base(g.Turn)
    {
        
    }

    public override Game Play(string input)
    {
        throw new InvalidOperationException("Game has ended, cannot play anymore");
    }
}

