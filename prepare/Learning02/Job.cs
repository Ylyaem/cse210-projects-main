using System;

public class Job 
 {// Create member variables in the class for each element

  public string _company = "";
  public string _jobTitle = "";
  public int _startYear = 0;

  public int _endYear = 0; 

  public void Display()

  


   {Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");}
 
 }

