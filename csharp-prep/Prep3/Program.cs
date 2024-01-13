using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Console.Write("What is the magic number? ");
        int number_magic = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int number_guest = -1;

        while (magicNumber != number_guest )
               
        {Console.Write("What is your guest? ");
        number_guest = int.Parse(Console.ReadLine());
        if (magicNumber > number_guest)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < number_guest)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You get it!");
            }
        }


    

        

}}