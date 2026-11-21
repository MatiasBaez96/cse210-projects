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
            foreach(char w in _text)
            {
                returnValue += "_";
            }
        }
        return returnValue;
    }

   public void Show()
    {
     //muestra la palabra
     _isHidden = false; 
    }
}