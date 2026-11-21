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
      string [] lista = text.Split(' ');    
      
      foreach(string w in lista)
      {
        _words.Add(new Word(w));
      }
    }

    public void HideRandomWords(int numberToHide)
    {       
            while(numberToHide > 0 && !IsCompletelyHidden())
            {
            //DIVIDIR EN 2 PASOS:
            //Word wordToHide  = new Word(_words[numberToHide].GetDisplayText()); 
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
        string verse = _reference.GetDisplayText();
        foreach(Word w in _words)
        {       
         verse += " " + w.GetDisplayText();
        }    
        return verse;    
    }

    public bool IsCompletelyHidden()
    {
        foreach(Word w in _words)
        {
            if(!w.IsHidden())
            {
                return false;
            }
       }
       return true;
    }
}