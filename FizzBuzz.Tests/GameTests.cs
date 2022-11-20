using NFluent;

namespace FizzBuzz.Tests;

public class GameTests
{
    private readonly Game game = new();

    [Fact]
    public void Playing_1_on_the_first_round_advances_to_round_2()
    {
        var newGame = game.Play("1");

        Check.That(newGame).IsNotInstanceOf<EndedGame>();
        Check.That(newGame.Turn).Equals(2);
    }

    [Fact]
    public void Playing_foo_on_the_first_round_ends_the_game()
    {
        var newGame = game.Play("foo");

        Check.That(newGame).IsInstanceOf<EndedGame>();
    }

    [Fact]
    public void Playing_2_on_the_second_round_advances_to_round_3()
    {
        var newGame = game.Play("1").Play("2");

        Check.That(newGame).IsNotInstanceOf<EndedGame>();
        Check.That(newGame.Turn).Equals(3);
    }
}