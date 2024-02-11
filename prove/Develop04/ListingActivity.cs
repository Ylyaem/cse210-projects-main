public class ListingActivity : Activity
{
    private int _count ;
    private List<string> _prompts ;

    public ListingActivity():base("Listing Activity","This activity will help you reflect on the good things in your life") 
    {
        _count = 0 ;
        _prompts =  new List<string> {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" } ;
        }

    public void run()

    {
        Console.WriteLine("Loading Listening Activity...") ;
        DisplayStartingMessage() ;

        string prompt = GetRandomPrompt() ;
        Console.WriteLine(prompt) ;
        ShowCountDown(5) ;

        GetListFromUser() ;

        DisplayEndingMessage();
        Console.WriteLine($"You have been completed this activity in {_count} seconds") ;

        

    }

    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count) ;
        return _prompts[index] ;

    
    }

    public List<string> GetListFromUser()
    {
        Console.WriteLine("Enter your response. Press  Enter twice to finish") ;
        List<string> answers = new List<string>() ;
        string answer ;

        do 
        {
            answer = Console.ReadLine() ;
            if (!string.IsNullOrWhiteSpace(answer))
                answers.Add(answer) ;
            
        } while (!string.IsNullOrWhiteSpace(answer)) ;

        return answers ;

        




    }

}

   
