class SimpleGoal : BaseGoal
{
    public SimpleGoal()
    {
        SetType("simple");
        SetStatus(false);
        SetName();
        SetDescription();
        setPoints();
    }
    public override void RecordEvent()
    {
        Console.WriteLine();
    }
    public override string SetGoal()
    {
        return $"{GetType()}#{GetName()}#{GetDescription()}#{GetPoints()}#{GetStatus()}";
    }
    public override void GetGoal()
    {
        
    }
}