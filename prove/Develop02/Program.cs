using System;
namespace MyJournal{
    class Program{
        static void Main(string[] args){
            Journal journal = new Journal();
            //Prompt List to Pull from
            List<string> prompt = new List<string>
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "What is something you regret doing today?",
                "What was the strongest emotion I felt today",
                "What activity brought you joy today?",
                "If you could redo the day over again, what would you change?",
                "What is the best and worst part of your day?",
                "Write about someone you know:"
            };
            

            bool end = false;
            while (end == false){
                //Menu Display System
                Console.WriteLine();
                Console.WriteLine("Welcome to my Journal Program");
                Console.WriteLine();
                Console.WriteLine("Please pick one:");
                Console.WriteLine("1. Write Entry");
                Console.WriteLine("2. Display Entry");
                Console.WriteLine("3. Save Files");
                Console.WriteLine("4. Load Files");
                Console.WriteLine("5. Exit");

                Console.WriteLine("\nWhat would you like to do? ");
                string choice = Console.ReadLine();

                //Menu Text System
                switch (choice)
                {
                    case "1":
                    string prompt_select = GetAPrompt(prompt);
                        journal.AddEntry(prompt_select);
                        break;
                    case "2":
                        journal.DisplayEntries();
                        break;
                    case "3":
                        journal.SaveToFile();
                        break;
                    case "4":
                        journal.LoadFromFile();
                        break;
                    case "5":
                        end = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            Console.WriteLine("Thanks for Writing, Goodbye!");
            
        }
        //Gives a random prompt from the prompt list, accounting for any size given
         static string GetAPrompt(List<string> prompt)
        {
            Random random = new Random();
            int index = random.Next(prompt.Count);
            return prompt[index];
        }
    }
}