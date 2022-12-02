
int operation = Convert.ToInt16(Console.ReadLine()); 
string result;

result = operation switch
{
    1 => "Customer",
    2 => "Employee",
    3 => "Supplier",
    4 => "Distributor",
    5 => "No case Available",

};
Console.WriteLine(result);