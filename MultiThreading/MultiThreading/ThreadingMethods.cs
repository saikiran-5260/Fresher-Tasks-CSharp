using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class ThreadingMethods
    {
        public void Thread1() 
        {
            for(int i =1;i<=10;i++)
            {
                Console.WriteLine("Thread1:"+i);
            }
        }
        public void Thread2()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Thread2:" + i);
                if(i==5)
                {
                    Console.WriteLine("Thread is sleeping");
                    Thread.Sleep(5000);
                    Console.WriteLine("Thread woke up");
                }   
            }
        }
        public void Thread3()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Thread3:" + i);
            }
        }
    }
}
