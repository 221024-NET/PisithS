using System;

namespace CollectionsExamples.App
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Collection Example Starting!"); 
            Timer myTimer = new Timer();

            TimeSpan StackRuntime = myTimer.RunStack();
            TimeSpan QueueRuntime = myTimer.RunQueue();
            Console.WriteLine("Total elapsed time for Stack is: {0} ms", StackRuntime.TotalMilliseconds);
            Console.WriteLine("Total elapsed time for Queue is: {0} ms", QueueRuntime.TotalMilliseconds);
            
        }
    }
}