using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    //DESDE ACA SACARIA FUNCIONALIDADES DIRECTAMENTE PARA EL MENU "WHILE"
    //MANTIENE SEGUIMIENTO DE LA REFERENCICA Y TEXTO DE LA ESCRITURA
    //ESCONDE PALBRAS Y RECIBIR VISUALIZACION DEL TEXTO
    private List<string> _lista = new List<string>();
    private Reference _reference;
    private Word _wordObj;
    private Random _random = new Random();
    
    
   //como podria usar lista?
    private List<Word> _words = new ();

    public Scripture(Reference reference, string text)
    {
       //creo numero random en el constructor??
       _lista.Clear();
      _reference = reference;
      //_lista = text.Split(new[]{' ', ',' , ';'}, StringSplitOptions.RemoveEmptyEntries).ToList();    
      //solucion a ',' - ';' - '.'
      //dividi  solo por espacios ya agregue if statements en funcion 'Hide()' class 'Word'
      _lista = text.Split(new[]{' '}, StringSplitOptions.RemoveEmptyEntries).ToList();    
      
      foreach(string w in _lista)
      {
        _words.Add(new Word(w));
      }
    }

    public void HideRandomWords()
    {   
        int numberToHide = _random.Next(0, _lista.Count);

        if(!IsCompletelyHidden())
        {
        //sino qedan palabras escondidas se volveria un bucle infinito    
        while(_words[numberToHide].IsHidden())
        {
           numberToHide = _random.Next(0, _lista.Count); 
        }
        // Word wordToHide  = new Word(_words[numberToHide].GetHideText());
        //creo nuevo objeto > con palabra ya usada, y lo escondo 
        Word wordToHide  = new Word(_words[numberToHide].GetDisplayText());
        wordToHide.Hide();
        wordToHide.SetHideText(true);
        _words[numberToHide] = wordToHide;
        }    
    }


    public string GetDisplayText()
    {
        //O mejor creo una string entero? y devuelvo solo string?
        //Lo voy actualizando
        string verse = "";

        List<string> toDisplay = new List<string>(); 
        foreach(Word w in _words)
        {       
            if(w.IsHidden())
            {    
                toDisplay.Add(w.GetHideText());         
            }
            else
            {                
                toDisplay.Add(w.GetDisplayText());
            }
            
            verse = string.Join(" ", toDisplay);
        }    

        return verse;    
    }



    //ARREGLAR
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