using System;

namespace DiceRoller
{

	public class DiceFunctions
	{
		public DiceFunctions()
		{
		}


        public static void start(string[] SplitThis)
        {
            string first, second;
            int FirstValue, SecondValue;
            for (int i = 1; i < SplitThis.Length; i++)
            {
                first = SplitThis[i].Substring(0, 1);

                second = SplitThis[i].Substring(2);

                FirstValue = Int32.Parse(first);

                SecondValue = Int32.Parse(second);

                rolldice(FirstValue, SecondValue);
            }
            
        }

        public static void rolldice(int num, int type)
        {
            int sumtotal = 0;
            string userinput;
            var rand = new Random();

            for (int i = 1; i <= num; i++)
            {

                sumtotal += rand.Next(1, (type+1));


            }

            Console.WriteLine("{0}d{1} Result: {2}", num, type, sumtotal);
        }
    }
}
