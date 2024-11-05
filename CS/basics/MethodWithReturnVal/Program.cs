Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = Target();
        var roll = Roll();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    return Console.ReadLine().ToUpper() == "Y" ? true : false;
}

string WinOrLose(int target, int roll)
{
    return roll > target ? "You win!" : "You lose!";
}


int Target()
{
    return random.Next(1, 6);
}
int Roll()
{
    return random.Next(1, 7);
}