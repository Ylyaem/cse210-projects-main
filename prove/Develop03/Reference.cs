using System  ;
using System.IO ;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;


public class Reference
 {    private string _book ="" ;
    private int _chapter = 0 ;
    private int _verse = 0 ;
    private int _endverse = 0 ;


    public Reference(string book, int chapter, int verse)
     { _book = book ;
       _chapter = chapter ;
       _verse = verse ;}

    
    public Reference (string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endverse = endVerse ;
        }

    public string GetDisplayText()
    {
        if (_endverse != 0 )
         {return $"{_book} {_chapter}:{_verse}-{_endverse}" ;}
        else
        {return $"{_book} {_chapter}:{_verse}" ; }
        
    }
 }