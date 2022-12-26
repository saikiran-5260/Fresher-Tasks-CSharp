

namespace SealedMethodExmp
{
    public class SealedMethod1 : SealedMethod
    {
     
        public override int accBal 
        { 
            get 
            {
                return _accBal; 
            } 
            set 
            {
                _accBal = value;
            }
        }

        public new void DisplayDetails()
        {
            Console.WriteLine("Account Bal: "+_accBal + " " + _accName + " " + _accId);
        }
       
    }
}
