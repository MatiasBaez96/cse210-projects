public class Word
{  
    private string _text;
    private bool _isHidden;
    
    public Word(string text)
    {
     _isHidden = false;
     _text = text;
    } 

    public void Hide()
    {  
        _isHidden = true;     
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
 
    public string GetDisplayText()
    {      
        string returnValue = _text;
        if(_isHidden)
        {
            returnValue = "";
            foreach(char character in _text)
            {   
                if(character == ',' || character == ';' || character == '.')
                {
                    returnValue += character;
                }
                else
                {
                    returnValue += "_";    
                }
                
            }
        }
        return returnValue;
    }

   public void Show()
    {
    // show the word
     _isHidden = false; 
    }
}