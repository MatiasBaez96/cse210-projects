public class Reference
{
    // DESDE ACA USO CLASE 'WORD' ??
    // Como empiezo usando esta clase??
    private string _book;
    
    private int _chapter;
    
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        //para qe seria un segundo constructor ?
        // solo si qeremeos agregar una funcionalidad mas?
        _book = book;
        _chapter = chapter;

        //no estoy seguro si esta asignacion es correcta
        _verse = startVerse;
        _endVerse = endVerse;
        
    }

    public string GetDisplayText()
    {
        //esta bien encaminado?
        string text = $"{_book} {_chapter}:{_verse} ";
        return text;
    }

}