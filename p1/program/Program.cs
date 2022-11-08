

public class Program
{

    public static void Main(String[] args)
    {

        /* We are creating a login/register program, one that is stable enough to be able to fall back to
         *  it is not a necessity to create it as efficient as possible because it is only to be meant as
         *  as a state of the program to fall back to if ever need to redo and rework testing programs
         */

        // test case
        string userName = "Pisith";
        string password = "123456";

        bool looping = true;
        Console.WriteLine("Welcome please enter your username and password");
        


        while (looping)
        {

            Console.Write("Username: ");
            string userInput1 = Console.ReadLine();
            Console.Write("Password: ");
            string userInput2 = Console.ReadLine();

            if (userInput1 == userName && userInput2 == password)
            {

                Console.WriteLine("Credential Accepted!");
                looping = false;

            }
            else if ((userInput1 != userName && userInput2 == password) || (userInput1 == userName && userInput2 != password))
            {


                Console.WriteLine("The username or password you entered was invalid please try again");
            }
            else
            {

                Console.WriteLine("That username seems to not be registered. Would you like to register it?");
                looping = false;

            }
        }
    }
}