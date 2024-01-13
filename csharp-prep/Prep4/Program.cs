using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>() ;

        int sum_total = 0;

        
       



        int user_number = -1 ;

        Console.WriteLine(" Enter a list of numbers, type 0 when finished.");        

        
        
        
        while (true)

        {
            Console.Write("Enter a number ");
            user_number = int.Parse(Console.ReadLine());


            if (user_number != 0)
            {numbers.Add(user_number);}

            else
             break;



        }

        sum_total = numbers.Sum() ;

        Double average = numbers.Average() ;

        double largest_n = numbers.Max();



        foreach (var number in numbers)
        { 
            
        }


        Console.WriteLine($"The total is {sum_total}") ;
        Console.WriteLine($"The average is {average}") ;
        Console.WriteLine($"The largest number is {largest_n}") ;
        
        

        


            
    }








}