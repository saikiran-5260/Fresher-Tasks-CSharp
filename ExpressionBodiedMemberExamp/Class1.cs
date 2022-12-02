namespace ClassLibrary1
{
    public class Student
    {
        private string _studentName;

        public int GetStudentNameLength() => _studentName.Length;

        public  Student() => _studentName = "sai";

        public string StudentName
        {
            set => _studentName = value;
            get => _studentName;
        }
            
    }

    
}