using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassExample
{
    public class Gender
    {

        public string genderTyep;
        public void DisplayDetailsOfGender()
        {
            Console.WriteLine("The gender type is: {0}  and name is: {1}");
        }
    }
}
