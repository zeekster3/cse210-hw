public class Word
{
    private string _word; 
    private string _empty; 
    private string _displayedWord;

    public void SetWord(string w)
    {
        _word = w;
        _displayedWord = _word;
    }
    private string CreateEmpty()
    {

        foreach (char c in _word)
        {  
            _empty += "_";
                    
        }
        return _empty;
    }


   public string GetDisplayedWord()
   {
        return _displayedWord;
   }

   public string ReplaceDisplayedWordWithBlanks()
   {
        _displayedWord = CreateEmpty();
        return _displayedWord;
   }
}