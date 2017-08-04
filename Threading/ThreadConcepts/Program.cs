using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//namespace for threading
using System.Threading;

namespace ThreadConcepts
{
    class Program
    {

        private static string strTest = "Thread Start/Stop/Join Sample";//static because inner class Alpha cant access a non - static type

        public  void Child()
        {
            while (true)
            {
                Console.WriteLine("Child thread is Executing");
                Console.ReadLine();

            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Main thread started. First Understand simple concept of child tread.");
            // Create the thread object, passing in the Alpha.Beta method
            // via a ThreadStart delegate. This does not start the thread.
            Thread objThread = new Thread(new ThreadStart(new Program().Child));
            Console.WriteLine("Child thread assigned using \"Thread objThread = new Thread(new ThreadStart(Child))\"");
            // Start the thread
            objThread.Start();
            Console.WriteLine("After Child thread start using \"objThread.Start();\"");
            // Spin for a while waiting for the started thread to become
            // alive:
            while (!objThread.IsAlive) ;
            Console.WriteLine("After while wait child thread is alive using \"while (!objThread.IsAlive)\"");

            // Put the Main thread to sleep for 1 millisecond to allow objThread
            // to do some work:
            Thread.Sleep(1);
            Console.WriteLine("If you put Main thread sleep for 1 millisecond using \" Thread.Sleep(1);\" then code for restarting thread will be delayed");

            // Request that objThread be stopped
            objThread.Abort();
            Console.WriteLine("Aborting Child thread using \" objThread.Abort(); \" ");

            // Wait until objThread finishes. Join also has overloads
            // that take a millisecond interval or a TimeSpan object.
            objThread.Join();
            Console.WriteLine("After joining Child thread to Wait until objThread finishes. Using \" objThread.Join();\" ");
           
            try
            {
                Console.WriteLine("Try to restart the child thread");
                objThread.Start();
                Console.WriteLine("After restart the child thread"); //unreachable aborted threads cannot be restarted.
       
            }
            catch (ThreadStateException)
            {
                Console.WriteLine("ThreadStateException trying to restart child ");
                Console.WriteLine("Expected since aborted threads cannot be restarted.");
                Console.ReadLine();

            }


        }
      
       
    }
}
