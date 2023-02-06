


using MultiThreading;
using System.Threading;

ThreadingMethods tm = new();
Thread T1 = new Thread(tm.Thread1);
Thread T2 = new Thread(tm.Thread2);
Thread T3 = new Thread(tm.Thread3);

T1.Start();
T2.Start();
T3.Start();

T1.Join();
T2.Join();
T3.Join();
