


using System.Collections;
namespace ArrayListExmp
{
    class Sample
    {
        public int GetNumber()
        {
            return 10;
        }
        public string GetString()
        {
            return "Pithani Shanmukha Sai Kiran";
        }

        public double GetNumber2()
        {
            return 10.433;
        }

        public Employee GetEmployee()
        {
            return new Employee() { EmployeeName = "Shanmukha Sai Kiran Pithani" };
        }
    }
    class Employee
    {
        public string EmployeeName { get; set; }
    }




    class ArrayListExamp
    {
        static void Main()
        {
            ArrayList al = new ArrayList() { 100,'A'};
            
            Sample s = new Sample();
            al.Add(s.GetNumber());
            al.Add(s.GetString());
            al.Add(s.GetNumber2());
            al.Add(s.GetEmployee());

            foreach(var item in al)
            {
                if(item is Employee emp)
                {
                    Console.WriteLine(emp.EmployeeName);
                }
                else
                {
                    Console.WriteLine(item);
                }
                
            }

        }
    }
}
