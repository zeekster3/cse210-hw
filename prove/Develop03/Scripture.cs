using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;


public class Scripture
{
    private Reference _ref;
    private List<Word> _words = new();
    private Boolean _completelyHidden; 


    public void SetWords(Word word) 
    {

        _words.Add(word);
    }

    public void SetRef(Reference r)
    {
        _ref = r;
    }
    public void DisplayScripture()
    {
        Console.Write($"{_ref.GetReferenceVerse()}: ");
        for (int i = 0; i < _words.Count; i++)
        {
            Console.Write($"{_words[i].GetDisplayedWord()} ");
        }
        Console.WriteLine();
;
    }

    public void HideRandomWords() 
    {

        int count = 2;
        Random random = new();

  
            for (int i = 0; i < count; i++)
            {  
                bool hasBlanks = true;
                int index = random.Next(_words.Count); 
                while (hasBlanks == true)
                {
                    if (_words[index].GetDisplayedWord().Contains('_'))
                    {
                        if (_words.TrueForAll(s => s.GetDisplayedWord().StartsWith('_')))
                        {
                            _completelyHidden = true;
                            break;
                        }
                        else
                        {
                            index = random.Next(_words.Count);
                        }
                        
                    }
                    else
                    {
                        _words[index].ReplaceDisplayedWordWithBlanks();
                        hasBlanks = false;

                    }
                }           
            // }
        }
      
        DisplayScripture();

    }

    public Boolean GetCompletelyHidden()
    {
        return _completelyHidden;
    }
}