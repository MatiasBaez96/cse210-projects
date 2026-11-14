public class Word
{
    private string _hideText;
    private string _text;
    private bool _isHidden;
    
    //ACA ESTARIA DIVIDIENDO VERSICULO COMPLETO EN EN 
    //PALABRAS INDIVIDUALES; YDONDE SON ESCONDIDAS O MOSTRADAS
    public Word(string text)
    {
     _hideText = "";
     _hideText = text; 
     _text = text;
    } 

    public void Hide()
    {
        //creo esta bien crear lista cada vez qe llamo  funcion Hide
        //porqe sobreescribo la lista para empeza de cero
        List<string> underScores = new List<string>(); 
        
        foreach(char w in _hideText)
        {
            if(w == ',' || w == ';' || w == '.')continue; 
            underScores.Add("_");
        }
        _hideText = string.Join("",underScores);
        
    }
 
    public bool IsHidden()
    {
        return _isHidden;
    }
    public void SetHideText(bool isHidden)
    {
        _isHidden = isHidden;
    }
    public string GetHideText()
    {
        return _hideText;
    }
    public string GetDisplayText()
    {
        return _text;
    }

   public void Show()
    {
     //BORRAR ? //QUIZAS MOSTRAR OPCION O FUNCIONALIDAD
     //QE MUESTRE TODA LA ORACION COMPLETA   
    }
}