public class Fraction
{
    
    private int _top;
    private int _bottom;
    
    public Fraction()
    {
     _top = 1;   
     _bottom = 1;   
    }
    public Fraction(int wholeNumber)
    {
       _top = wholeNumber;
       _bottom = 1; 
    }
    public Fraction(int top,int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public void GetTop()
    {
        
    }
    public void SetTop(int top)
    {
        
    }
    public int GetBottom()
    {
        return _bottom; 
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        //estos dos ejemplos no estan guaradas como una
        //variable miembro, solo es temporal, es una variable
        //local qe sera ejecutada cada vez qe se llame a esta 
        //funcion
        //string text =$"{_top} / {_bottom}"; 
        return $"{_top} / {_bottom}";

    }
    public double GetDecimalValue()
    {
        double decimalValue= Math.Round((double)_top / _bottom, 2);
        return decimalValue;
    }

}