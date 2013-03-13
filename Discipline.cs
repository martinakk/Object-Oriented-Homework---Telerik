using System.Text;
public class Discipline :  IComment
{
    private string disciplineName;
    private int numOfLectures;
    private int numOfExercises;

    public string ADiscipline
    {
        get { return this.disciplineName; }
        set { this.disciplineName = value; }
    }
    public int Lectures
    {
        get { return this.numOfLectures; }
        set { this.numOfLectures = value; }
    }

    public int Exercises
    {
        get { return this.numOfExercises; }
        set { this.numOfExercises = value; }
    }

    public Discipline(string disciplineName, int numOfLectures, int numOfExercises)
    {
        this.disciplineName = disciplineName;
        this.numOfExercises = numOfExercises;
        this.numOfLectures = numOfLectures;
    }
    public string AddComment(string comment)
    {
        return comment;
    }
    public override string ToString()
    {
        StringBuilder info = new StringBuilder();
        info.AppendLine("Discipline name: " + this.disciplineName);
        info.AppendLine("Discipline number of lectures: "+ this.numOfLectures);
        info.AppendLine("Discipline number of exercises: "+ this.numOfExercises);
        return info.ToString();
    }
}
