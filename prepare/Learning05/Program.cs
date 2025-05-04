using System;

class Program
{
static void Main(string[] args){
        DisplayWelcome();

        string userName = AskUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
    }

static string AskUserName(){
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

   

static int SquareNumber(int number){
        int result = number * number;
        return result;
    }
static int PromptUserNumber(){
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }
}