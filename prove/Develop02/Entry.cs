using System;

namespace MyJournal
{
    class Entry
    {

        public string journal_text;
        public string date;

        public Entry(string temp_text, string temp_date){
            journal_text = temp_text;
            date = temp_date;
        }
        public string GetText(){
            return journal_text;
        }

        public string GetDate(){
            return date;
        }

        public override string ToString(){
            return $"Date Written: {date}\n {journal_text}\n";
        }
    }
}