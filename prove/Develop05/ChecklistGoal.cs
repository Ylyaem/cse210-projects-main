using System.Drawing;
using System.Formats.Tar;

public class ChecklistGoal :Goal
{
    public int _amountCompleted ;
    private int _target ;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus) :base(name,description,points)
    {
        _amountCompleted = 0;
        _target = target ;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _amountCompleted ++;
        if ( _amountCompleted == _target)
            {
                return _points + _bonus ;

            }
        return _points;
    }
    public override bool IsComplete()
    {
        return _amountCompleted == _target;
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} Completed {_amountCompleted}/{_target} times";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName} | {_description} | {_points} | {_amountCompleted} | {_target} | {_bonus}";

    }

    

}