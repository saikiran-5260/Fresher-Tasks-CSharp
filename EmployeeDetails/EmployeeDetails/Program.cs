using System;

class EmployeeProject
{
    static void Main()
    {
        Console.WriteLine($"****************{ Employee.OrganizationName }****************");
        Employee.OrganizationName = "Harsha INC";
        //Employee.DepartmentName = "ROD";
        Console.WriteLine($"{Employee.TypeOfEmployee}");
        for (int i = 0; i < 10; i++)
        {
            string EmployeeNumber;
            switch (i)
            {
                case 0: EmployeeNumber = "First Emp"; break;
                case 1: EmployeeNumber = "Second Emp"; break;
                case 2: EmployeeNumber = "Third Emp"; break;
                case 3: EmployeeNumber = "Fourth Emp"; break;
                case 4: EmployeeNumber = "Fifth Emp"; break;
                case 5: EmployeeNumber = "Sixth Emp"; break;
                case 6: EmployeeNumber = "Seventh Emp"; break;
                case 7: EmployeeNumber = "Eighth Emp"; break;
                case 8: EmployeeNumber = "Ninth Emp"; break;
                case 9: EmployeeNumber = "Tenth Emp"; break;
                default : EmployeeNumber = "Other Emp"; break;
            }
            Console.WriteLine(EmployeeNumber);
            Employee emp = new Employee();
            Console.Write("Enter EmpId:");
            emp.EmpId = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter EmpName:");
            emp.EmpName = Console.ReadLine();
            Console.Write("Enter Employee salaryPerHour:");
            emp.SalaryPerHour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter NoOfWorking hours of employee:");
            emp.NoOfHoursWorking = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Employee department:" + emp.DepartmentName);
            emp.NetSalary = emp.SalaryPerHour * emp.NoOfHoursWorking;
            Console.WriteLine($"Employee NetSalary is: {emp.NetSalary}");
            Console.WriteLine("Do you want to proceed with the next employee? choose your choice: y/n");
            string choice = Console.ReadLine(); ;
            if (choice == "no" || choice == "n" || choice == "N")
            {
                break;
            }   
            else if (choice == "Yes" || choice == "Y" || choice == "YES" || choice == "y")
            {
                continue;
            }
            else
            {
                break;
            }
        }
        Console.ReadKey();
    }
   
}