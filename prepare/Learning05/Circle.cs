
public class Circle : Shape
{
    private double _radius ;

    public double radius
    {
        get {return _radius;}
        set {_radius = value;}
    }

    public override double GetArea()
    {
        return Math.PI * _radius *_radius;
    }
}