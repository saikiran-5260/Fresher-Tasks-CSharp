namespace ClassLibrary1
{
    public class Publisher
    {
        public delegate void MyDelegateType(int x, int y);

        private MyDelegateType myDelegate;

        public event MyDelegateType myEvent
        {
            add 
            { 
                myDelegate += value; 
            }
            remove 
            { 
                myDelegate -= value; 
            }  
        }
        public void RaiseEvent(int a, int b)
        {
            if(this.myDelegate != null)
            {
                myDelegate(a, b);
            }
            
        }

    }
}