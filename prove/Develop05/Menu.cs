using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Reflection;
using Microsoft.VisualBasic;

class Menu
{
    private int _score = 0;
    private int _input = 0;

    public Menu()
    {
        while (_input != 6)
        {
            _input = DisplayMenu();
        }
    }
    private int DisplayMenu()
    {
        
        Console.WriteLine($"\n\nYou have {_score} points\n");
        Console.WriteLine("Menu Options:\n  1.  Create New Goal\n  2.  List Goals\n  3.  Save Goals\n  4.  Load Goals\n  5.  Record Event\n  6.  Quit");
        Console.Write("Select an option from the menu: ");


        string read = Console.ReadLine();
        if (!int.TryParse(read, out int menuVal))
        {
            Console.Clear();
            Console.WriteLine("\n--------------------------------------------------------------\nInvalid input, Please enter a number 1-6\n--------------------------------------------------------------------\n");
            return 0;
        }

        switch (menuVal)
        {
            case 1: 
                DisplayGoalMenu();
                break;
            case 2: 
                Console.WriteLine("Sucess");
                break;
            case 3:
                Console.WriteLine("Sucess");
                break;
            case 4: 
                Console.WriteLine("Sucess");

                break;
            case 5: 
                Console.WriteLine("Sucess");

                break;
            case 6: //exit

                break;
            default:
                Console.Clear();
                Console.WriteLine("\n------------------------------------------------------------\nInvalid input, Please enter a number 1-6\n--------------------------------------------------------------------\n");
                break;
        }
        return menuVal;
    }

    private void DisplayGoalMenu()
    {
        bool waiting = true;
        while (waiting)
        {
            Console.WriteLine("\nThe types of Goals are:\n  1.  Simple Goal\n  2.  Eternal Goal\n  3.  Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");

            string read = Console.ReadLine();
            if (!int.TryParse(read, out int goalType))
            {
                Console.WriteLine("\n-----------------------------------------------------------\nInvalid input, Please enter a number 1-3\n--------------------------------------------------------------------\n");
            }
            else
            {
                switch (goalType)
                {

                    case 1: 
                        SimpleGoal mySimple = new SimpleGoal();
                        waiting = false;
                        break;
                    case 2: 
                        EternalGoal myEternal = new EternalGoal();
                        waiting = false;
                        break;
                    case 3: 
                        waiting = false;
                        break;
                    default:
                        Console.WriteLine("\n------------------------------------------------------------\nInvalid input, Please enter a number 1-3\n--------------------------------------------------------------------\n");
                        break;
                }
            }

        }
    }
}