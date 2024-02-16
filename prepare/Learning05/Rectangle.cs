public class Rectangle : Shape
{
    private double _lenght ;
    private double _width ;

    public double lenght
    {
        get {return _lenght ;}
        set {_lenght = value ;}
    }

    public double width
    {
        get {return _width ;}
        set {_width = value;}
    }

    public override double GetArea()
    {
        return _lenght * width;
    }



}