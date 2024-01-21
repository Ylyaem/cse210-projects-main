using System.Runtime.CompilerServices;

public class PromptGenerator
{
    public List<string> _prompts ;


    



    public string GetRandomPrompt()

    {


        _prompts = new List<string>() 

        {"Describe a moment of kindness you experienced.",

        "What made you smile today?" ,

        "List three things you're grateful for right now."} ;


        Random r = new Random();

        int r_index = r.Next(0,2) ;



        return _prompts[r_index] ;

    }
             



}