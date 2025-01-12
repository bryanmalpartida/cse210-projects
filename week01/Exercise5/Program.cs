using System;

class Program
{
    //VALUES FOR PROGRAM
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }
    //WELCOME MESSAGE
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
     //INPUT
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    //INPUT
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    //calculations
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    //PRINT CALCULATIONS
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}