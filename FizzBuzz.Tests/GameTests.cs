using NFluent;

namespace FizzBuzz.Tests;

public class GameTests
{
    [Fact]
    public void Playing_1_on_the_first_round_advances_to_round_2()
    {
        var newGame = new Game().Play("1");

        Check.That(newGame).IsNotInstanceOf<EndedGame>();
        Check.That(newGame.Turn).Equals(2);
    }

    [Fact]
    public void Playing_foo_on_the_first_round_ends_the_game()
    {
        var newGame = new Game().Play("foo");

        Check.That(newGame).IsInstanceOf<EndedGame>();
    }

    [Fact]
    public void Playing_2_on_the_first_round_ends_the_game()
    {
        var newGame = new Game().Play("2");

        Check.That(newGame).IsInstanceOf<EndedGame>();
    }

    [Fact]
    public void Playing_2_on_the_second_round_advances_to_round_3()
    {
        var newGame = new Game(2).Play("2");

        Check.That(newGame).IsNotInstanceOf<EndedGame>();
        Check.That(newGame.Turn).Equals(3);
    }

    [Fact]
    public void Playing_Fizz_on_the_third_round_advances_to_round_4()
    {
        var newGame = new Game(3).Play("Fizz");

        Check.That(newGame).IsNotInstanceOf<EndedGame>();
        Check.That(newGame.Turn).Equals(4);
    }
}