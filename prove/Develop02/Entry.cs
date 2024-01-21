public class Entry
 {
    public string _date = "" ;
   
    
    public string _promptText = "" ;

    public string _entryText = "";



    public void Display()

       {
        DateTime dt = DateTime.Now ; 
        _date = dt.ToString();

      



         
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"{_promptText}");


        Console.WriteLine($"{_entryText}") ;       
       }
       
 }

 