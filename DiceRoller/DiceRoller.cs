using System;
using System.Linq;

namespace DiceRoller
{
    public class Program
    {

        public static void Main()
        {

            bool looping = true;
            //! May be required to split properly
            
            int total = 0;
            DiceFunctions play1 = new DiceFunctions();

            //have the user input what they would like to roll, based off of the formula that I need to set for
            //formula: #d#+#d#+...
            Console.WriteLine("Welcome to dice roller, here you can roll whatever dice, however many time.");
            Console.WriteLine("To do so enter what you want to roll with the following formula: #d#+#d#+...");
            while (looping)
            {   
                // Needed to split properly
                string userinput = "+";
                userinput += Console.ReadLine();

                //Likely user input example: 4d6+1d8

                String[] SplitThis = userinput.Split('+', StringSplitOptions.TrimEntries);

                DiceFunctions.start(SplitThis);
                Console.WriteLine("Would you like to roll again?\nPress 'Y' to continue or anything else to stop.");
                string toContinue = Console.ReadLine().ToUpper();
                if(toContinue == "Y")
                {
                    Console.WriteLine("Enter what you would like to roll and follow the formula: #d#+...");
                }
                else
                {
                    Console.WriteLine("Thank you for rolling with us!");
                    looping = false;
                }
            }


        }

    }

}
    /*x for (int i = 1; i < SplitThis.Length; i++)
            {
                string first = SplitThis[i].Substring(0, 1);

                string second = SplitThis[i].Substring(2);

                int FirstValue = Int32.Parse(first);

                int SecondValue = Int32.Parse(second);

                rolldice(FirstValue, SecondValue);
            }*/
        /*x public static void rolldice(int num, int type)
        {
            int sumtotal = 0;
            string userinput;
            var rand = new Random();

            for (int i = 1; i <= num; i++)
            {

                sumtotal += rand.Next(type + 1);

            }

            Console.WriteLine("{0}d{1} Result: {2}", num, type, sumtotal);
        }*/

