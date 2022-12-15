

namespace ComplexTypeParameter
{
    public class ComplexType
    {
        public string employeeName="";
        public int employeeId;
        public string employeeLocation="";
        public string empSalary;

        public void GetDetails(string EmpName,int EmployeeId,string empLocation)
        {
            employeeName = EmpName;
            employeeId = EmployeeId;
            employeeLocation = empLocation;
            Console.WriteLine(employeeName);
            Console.WriteLine(employeeId);
            Console.WriteLine(employeeLocation);
        }
        public void AddDetails (ComplexType complexType, params string[] p)
        {
            foreach(string i in p)
            {
                Console.WriteLine(i);
            } 
            Console.WriteLine("\n"+complexType.employeeName);
            Console.WriteLine(complexType.employeeId);
            Console.WriteLine(complexType.employeeLocation);
            Console.WriteLine(empSalary+"\n");
        }
    }
}
