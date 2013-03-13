using System.Text;
public class Student : Human, IComment
{
    private string idNumber;

    public string IdNumber
    {
        get { return this.idNumber; }
        set { this.idNumber = value; }
    }

    public Student(string name, string idNumber)
        : base(name)
    {
        this.idNumber = idNumber;
    }
    public string AddComment(string comment)
    {
        return comment;
    }
    public override string ToString()
    {
        StringBuilder info = new StringBuilder();
        info.AppendLine("Student name: " + this.name);
        info.AppendLine("Student ID Number: "+ this.idNumber);
        return info.ToString();
    }
}
