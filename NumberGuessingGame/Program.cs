// Number Guessing Game //
bool keepPlaying = true;
int min = 1;
int max = 100;
double coins = 1.00;
int randomNumber;
int userGuess;
int guesses;
string userResponse;



while (keepPlaying & coins > 0)
{
    // Outer Loop Start /
    Random rnd = new Random();
    randomNumber = rnd.Next(1, 101);
    userGuess = 0;
    guesses = 0;
    Console.WriteLine(@" +-+-+-+-+-+-+ +-+-+-+-+-+-+-+-+ +-+-+-+-+
 |N|u|m|b|e|r| |G|u|e|s|s|i|n|g| |G|a|m|e|
 +-+-+-+-+-+-+ +-+-+-+-+-+-+-+-+ +-+-+-+-+");
    Console.WriteLine();
    Console.WriteLine($"> You have {coins} coins ");
    Console.WriteLine();
    Console.Write("> Please Enter a Coin! ");
    Console.ReadLine();
    Console.Clear();
    coins -= 1;

    while (userGuess != randomNumber)
    {   // Innner Loop Start //
        Console.WriteLine($"> Number of Guesses: * {guesses} *");
        Console.WriteLine();
        Console.Write($"> Please Enter a Number between {min} and {max}: ");
        userGuess = int.Parse(Console.ReadLine());
        if (randomNumber > userGuess)
        {
            Console.WriteLine();
            Console.WriteLine("> Too low, try again. ");
            Console.WriteLine();


        }
        else if (randomNumber < userGuess)
        {
            Console.WriteLine();
            Console.WriteLine("> Too high, try again. ");
            Console.WriteLine();

        }
        guesses++;
        // Break out of Inner Loop //
    }
    // Outter Loop Continue // 
    Console.Clear();
    Console.WriteLine($"> YOU WON THE GAME! Number of Guesses: {guesses}");
    Console.WriteLine();
    Console.WriteLine($"> You have {coins} coins left! ");
    Console.WriteLine();
    Console.Write("> Would You Like to Continue(Y/N) ");
    userResponse = Console.ReadLine();
    Console.Clear();

    if (userResponse?.ToUpper() == "Y" && coins > 0)
    {
        keepPlaying = true;
    }
    else if (userResponse?.ToUpper() == "N")
    {
        keepPlaying = false;
        Console.WriteLine();
        Console.Write("> Sounds Good! See you next time!");
        Console.ReadKey();
    }

    else if (coins == 0)
    {
        keepPlaying = false;
        Console.WriteLine(@" +-+-+-+-+ +-+-+-+-+
 |G|a|m|e| |O|v|e|r|
 +-+-+-+-+ +-+-+-+-+");
        Console.WriteLine();
        Console.Write("> OH NO! You are out of coins! ");
        Console.ReadKey();

    }
    else
    {
        Console.WriteLine("> Please Enter a Valid Choice");
    }

    // Break out of Outer Loop // 

}









