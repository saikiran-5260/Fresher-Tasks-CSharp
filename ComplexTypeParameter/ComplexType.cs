

namespace ComplexTypeParameter
{
    public class ComplexType
    {
        public string employeeName;
        public int employeeId;     
        public int empSalary;
        public Developer d;
        

        public void GetDetails(string EmpName,int EmployeeId,int salary)
        {
            employeeName = EmpName;
            employeeId = EmployeeId;
            empSalary = salary;
            Console.WriteLine(employeeName);
            Console.WriteLine(employeeId);
            Console.WriteLine(empSalary);
            
        }
        public Developer AddDetails(string EmpLocation, string EmpCompanyName, string EmpDesignation)
        {
            d= new Developer();
            d.employeeLocation = EmpLocation;
            d.designation = EmpDesignation;
            d.companyName = EmpCompanyName;
            Console.WriteLine(d.employeeLocation);
            Console.WriteLine(d.companyName);
            Console.WriteLine(d.designation);
            Console.WriteLine("\n");
            return d;
            
        }
    }
    public class Developer
    {
        public string designation;
        public string companyName;
        public string employeeLocation;

    }
}
