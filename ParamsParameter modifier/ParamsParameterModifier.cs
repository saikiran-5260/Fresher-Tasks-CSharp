
namespace TestProject
{
    public class ParamsParameterModifier
    {

        public void  paramsParameterModifier(params int[] numbers)
        {
            int total = 0;
            foreach(int i in numbers)
            {
                 total  =  total+ i;
            }
            Console.WriteLine("Sum: {0}",total);
        }
    }
}
