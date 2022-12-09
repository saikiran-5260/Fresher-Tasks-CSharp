

using NamedParameters;
using NamedParameters1;

NamedParameterClass npc = new NamedParameterClass( firstName : "Shanmukha",
                                                   middleName: "Sai Kiran",
                                                   lastname: "Pithani");

Console.Write("Enter radius of circle: ");
double r = Convert.ToDouble(Console.ReadLine());  
OptionalParameterClass opc = new OptionalParameterClass(r);