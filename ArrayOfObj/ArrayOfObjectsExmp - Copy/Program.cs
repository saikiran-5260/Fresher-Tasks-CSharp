using ArrayOfObj;

Employee[] employees= new Employee[]
{
    new Employee() { EmpId = 101,EmpName="kiran"},
    new Employee() { EmpId = 103, EmpName = "Abhinav" },
    new Employee() { EmpId = 104, EmpName = "Raju" }
};
foreach(Employee item in employees)
{
    Console.WriteLine(item.EmpId+","+item.EmpName);
}