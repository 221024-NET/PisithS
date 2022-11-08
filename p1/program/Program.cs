using LoginRegister;
using System.Reflection;


/* Friendly reminder to always create a stable program on your main branch
 * AND PUSH IT, we need to always set the foundation of our program and creating
 * a stable version after testing and working new program to add is always the
 * best way to about it. This is just a friendly reminder
 */

class Program
{
    public static void Main()
    {
        //!DO NOT WORRY ABOUT EVERY TEST CASE UNTIL WE HAVE A PROPER FOUNDATION OF OUR LOGIN/REGISTER PROMPT
        //!YOU ARE FINE, CONTINUE CODING AND TAKE BREAKS
        /*
         * We will create a login/register prompt
         * In creating one will require:
         * 1. Prompt the user to input a user and password
         * 2. Check to see if it matches any existing user and if they are correct
         * 3. Based on the result will either end with:
         *  a. If it matches allow user access to the system
         *  b. If it finds a user but incorrect password prompt user to reinput
         *  c. If there is no user prompt user there is no record of them and ask if they want to register
         *     Which then will prompt the register screen
        */

        //?Test case only, idea to maybe have dictionaries maybe or at some point a database

        Dictionary<string, string> Credentials = new Dictionary<string, string>();
        Credentials.Add("pisith265@revature.net", "123456");
        Credentials.Add("pisithsork@gmail.com", "password");
        Credentials.Add("sorkpisith97@gmail.com", "password123");
        bool looping = true;
        bool LoginRegister = true;

        Console.WriteLine("Welcome! If you have an existing account please press 1 to login \n If you would like to register please press 2");


        while (LoginRegister)
        {
            string userInput0 = Console.ReadLine();
            if (userInput0 == "1")
            {
                LoginRegister = false;
            }
            else if (userInput0 == "2")
            {
                //!Create a method to have new user to register with email and password
                Console.WriteLine("Please enter a valid email");
                string newuserName = Console.ReadLine();

                Console.WriteLine("Please enter a secure password");
                string newPassword = Console.ReadLine();

                Credentials.Add(newuserName, newPassword);
                LoginRegister = false;
            }
        }

        Console.WriteLine("Please enter your username and password:");
        while (looping)
        {
            Console.Write("Username: ");
            string userInput1 = Console.ReadLine();
            Console.Write("Password: ");
            string userInput2 = Console.ReadLine();
            Console.WriteLine();

            if ((userInput1 == userName && userInput2 == password))
            {
                Console.WriteLine("Credential accepted");
                looping = false;
            }
            else if (userInput1 == userName && userInput2 != password || (userInput1 != userName && userInput2 == password))
            {
                Console.WriteLine("The username or password is incorrect please try again");
            }
            else
            {
                Console.WriteLine("That username has not been registered, would you like to register it?");
                //!This is for test case, later will need to implement a register feature
                looping = false;
            }
        }
    }
}
