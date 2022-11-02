namespace CollectionsExamples.App
{
    public class Timer
    {
        // Fields

        // Constructors
        public Timer(){}

        // Methods
        public TimeSpan RunStack()
        {

            // start a timer
            DateTime start = DateTime.Now;

            // some time intensive action
            StacksandQueues demo1 = new StacksandQueues();
            demo1.StackTimer();

            // stop the timer
            DateTime stop = DateTime.Now;

            TimeSpan ts = stop - start;

            // return the value of the timer
            return ts;
        }

        public TimeSpan RunQueue()
        {

            DateTime start = DateTime.Now;
            StacksandQueues demo2 = new StacksandQueues();
            demo2.QueueTimer();
            DateTime stop = DateTime.Now;
            TimeSpan ts = stop - start;
            return ts;
        }

    }
}