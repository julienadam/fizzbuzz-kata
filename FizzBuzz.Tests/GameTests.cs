using NFluent;

namespace FizzBuzz.Tests;

public class GameTests
{
    [Fact]
    public void Playing_1_on_the_first_round_advances_to_the_next_round()
    {
        var game = new Game();
        
        var newGame = game.Play("1");

        Check.That(newGame.Turn).Equals(2);
    }

    [Fact]
    public void Playing_foo_on_the_first_round_ends_the_game()
    {
        var game = new Game();

        var newGame = game.Play("foo");

        Check.That(newGame).IsInstanceOf<EndedGame>();
    }
}