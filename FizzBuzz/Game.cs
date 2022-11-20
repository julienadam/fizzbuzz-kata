namespace FizzBuzz.Tests;

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
        if (input == "1")
        {
            return new Game(2);
        }
        else
        {
            return new EndedGame(this);
        }
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

