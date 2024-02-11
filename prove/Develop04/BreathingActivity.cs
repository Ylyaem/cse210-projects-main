public class BreathingActivity : Activity

{
    
    public BreathingActivity(): base("Breathing Activity","This activity will help you to reduced stress and anxiety by breathing")
    {}
    public void run()
    {
        Console.WriteLine("Loading breathing activity...");
        DisplayStartingMessage();

        int totalTime = _duration ;
        int remainingTime = totalTime ;

        while (remainingTime > 0) 
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(5);
            remainingTime -= 5;
            
            if (remainingTime <= 0 )
                break ;


            Console.WriteLine("Breathe out...") ;
            ShowCountDown(5) ;
            remainingTime -= 5;

        }

        DisplayEndingMessage() ; 


    }

}