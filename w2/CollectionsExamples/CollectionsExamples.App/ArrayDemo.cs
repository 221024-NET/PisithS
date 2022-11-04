namespace CollectionsExamples.App
{
    public class Arrays
    {
        // Fields
        DateTime[] arr = new DateTime[1000];

        // Constructors
        public Arrays()
        {
            for (int i = 0; i < this.arr.Length; i++)
            {
                arr[i] = DateTime.Now;
            }
        }

        // Methods

        public TimeSpan[] getDifferences()
        {
            TimeSpan[] ts = new TimeSpan[this.arr.Length -1 ];

            for ( int i = 0; i < 4; i++)
            {
                DateTime start = arr[i];
                DateTime end = arr[i+1];

                ts[i] = end - start;
            }
            return ts;
        }

    }
}