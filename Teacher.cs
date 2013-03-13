using System.Collections.Generic;
using System.Text;

public class Teacher : Human, IComment
{
    private List<Discipline> disciplines;

    public List<Discipline> Disciplines
    {
        get { return this.disciplines; }
        set { this.disciplines = new List<Discipline>(); }
    }

    public Teacher(string name, Discipline discipline)
        : base(name)
    {
        disciplines = new List<Discipline>();
        disciplines.Add(discipline);
    }

    public void AddDiscipline(Discipline discipline)
    {
        disciplines.Add(discipline);
    }

    public string AddComment(string comment)
    {
        return comment;
    }
    public override string ToString()
    {
        StringBuilder info = new StringBuilder();
        info.AppendLine("Teacher name: " + this.name);
        info.AppendLine("Teacher disciplines:");
        foreach (var discipline in disciplines)
        {
            info.AppendLine(discipline.ToString());
        }
        return info.ToString();
    }
}
