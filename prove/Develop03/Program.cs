using System;
 //Scripture Reader and Hider by Isaac Tenney
class Program
{
 static void Main(string[] args)
    {        
        Console.Clear();
        Console.WriteLine("Welcome to the Scripture Memorizer!\n");

        
        string chap = "Alma 36";
        int ver = 20;        
        Reference r = new(chap, ver);

        
        List<string> list = ["And", "oh,", "what,", "joy,", "and", "what", "marvelous", "light",
         "I", "did;", "behold;", "yea,", "my", "soul", "was", "filled", "with", "joy", "as", "exceeding", 
         "as", "was", "my", "pain!"];

        Scripture scrip = new(); 
        for (int i = 0; i < list.Count; i++)
        {
            Word word = new();
            word.SetWord(list[i]);
            scrip.SetWords(word);
        }
        scrip.SetRef(r);
        scrip.DisplayScripture();

        Console.WriteLine("Press enter to hide the words or type 'quit' to exit the program");
        string input = Console.ReadLine().ToLower();

        while (input != "quit" || scrip.GetCompletelyHidden() == false)
        {
            Console.Clear();
            scrip.HideRandomWords();
            if (scrip.GetCompletelyHidden() == true)
            {
                Console.WriteLine("All words have been hidden. Type 'quit' to exit the program");
            }
            else
            {
                Console.WriteLine("Press enter to hide words or type 'quit' to exit the program");
            }

            input = Console.ReadLine().ToLower();

        } 

    
    }
    
}