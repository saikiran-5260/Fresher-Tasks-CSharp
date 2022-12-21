using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassExample
{
    public class GenderFemale : Gender
    {
        public string FemaleName;
        public int age;

        public void DisplayDetailsFemale()
        {
            Console.WriteLine("The gender type is: {0},name is: {1} and age is: {2}",genderTyep,FemaleName,age);

        }


        
    }
}
