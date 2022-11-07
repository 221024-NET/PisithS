using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace LoginRegister
{

    public class AppMethods
    {
        public Dictionary<string, string> Credentials = new Dictionary<string, string>();
        public AppMethods()
        {
            Credentials.Add("pisith265@revature.net", "123456");
            Credentials.Add("pisithsork@gmail.com", "password");
            Credentials.Add("sorkpisith97@gmail.com", "password123");
        }

        public void Login()
        {
            bool looping = true;
            Console.WriteLine("Please enter your username and password:");
            while (looping)
            {
                Console.Write("Username: ");
                string userInput1 = Console.ReadLine();
                Console.Write("Password: ");
                string userInput2 = Console.ReadLine();
                Console.WriteLine();

                //If statement to 
                if (Credentials.ContainsKey(userInput1))
                {
                    if (Credentials.TryGetValue(userInput1, out userInput2))
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
}