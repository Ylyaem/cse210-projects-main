using System  ;
using System.IO ;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;


public class Scripture 
{
    private  Reference _reference ;
    private List<Word> _words ;

    public Scripture(Reference reference, string text)
     {_reference = reference ;
      _words = GetWords(text) ;

     }

     private List<Word> GetWords(string text)
    {
        string[] words = text.Split( new char[]{' '}, StringSplitOptions.RemoveEmptyEntries)  ;
 
        List<Word> wordList = new List<Word>();

        foreach (string word in words)
        {
            Word newWord = new Word(word) ;
            wordList.Add(newWord) ;
            
        }
        return wordList;}


    public void HideRandomWords(int numberToHide)
     {
        Random randomNumber = new Random() ;

         for (int i=0; i< numberToHide; i++ )
         {int index_number = randomNumber.Next(_words.Count) ;
          Word wordToHide = _words[index_number];
          wordToHide.Hide();
          }
    
         
     }

    public string GetDisplayText()
     {
        string displayText = $"{_reference.GetDisplayText()} \n " ;
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() +" " ;


            }
               
        return displayText.Trim() ;


        
        }

    public bool IsCompletelyHidden()
     {
        return _words.All( word => word.IsHidden()) ;

        }




}


    
     




