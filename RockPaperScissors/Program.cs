Console.WriteLine("Rock Paper Scissors");

while (true)
{
    Console.WriteLine("Are you ready?");
    Console.WriteLine("Let's begin!!!");

    var selectedChoice = SelectChoice();
    var yourChoice = char.Parse(selectedChoice);

    Console.WriteLine($"You selected {yourChoice}");

    var opponentChoice = GetOponentChoice();

    Console.WriteLine($"I choose {opponentChoice}");

    DecideWinner(opponentChoice, yourChoice);
    Console.WriteLine("Do you want to play again?");
    Console.WriteLine("Enter YES to play again or any other key to stop...");

    var playAgain = Console.ReadLine();
    if (playAgain?.ToLower() == "YES")
        continue;
    else
        Console.WriteLine("Was fun to play with you, have a nice day!");
    break;

}

string SelectChoice()
{
    Console.WriteLine("Choose R, P o S: [R]ock, [P]aper or [S]cissors: ");
    var selectedChoice = Console.ReadLine();
    if (selectedChoice?.ToLower() != "r" && selectedChoice?.ToLower() != "p" && selectedChoice?.ToLower() != "s")
    {
        Console.WriteLine("Please select only one letter: R, P, S");
        selectedChoice = SelectChoice();
    }
    return selectedChoice;
}

char GetOponentChoice()
{
    char[] options = new char[] { 'R', 'P', 'S' };
    Random random = new Random();
    int randomIndex = random.Next(0, options.Length);

    return options[randomIndex];
}

void DecideWinner(char opponentChoice, char yourChoice)
{
    if (opponentChoice == yourChoice)
    {
        Console.WriteLine("Tie!");
        return;
    }
    switch (yourChoice)
    {
        case 'R':
        case 'r':
            if (opponentChoice == 'P')
                Console.WriteLine("Paper beats Rock, I win!");
            else if (opponentChoice == 'S')
                Console.WriteLine("Rock beats Scissors, You win!");
            break;

        case 'P':
        case 'p':
            if (opponentChoice == 'R')
                Console.WriteLine("Paper beats Rock, You win!");
            else if (opponentChoice == 'S')
                Console.WriteLine("Scissors beats Paper, I win!");
            break;

        case 'S':
        case 's':
            if (opponentChoice == 'R')
                Console.WriteLine("Rock beats Scissors, I win!");
            else if (opponentChoice == 'P')
                Console.WriteLine("Scissors beats Paper, You win!");
            break;
        default:
            break;

    }


}