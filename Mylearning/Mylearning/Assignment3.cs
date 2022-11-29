class NearestThousand
{
static void Main()
        {
            System.Console.Write("Enter the number:");
            int number = Convert.ToInt32(System.Console.ReadLine());

            decimal decimal_number = number; 

            
            int previous_thousand = number / 1000 * 1000; 

            
            decimal last_three_digits_x = decimal_number / 1000; 
            decimal last_three_digits_y = number / 1000; 

            decimal last_three_digits = (last_three_digits_x - last_three_digits_y) * 1000; 


            int rounding_value = (last_three_digits >= 500) ? 1000 : 0; 

            int is_less_than_five_hundred = (number < 500) ? 1000 : 0; 

            int nearest_thousand = previous_thousand + rounding_value + is_less_than_five_hundred;  
            System.Console.WriteLine(nearest_thousand); 
            System.Console.ReadKey();
        }
}
