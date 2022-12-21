using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassExample
{
    public sealed class MaleGender : Gender 
    {
        
        public int age;
        public string name;
        public string description;

        public void DisplayDetailsMale()
        {
            Console.WriteLine("The gender type is: {0},name is: {1} and age is: {2} and male purpose is: {3}",genderTyep,name,age,description);
        }
    }
}
