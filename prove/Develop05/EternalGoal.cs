class EternalGoal : BaseGoal
{

    public EternalGoal()
    {
        SetType("eternal");
        SetName();
        SetDescription();
        setPoints();
        SetGoal();
    }
    public override void RecordEvent()
    {

    }

    public override string SetGoal()
    {
        return "";
    }

    public override void GetGoal()
    {
        
    }
}