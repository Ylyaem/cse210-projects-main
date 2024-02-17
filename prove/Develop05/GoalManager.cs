public class GoalManager
{
    private List<Goal> _goals ;
    private int _score ;

    public void Start()
    {
        while(true)
        {
            Console.WriteLine("Please Select and Option") ;
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details") ;
            Console.WriteLine("4. Create Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Exit");

            Console.Write("Enter your choice: ") ;
            string userChoise =Console.ReadLine();

            switch(userChoise)
            {
                case "1":
                    DisplayPlayerInfo();
                    break ;                   

                case "2":
                    ListGoalNames() ;
                    break ;

                case "3":
                    ListGoalDetails() ;
                    break ;

                case "4":
                    CreateGoal() ;
                    break ;

                case "5":
                    RecordEvent() ;
                    break ;

                case "6":
                    SaveGoals() ;
                    break ;

                case "7":
                    LoadGoals() ;
                    break ;

                case "8":

                default :
                    Console.WriteLine("Please select an valid option") ;
                    break ;

            }

        }


    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Your current score is {_score}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("Goals titles: ") ;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine(goal._shortName) ;
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("Goal Details: ") ;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString()) ;
        } 
    }

    public void CreateGoal()
    {
        Console.Write("What kind of goal would you like to create? (Simple,Eternal,Checklist): ");
        string goalType = Console.ReadLine();

        Console.Write("What is the name of your goal?: ") ;
        string goalName = Console.ReadLine() ;

        Console.Write("Enter goal description: ") ;
        string goalDescription = Console.ReadLine();

        Console.Write("What is the value in points for this goal?: ") ;
        int goalPoints = Convert.ToInt32(Console.ReadLine()) ; 

        switch (goalType.ToLower())
        {
            case "simple" :
                _goals.Add(new SimpleGoal(goalName,goalDescription,goalPoints)) ;
                break;

            case "eternal" :
                _goals.Add(new EternalGoal(goalName,goalDescription,goalPoints)) ;
                break ;

            case "checklist" :
                Console.Write("What is your target times for this goal?: ") ;
                int goalTarget = Convert.ToInt32(Console.ReadLine()) ;
                Console.Write("How many bonus give you this target?") ;
                int goalBonus = Convert.ToInt32(Console.ReadLine()) ;
                
                _goals.Add(new ChecklistGoal(goalName,goalDescription,goalPoints,goalTarget,goalBonus)) ;
                break ;

            default:

                Console.WriteLine("Enter a valid goal type") ;
                break;
        }

    }

    public void RecordEvent()
    {
        Console.WriteLine("Record Event");
        Console.WriteLine("Select the goal you achivied");
        for (int i=0;i<_goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i]._shortName}") ;
            }
        
        Console.Write("Enter the goal number: ");
        int goalIndex = Convert.ToInt32(Console.ReadLine()) -1 ;

        if (goalIndex>=0 && goalIndex<=_goals.Count)
            {
                int pointsGained = _goals[goalIndex].RecordEvent();
                _score += pointsGained ;
                Console.WriteLine($"You get {pointsGained} points") ;
                if(_goals[goalIndex].IsComplete())
                    {
                        Console.WriteLine("You Win, Goal Complete!") ;
                    }
                else
                    {Console.WriteLine("Select a valid goal number" );}
            }
    }

    public void SaveGoals()

        {
            using (StreamWriter writer = new StreamWriter("goals.txt"))
                {
                    foreach (Goal goal in _goals)
                        {
                            writer.WriteLine(goal.GetStringRepresentation()) ;
                        
                        }
                }
            Console.WriteLine("Goals saved successfully.");

        }

    public void LoadGoals()
        {
            _goals.Clear();
            using (StreamReader reader = new StreamReader("goals.txt"))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                        {
                            string [] parts = line.Split("|");
                            string type = parts[0] ;
                            string name =parts[1] ;
                            string description = parts[2];
                            int points = Convert.ToInt32(parts[3]) ;

                            switch (type.ToLower())
                                {
                                    case "simple" :
                                        _goals.Add(new SimpleGoal(name,description,points){_isComplete = Convert.ToBoolean(parts[4])}) ;
                                        break ;

                                    case "eternal" :
                                        _goals.Add(new EternalGoal(name,description,points)) ;
                                        break ;

                                    case "checklist" :
                                        int amountCompleted = Convert.ToInt32(parts[4]);
                                        int target = Convert.ToInt32(parts[5]) ;
                                        int bonus = Convert.ToInt32(parts[6]);

                                        _goals.Add(new ChecklistGoal(name,description,points,target,bonus) {_amountCompleted = amountCompleted}) ;


                                        break ;


                                    default:
                                        Console.WriteLine("Type a valid goal type") ;
                                        break ;

                                    
                                }

                        }


                }
        }

    public GoalManager()
        {
            _goals = new List<Goal>() ;
            _score = 0 ;
        }   

}



