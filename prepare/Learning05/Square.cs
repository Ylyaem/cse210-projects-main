public class Square : Shape
{
    private double _side ;

    public double side
    { 
        get {return _side ;}
        set {_side = value ;}
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}