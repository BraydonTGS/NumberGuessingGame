while(true)
{
    Console.WriteLine("*********************"); 
    Console.WriteLine("Number Guessing Game");
    Console.WriteLine("*********************");
    Console.WriteLine();
    Console.Write("Please Enter a Number between 1 and 100: ");

    int userInput = int.Parse(Console.ReadLine());
    Random rnd = new Random();
    int randomNumber = rnd.Next(1,101);
    int userGuess = 0;

    if (randomNumber == userInput)
    {
        Console.WriteLine("YOU WON THE GAME!!!");
        userGuess++;
        Console.WriteLine($"Number of Guesses {userGuess}");
    }
    else if (randomNumber > userInput)
    {
        Console.WriteLine("Too low, try again. ");
        userGuess++;
        Console.WriteLine($"Number of Guesses {userGuess}");
    }
    else if (randomNumber < userInput)
    {
        Console.WriteLine("Too high, try again. ");
        userGuess++;
        Console.WriteLine($"Number of Guesses {userGuess}");
    }
    else
    {
        Console.WriteLine("Something Went Wrong."); 
    }
    Console.Write("Try Again(Y/N)? ");
    string userDecision = Console.ReadLine().ToUpper();
    if (userDecision == "N")
    {
        break;
    }
  
}
