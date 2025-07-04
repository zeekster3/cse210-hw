using System.Data;
using System.Runtime.CompilerServices;

class Goals
{
    private string _filename = "record.txt";
    private List<BaseGoal> goals = new List<BaseGoal>();

    public Goals()
    {
        
    }
    public void LoadGoals()
    {
        
    }
    public void AddGoal(BaseGoal goal)
    {
        goals.Add(goal);
    }
}