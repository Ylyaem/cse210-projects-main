using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)


    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcomeMessage();

        string user_name = PromptUserName();
        int user_number = PromptUserNumber();

        int square_number= SquareNumber(user_number);

        DisplayResult(user_name,square_number);




        static void DisplayWelcomeMessage()
        {Console.WriteLine("Welcome to the program!");}

        static string PromptUserName()
        { Console.Write("Please enter your name: ");

          string name = Console.ReadLine() ;

          return name ;
          }

        static int PromptUserNumber()

         { Console.Write("Please enter your favorite number: ");

          int number = int.Parse(Console.ReadLine() ) ;

          return number ;
          }

        static int SquareNumber(int user_number)

        {int square_number = user_number * user_number ;
        
        return square_number ; 
        
        }

        static void DisplayResult(string user_name, int square_number)


         {Console.WriteLine($"Brother {user_name}, the square of your number is {square_number}");}


    

        





        

    }
}
