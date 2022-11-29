namespace ClassLibrary1
{
    public struct structure
    {
        private int _pin;
        private string _accountHolderName;

        public int GetPin
        {

            set
                {
                    _pin = value;
                }
          
              
            get
            {
                return _pin;
            }
        }

        public string AccountHolderName
        {
            
        set
        {
            _accountHolderName = value;
        }
          
           
        get
        {
            return _accountHolderName;
        }
        }

    }
}

public class User<T>
{
    public T RegistrationStatus;
}