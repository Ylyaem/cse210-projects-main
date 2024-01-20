using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();

        job1._jobTitle = "Accountant";
        job1._company = "Moore Orozco Medina";
        job1._startYear = 2023;
        job1._endYear = 2024;
        

        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Jr Accountant";
        job2._company = "Hernández Ortiz y García Montiel";
        job2._startYear = 2019;
        job2._endYear = 2023;

        job2.Display();

        Resume name1 = new Resume();
         name1._name = "Jhon Smith" ;
         name1._jobs.Add(job1);
         name1._jobs.Add(job2);

         name1.display_resume();


        





    }
}