using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class Scripture
{

    private Reference _reference;
    private Random _random = new Random();
    
    private List<Word> _words = new ();

    public Scripture(Reference reference, string text)
    {
       
      _reference = reference;
      string [] words = text.Split(' ');    
      
      foreach(string w in words)
      {
        _words.Add(new Word(w));
      }
    }

    public void HideRandomWords(int numberToHide)
    {       
            while(numberToHide > 0 && !IsCompletelyHidden())
            { 
            int index = _random.Next(_words.Count);
            Word wordToHide  = _words[index];
            if(!wordToHide.IsHidden())
            {
                wordToHide.Hide();
                --numberToHide;     
            }           
        }      
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText();
        foreach(Word word in _words)
        {       
         displayText += " " + word.GetDisplayText();
        }    
        return displayText;    
    }

    public bool IsCompletelyHidden()
    {
        foreach(Word wordText in _words)
        {
            if(!wordText.IsHidden())
            {
                return false;
            }
       }
       return true;
    }
}