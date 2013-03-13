using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TestSchool
{
    static void Main()
    {
        List<Class> classes = new List<Class>();                    // Creating a list of Classes in the school
        List<Discipline> disciplines = new List<Discipline>();      // Creating a list of disciplines 
        List<Teacher> teachers = new List<Teacher>();               // Creating a list of Teachers

        List<Student> students = new List<Student>();               //Creating all Students at the school
        students.Add(new Student("Pesho", "98701"));
        students.Add(new Student("Matilda", "98702"));
        students.Add(new Student("Filip", "98703"));
        students.Add(new Student("Dani", "98704"));
        students.Add(new Student("Marina", "98705"));
        students.Add(new Student("Alexandra", "98706"));
        students.Add(new Student("Lili", "98707"));
        students.Add(new Student("Alek", "98708"));
        students.Add(new Student("Misho", "98709"));
        students.Add(new Student("Gosho", "98710"));
        students.Add(new Student("Poli", "98711"));
        students.Add(new Student("Desi", "98712"));
        students.Add(new Student("Shushi", "98713"));
        students.Add(new Student("Shala", "98714"));
        students.Add(new Student("Drundrun", "98715"));
        students.Add(new Student("Drun", "98716"));
        students.Add(new Student("Mitko", "98717"));
        students.Add(new Student("Stamat", "98718"));
        students.Add(new Student("Cheresha", "98719"));
        students.Add(new Student("Blagoi", "98720"));

        disciplines.Add(new Discipline("Biology", 3, 2));           //Adding new disciplines
        disciplines.Add(new Discipline("Phisics", 3, 3));
        disciplines.Add(new Discipline("Math", 2, 3));
        disciplines.Add(new Discipline("Geography", 2, 1));
        disciplines.Add(new Discipline("Foreign Language", 4, 2));

        teachers.Add(new Teacher("Popov", disciplines[0]));         //Creating new Teachers
        teachers[0].AddDiscipline(disciplines[1]);

        teachers.Add(new Teacher("Georgieva", disciplines[1]));
        teachers[1].AddDiscipline(disciplines[4]);

        teachers.Add(new Teacher("Ivanov", disciplines[3]));
        teachers[2].AddDiscipline(disciplines[4]);

        teachers.Add(new Teacher("Shalala", disciplines[2]));
        teachers[3].AddDiscipline(disciplines[3]);

        classes.Add(new Class("11a"));              //Creating First class in the school
        classes[0].AddStudent(students[0]);         //Adding students in the class
        classes[0].AddStudent(students[1]);
        classes[0].AddStudent(students[2]);
        classes[0].AddStudent(students[3]);
        classes[0].AddStudent(students[4]);

        classes[0].AddTeacher(teachers[0]);         //Adding Teachers to the class
        classes[0].AddTeacher(teachers[3]);

        classes.Add(new Class("11b"));              //Creating Second class in the school
        classes[1].AddStudent(students[5]);         //Adding students in the class
        classes[1].AddStudent(students[6]);
        classes[1].AddStudent(students[7]);
        classes[1].AddStudent(students[8]);
        classes[1].AddStudent(students[9]);

        classes[1].AddTeacher(teachers[1]);         //Adding Teachers to the class
        classes[1].AddTeacher(teachers[2]);
        classes[1].AddTeacher(teachers[3]);

        classes.Add(new Class("12a"));              //Creating Third class in the school
        classes[2].AddStudent(students[10]);        //Adding students in the class
        classes[2].AddStudent(students[11]);
        classes[2].AddStudent(students[12]);
        classes[2].AddStudent(students[13]);
        classes[2].AddStudent(students[14]);

        classes[2].AddTeacher(teachers[0]);         //Adding Teachers to the class
        classes[2].AddTeacher(teachers[2]);
        classes[2].AddTeacher(teachers[3]);

        classes.Add(new Class("12b"));              //Creating Forth class in the school
        classes[3].AddStudent(students[15]);        //Adding students in the class
        classes[3].AddStudent(students[16]);
        classes[3].AddStudent(students[17]);
        classes[3].AddStudent(students[18]);
        classes[3].AddStudent(students[19]);

        classes[3].AddTeacher(teachers[1]);         //Adding Teachers to the class
        classes[3].AddTeacher(teachers[3]);


        string commentStudent = "drun drun";        //Adding comment to some of students
        students[12].AddComment(commentStudent);
        string commentStudent2 = "mana-mana ty-ty ry-ry-ry";
        students[9].AddComment(commentStudent2);
        string commentStudent3 = "shalala";
        students[19].AddComment(commentStudent3);

        string commentTeacher = "mana-mana";        //Adding comments to some of teachers
        teachers[2].AddComment(commentTeacher);
        string commentTeacher2 = "ty-ty-ry-ty";
        teachers[3].AddComment(commentTeacher2);
        string commentTeacher3 = "mana-mana";
        teachers[0].AddComment(commentTeacher3);


        Console.WriteLine(classes[0].ToString());       //Printing info about classes
        Console.WriteLine(classes[1].ToString());
        Console.WriteLine(classes[2].ToString());
        Console.WriteLine(classes[3].ToString());

        Console.WriteLine(@"Choose a class by identifier to write a comment.
        Class identifiers: 11a, 11b, 12a, 12b");
        string identify = Console.ReadLine();
        foreach (var aClass in classes)
        {
            if (aClass.identifier == identify)
            {
                Console.WriteLine("Enter your comment:");
                string comment = Console.ReadLine();
                aClass.AddComment(comment);
            }
        }
        Console.WriteLine(@"Choose the number of discipline to write a comment.
            Disciplines:1-Biology
                        2-Phisics
                        3-Math
                        4-Geographi
                        5-Foreign Language");
        int discipline = int.Parse(Console.ReadLine());
        for (int i = 0; i < 5; i++)
        {
            if (disciplines[discipline - 1] == disciplines[i])
            {
                Console.WriteLine("Enter your comment:");
                string comment = Console.ReadLine();
                disciplines[i].AddComment(comment);
            }
        }
    }
}
