using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        // Here start the code for fraction 
        Fraction f1 = new Fraction();
        f1.SetTop(2) ;
        f1.SetBottom(6);

        Console.WriteLine($"Top: {f1.GetTop()} Bottom: {f1.GetBottom()}") ;
        Console.WriteLine(f1.GetFractionString()) ;
        Console.WriteLine(f1.GetDecimalValue()) ;

               
        
        
        





    }

    
}