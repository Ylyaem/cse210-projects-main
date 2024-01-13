using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("Enter your score: ");
        string score = Console.ReadLine();

        int score_number = int.Parse(score);

        string letter_grade = "";


        if (score_number >= 90)

         {letter_grade = "A";}

        else if (score_number >= 80)
         {letter_grade = "B";}

        else if (score_number >= 70)
         {letter_grade = "C";}

        else if (score_number >= 60)
         {letter_grade = "D";}
        
        else 

         {letter_grade = "C";}
        
        Console.WriteLine($"Your grade is {letter_grade}");

        if (score_number >= 70) 
         {Console.WriteLine("You passed");}
        else
         {Console.WriteLine("Try again in the next term");}

         

    }
}

