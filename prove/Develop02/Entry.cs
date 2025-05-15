using System;

namespace MyJournal
{
    class Entry
    {

        public string journal_text;
        public string date;

        public string prompt;

        public Entry(string temp_text,string temp_prompt, string temp_date){
            journal_text = temp_text;
            date = temp_date;
            prompt = temp_prompt;
        }
        public string GetText(){
            return journal_text;
        }

        public string GetDate(){
            return date;
        }
 public string GetPrompt(){
            return prompt;
        }
        public override string ToString(){
            return $"Date Written: {date}, Prompt:{prompt}\n {journal_text}\n";
        }
    }
}