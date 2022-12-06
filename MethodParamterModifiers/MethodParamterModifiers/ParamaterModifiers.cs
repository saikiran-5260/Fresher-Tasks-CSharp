
namespace MethodParamterModifiers
{
    public class ParamaterModifiers
    {
     
        //default parameter modifier
        public void Add(int x, int y)
        {
            Console.WriteLine("Additon: " + (x+y));
            Console.WriteLine("Subtraction: "+ (x-y));
            Console.WriteLine("Multiplication: " + (x * y));
            Console.WriteLine("Division: " + (x / y));
        }

        //in paramter modifier
        public void Add1(in int x, in int y)
        {
            Console.WriteLine("Additon: " + (x + y));
            Console.WriteLine("Subtraction: " + (x - y));
            Console.WriteLine("Multiplication: " + (x * y));
            Console.WriteLine("Division: " + (x / y));
        }
        //ref paramter modifier
        public void Add2( int x,  int y , ref int add,ref int sub)
        {
            //add = x + y;
            sub = x - y;
            Console.WriteLine("addition: {0} subtraction: {1}",add,sub);
            
        }
        //ref out parameter
        public void Add3( int x, int y, out int add, out int sub)
        {
            add = x + y;
            sub = x - y;
            Console.WriteLine("addition: {0} subtraction: {1}", add, sub);
        }

    }
}
