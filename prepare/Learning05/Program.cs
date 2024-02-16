using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        List<Shape> shapes = new List<Shape>() ;

        Square square = new Square();
        square.SetColor("Blue") ;
        square.side = 5 ;

        Rectangle rectangle = new Rectangle();
        rectangle.SetColor("Green") ;
        rectangle.lenght = 32.3 ;
        rectangle.width = 21.4 ;

        Circle circle = new Circle();
        circle.SetColor("Orange") ;
        circle.radius = 52.2 ;

        shapes.Add(square) ;
        shapes.Add(rectangle) ;
        shapes.Add(circle) ;

        foreach (Shape shape in shapes) 
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea()}") ;
        }
    }
}