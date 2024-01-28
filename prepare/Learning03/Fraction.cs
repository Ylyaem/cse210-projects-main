using System.IO.Pipes;
using System ;
using System.Reflection.Metadata.Ecma335;


public class Fraction

{
    private int _top ;
    private int _bottom ;

    public Fraction() 
     {
        _bottom = 1 ;
        _top = 1 ;
     } 
    public Fraction( int wholeNumber)
     {
        _top = wholeNumber ;
        _bottom = 1 ;

        wholeNumber = 5 ;
     }
    public Fraction (int top,int bottom)
     {
        _top = top;
        _bottom = bottom ;
     }

    public int GetTop()

     {return _top ;}

    public void SetTop(int value)
    {_top = value ;} 

    public int GetBottom()
     {return _bottom ;}

    public void SetBottom(int value)
     {_bottom = value ;} 


    public string GetFractionString()
     {string text = $"{_top}/{_bottom}" ;
      return text ;
     }

     public double GetDecimalValue()
     {
        double decimal_value = (double)_top / (double)_bottom ;
        return Math.Round(decimal_value,4 ) ;


     }

     



}