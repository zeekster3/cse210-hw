using System;

namespace MyJournal{
 class Journal{
        public List<Entry> entries;

        public Journal(){
            entries = new List<Entry>();
        }

        //Temporary Entry System
        public void AddEntry(string prompt){
            Console.Write(prompt + " ");
            string journal_text = Console.ReadLine();
            Console.Write("How would you rate your entry?(1-5)");
            string rating = Console.ReadLine();
            string currentDate = DateTime.Now.ToString("MM/dd/yyyy");
            entries.Add(new Entry(journal_text, prompt, currentDate, rating));
        }


        //Display Temporary Entries
        public void DisplayEntries(){
            foreach (Entry entry in entries)
            {
                Console.WriteLine(entry.ToString());
            }
        }
        //File Save System - Temporary to Permanent
        public void SaveToFile(){
            Console.Write("Create a Filename: ");
            string filename = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filename)){
                writer.WriteLine("Date, Prompt, Text");

                foreach (Entry entry in entries)
                {
                    writer.WriteLine($"{entry.GetDate()},{entry.GetPrompt()},{entry.GetText()}");
                }
            }
            Console.WriteLine("File Saved");
        }


        //File Loading System
        public void LoadFromFile(){
            Console.Write("Enter the File's name: ");
            string filename = Console.ReadLine();
            entries.Clear();

            using (StreamReader reader = new StreamReader(filename)){
                string headerLine = reader.ReadLine();

                while (!reader.EndOfStream){
                    string entryLine = reader.ReadLine();
                    string[] fields = entryLine.Split(',');
                    string date = fields[0];
                    string prompt = fields[1];
                    string journal_text = fields[2];
                    string rating = fields[3];
                    entries.Add(new Entry(journal_text,prompt, date, rating));
                }
            }

            Console.WriteLine("File Loaded");
        }
    }
}