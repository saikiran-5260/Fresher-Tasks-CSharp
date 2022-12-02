using System.Linq.Expressions;

class Student
{
    public int studentId { set; get; }
    public string studentName { set; get; }
    public int studentAge { set; get; }
}
class Program
{
    static void Main()
    {
        Student s = new Student() { studentId = 101, studentName = "sai Kiran", studentAge = 21 };
        Expression<Func<Student, bool>> expression = s => s.studentAge > 12 && s.studentAge < 20;

        Func<Student, bool> myDelegate = expression.Compile();
        bool resutl = myDelegate.Invoke(s);
        Console.WriteLine(resutl);
    }
}


