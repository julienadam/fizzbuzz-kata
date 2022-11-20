// See https://aka.ms/new-console-template for more information

using FizzBuzz;

var game = new Game();
while (!(game is EndedGame))
{
    game = game.Play(Console.ReadLine());
}

Console.WriteLine($"You lost at turn {game.Turn}");