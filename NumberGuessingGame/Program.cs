// Number Guessing Game //
bool keepPlaying = true;
int min = 1;
int max = 100;
double coins = 4.00; 
int randomNumber;
int userGuess;
int guesses;
string userResponse;

while (keepPlaying && coins > 0)
{
    // Outer Loop Start /
    Random rnd = new Random();
    randomNumber = rnd.Next(1, 101);
    userGuess = 0;
    guesses = 0;
    Console.WriteLine("*********************");
    Console.WriteLine("Number Guessing Game");
    Console.WriteLine("*********************");
    Console.WriteLine();
    Console.WriteLine($"You have {coins} coins ");
    Console.WriteLine();
    Console.Write("Please Enter a Coin! ");
    Console.ReadLine();
    Console.Clear(); 
    coins -= 1; 
    
    while (userGuess != randomNumber)
    {   // Innner Loop Start //
        Console.WriteLine($"Number of Guesses: * {guesses} *");
        Console.WriteLine(); 
        Console.Write($"Please Enter a Number between {min} and {max}: ");
        userGuess = int.Parse(Console.ReadLine());
        if (randomNumber > userGuess)
        {
            Console.WriteLine();
            Console.WriteLine("Too low, try again. ");
            Console.WriteLine();
            
        }
        else if (randomNumber < userGuess)
        {
            Console.WriteLine();
            Console.WriteLine("Too high, try again. ");
            Console.WriteLine();
            
        }
        guesses++;
        // Break out of Inner Loop //
    }
    // Outter Loop Continue // 
    Console.Clear(); 
    Console.WriteLine("YOU WON THE GAME!!!!!!!");
    Console.WriteLine();
    Console.WriteLine($"You have {coins} coins left! ");
    Console.WriteLine();
    Console.Write("Would You Like to Continue(Y/N) ");
    userResponse = Console.ReadLine();
    Console.Clear(); 

    if (userResponse?.ToUpper() == "Y")
    {
        keepPlaying = true; 
    }
    else if(userResponse?.ToUpper() == "N")
    {
        keepPlaying = false;
        Console.WriteLine();
        Console.Write("Sounds Good! See you next time!");
        Console.ReadLine(); 
    }
    else
    {
        Console.WriteLine("Please Enter a Valid Choice"); 
    }

    // Break out of Outer Loop // 

}
