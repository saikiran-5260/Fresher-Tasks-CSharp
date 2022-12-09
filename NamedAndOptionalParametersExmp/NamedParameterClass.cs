

namespace NamedParameters
{
    public class NamedParameterClass
    {
        static string _firstName = "";
        static string _middleName = "";
        static string _lastName = "";

        public NamedParameterClass(string firstName, string middleName, string lastname)
        {
            _firstName = firstName;
            _middleName = middleName;
            _lastName = lastname;
            Console.WriteLine("first name is: {0}, middle name is: {1} and last name is: {2}", firstName,middleName,lastname);
        }
    }
}
