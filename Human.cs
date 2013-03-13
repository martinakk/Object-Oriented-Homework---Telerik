public class Human 
{
    protected string name;

    public string AHuman
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public Human(string name)
    {
        this.name = name;
    }

}
