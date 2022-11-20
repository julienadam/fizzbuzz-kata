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

    public Game Play(string input)
    {
        return new Game(2);
    }
}