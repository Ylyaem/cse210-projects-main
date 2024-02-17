public class SimpleGoal : Goal

{
    public bool _isComplete;

    public SimpleGoal(string name, string description, int points): base(name,description,points)
    {
        _isComplete = false ;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
            {
                _isComplete = true ;
                return _points ;
            }
        return 0 ;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName} | {_description} | {_points} | {_isComplete}";
    }

}