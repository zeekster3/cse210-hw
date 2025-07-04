using System.Dynamic;

abstract class BaseGoal
{
    private int _points;
    private string _name;
    private string _description;
    private bool _status;
    private string _type;


    public BaseGoal()
    {

    }

    public void setPoints()
    {
        bool numCheck = true;
        int points = 0;
        while (numCheck)
        {
            Console.Write("What is the amount of points associated with this goal?");
            string testpoint = Console.ReadLine();

            if (!int.TryParse(testpoint, out points))
            {
                Console.WriteLine("\n---------------------------------------------------------\nInvalid input, Please enter a number\n--------------------------------------------------------------------\n");
                numCheck = true;
            }
            else
            {
                numCheck = false;
            }
        }
        _points = points;
    }
    public int GetPoints()
    {
        return _points;
    }
    public void SetDescription()
    {
        Console.Write("What is a short description of it?");
        _description = Console.ReadLine();
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetName()
    {
        Console.Write("What is the name of your Goal?");
        string name = Console.ReadLine();
    }
    public string GetName()
    {
        return _name;
    }
    public void SetStatus(bool status)
    {
        _status = status;
    }
    public bool GetStatus()
    {
        return _status;
    }
    public void SetType(string type)
    {
        _type = type;
    }
    public string GetType()
    {
        return _type;
    }
    public virtual string ConvertToTextScreen()
    {
        return $"{GetType()}#{GetName()}#{GetDescription()}#{GetPoints()}#{GetStatus()}";
    }

    public virtual string ConvertToTextFile()
    {
        return "";
    }
    public abstract void RecordEvent();

    public abstract string SetGoal();

    public abstract void GetGoal();
}