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
    public void Playing_4_on_the_third_round_ends_the_game()
    {
        var newGame = new Game(3).Play("4");

        Check.That(newGame).IsInstanceOf<EndedGame>();
    }

    [Fact]
    public void Playing_Fizz_on_the_third_round_advances_to_round_4()
    {
        var newGame = new Game(3).Play("Fizz");

        Check.That(newGame).IsNotInstanceOf<EndedGame>();
        Check.That(newGame.Turn).Equals(4);
    }

    [Fact]
    public void Playing_6_on_the_fifth_round_ends_the_game()
    {
        var newGame = new Game(5).Play("6");

        Check.That(newGame).IsInstanceOf<EndedGame>();
    }

    [Fact]
    public void Playing_Buzz_on_the_fifth_round_advances_to_round_6()
    {
        var newGame = new Game(5).Play("Buzz");

        Check.That(newGame).IsNotInstanceOf<EndedGame>();
        Check.That(newGame.Turn).Equals(6);
    }

    [Fact]
    public void Playing_Fizz_on_the_15th_round_ends_the_game()
    {
        var newGame = new Game(15).Play("Fizz");

        Check.That(newGame).IsInstanceOf<EndedGame>();
    }

    [Fact]
    public void Playing_Buzz_on_the_15th_round_ends_the_game()
    {
        var newGame = new Game(15).Play("Buzz");

        Check.That(newGame).IsInstanceOf<EndedGame>();
    }


    [Fact]
    public void Playing_15_on_the_15th_round_ends_the_game()
    {
        var newGame = new Game(15).Play("15");

        Check.That(newGame).IsInstanceOf<EndedGame>();
    }

    [Fact]
    public void Playing_FizzBuzz_on_the_15th_round_advances_to_round_16()
    {
        var newGame = new Game(15).Play("FizzBuzz");

        Check.That(newGame).IsNotInstanceOf<EndedGame>();
        Check.That(newGame.Turn).Equals(16);
    }
}