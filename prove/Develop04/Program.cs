using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");


         Console.WriteLine("Welcome to the Activity Program!");


         while (true)
         {
            Console.WriteLine("Please select an activity to do");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Exit");

            string userChoice = Console.ReadLine();

            switch(userChoice)
            {
                case "1" :

                BreathingActivity b1 = new BreathingActivity();
                b1.run() ;
                break;


                case "2" :
                ListingActivity l1 = new ListingActivity();
                l1.run() ;
                break ;

                case "3" :

                ReflectingActivity r1= new ReflectingActivity() ;
                r1.run();
                break;

                case "4" :
                Console.WriteLine("Good bye, see you soon");
                return ;

                default :

                Console.WriteLine("Please select an activity to do");
                break ;

    


            }
         }

        





    }
}