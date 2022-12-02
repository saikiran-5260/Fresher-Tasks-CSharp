namespace ClassLibrary1
{
    public class Publisher
    {
        public delegate int MyDelegateType(int x, int y);

        // Implementing auto implemented event method.

        //private MyDelegateType myDelegate;  
        //{
        //    add 
        //    { 
        //        myDelegate += value; 
        //    }
        //    remove 
        //    { 
        //        myDelegate -= value; 
        //    }  
        //}

        //public event MyDelegateType myEvent; 

        /*public event Func<int, int, int> myEvent;*/ //using Func generic type delegate to execute the event.

        //public int RaiseEvent(int a, int b)
        //{
        //    if(this.myEvent != null)
        //    {
        //        int x = this.myEvent(a, b);
        //        return x;
        //    }
        //    else
        //    {
        //        return 0;
        //    }

        //}

        //public event Action<int, int> myEvent;
        //public void  RaiseEvent(int a, int b) // action delegate
        //{
        //    if (this.myEvent != null)
        //    {
        //        this.myEvent(a, b);

        //    }


        //}
   
    public event Predicate<int> myEvent;
        public bool RaiseEvent(int a)
        {
            if (this.myEvent != null)
            {
                bool result = this.myEvent(a);
                return result;
            }
            else
            {
                return false;
            }
        }

    }
}
