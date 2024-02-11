public class Activity
{
    protected string _name ;
    protected string _description ;
    protected int _duration ;

    public Activity(string name, string description)
    {
        _name = name ;
        _description = description ;    
        _duration = 0 ;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine( $"{_name} Description: {_description}") ;
        SetDuration();
        Console.WriteLine("Will be starting in ... ") ;

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done") ;
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}") ;
    }

    public void SetDuration()
    {
        Console.Write("How many seconds do you want for your session?") ;
        _duration = int.Parse(Console.ReadLine()) ;
    }

    public void ShowSpinner(int seconds)

    {
        for (int i = 0; i<seconds; i++ )
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
        
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds;i > 0; i--) 
        {
            Console.WriteLine($"Countdown: {i} seconds") ;
            Thread.Sleep(1000) ;
        }

    }






}