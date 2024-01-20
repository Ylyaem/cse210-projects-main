using System;

public class Resume 
 { // Create member variables in the class for each element
 public string _name = "";
 public List <Job> _jobs  = new List<Job>() ;
 public void display_resume()
  {
    Console.WriteLine($"Name: {_name}") ;

    Console.WriteLine("Jobs") ;

    foreach (Job job in _jobs)
    {
      // This calls the Display method on each job
      job.Display();   
    }


  }
 
 }