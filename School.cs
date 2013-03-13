using System.Collections.Generic;

public class School
{
    private List<Class> schoolClasses;

    public List<Class> ASchool
    {
        get { return this.schoolClasses; }
        set { this.schoolClasses = new List<Class>(value); }
    }

    public void AddClass(List<Class> schoolClasses, Class aClass)
    {
        this.schoolClasses.Add(aClass);
    }
}
