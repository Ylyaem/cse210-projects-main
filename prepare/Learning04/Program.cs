using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment a1 = new Assignment("Ely Paz","Multiplication") ;
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions","7.3","8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList()) ;

        WritingAssignment a3 = new WritingAssignment("Jhon Smith","History of Mexico","20th Century") ;
        Console.WriteLine(a3.GetSummary()) ;
        Console.WriteLine(a3.GetWritingInformation());
        
    }
}