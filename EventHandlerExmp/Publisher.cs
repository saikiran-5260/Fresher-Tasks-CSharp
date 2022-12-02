namespace ClassLibrary1
{
    public class CustomEventArgs : EventArgs
    {
        public int a { get; set; }
        public int b { get; set; }  
    }

    public class Publisher
    {
        public EventHandler<CustomEventArgs> myEvent;

        public void RaiseEvent(object sender, int a, int b) 
        {
            if(this.myEvent != null)
            {
                CustomEventArgs customEventArgs= new CustomEventArgs() { a= a, b= b };
                this.myEvent(sender, customEventArgs);
            }
        }
    }

}