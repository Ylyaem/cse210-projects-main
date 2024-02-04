using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Reference reference = new Reference("2 Nefi",4,16) ;

        string text = "Behold, my soul delighteth in the things of the Lord; and my heart pondereth continually upon the things which I have seen and heard." ;

        Scripture scripture = new Scripture(reference,text) ;
         
        do
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                break ;

                }

            Console.WriteLine("Write 'quit' to exit or press enter to continue") ;
            string userInput = Console.ReadLine();

            if (userInput.ToLower() != "quit")
             {
                scripture.HideRandomWords(1) ;
                }  
            else
            {
                break ;
            }


            

            } while(true) ;
        



    }
}