using System;
using System.Threading;

namespace ThreadsCS
{

    class Program
    {
      // Custom delegate- public delegate void ThreadDel();
        static void Main(string[] args)
        {

             Program pr = new Program();
            Console.WriteLine("thread started");
         
            //using parameterized delagate
             Thread thread = new Thread(new ParameterizedThreadStart(Message));
            //using delegate
            Thread thread2 = new Thread(new ThreadStart(Threadclass));
            //passing message to func
            Thread thread3 = new Thread((message) => Console.WriteLine(message));

            //custom delegate
            // Thread thread3 = new Thread(new ThreadDel(Threadclass));
            thread.Start("thread1 is running");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Main Thread: {i}");
                //Pause thread
                Thread.Sleep(300);
            }
            thread2.Start();
            thread3.Start("thread3 is running");

            for(int x = 1; x < 5; x++)
            {
                Thread thread4 = new Thread(Print);
                thread4.Name = $"thread {x}";
                thread4.Start();
            }

        }
        static void Print()
        {
            int y = 1;
            object locker = new object();
            lock (locker) 
            {
                for (int x = 1; x < 5; x++)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name}:{y}");
                    y++;
                    Thread.Sleep(100);
                }
            }
           
            //    Console.WriteLine(locker + "\n");
            
        }
        //Console.ReadLine();
        static void Threadclass()
        {
            Console.WriteLine("second thread");
            Thread t1 = Thread.CurrentThread;
            t1.Name = "thread1";
            Console.WriteLine($"thread name: {t1.Name}");
            Console.WriteLine($"thread managethread: {t1.ManagedThreadId}");
            Console.WriteLine($"thread culture: {t1.CurrentCulture}");
            Console.WriteLine($"thread execution context: {t1.ExecutionContext}");
            Console.WriteLine($"thread priority: {t1.Priority}");
            Console.WriteLine($"thread background: {t1.IsBackground}");
            Console.WriteLine("thread ending");
            Thread.Sleep(1000);
        }
        static void Message(object message)
        {
            Console.WriteLine("message: " + message);
        }

    }
}
