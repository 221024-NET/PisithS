//221024-batch repo, PisithS branch
using GameCollection.CoinFlipper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using GameCollection.CoinFlipper;
using GameCollection.Guessing;
//Does these name we're using refer to the namespace or name of the folder?


namespace GameCollection.App
{
    public class Game
    {
        // Fields

        // Constructors
        public Game() { }
        //Does this constructor allows us to create the game object referenced in Program.cs line 14? Why and How?

        // Methods
        public void run()
        {
            string selection;
            int choice;

            Console.WriteLine("Welcome to the Game Collection!");
            do
            {
                do
                {
                    Console.WriteLine(this.MainMenu());
                } while (!Int32.TryParse(Console.ReadLine(), out choice));
                //The TryParse() method simply takes in our ReadLine() and depending on if the value is of an Int32
                //It'll return either that value or 0 and because of the following code it'll prevent any unwanted value

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Thanks for playing!");
                        return;

                    case 1:
                        Flipper flip = new Flipper();
                        flip.CoinFlip();
                        break;

                    case 2:
                        Guess guess = new Guess();
                        guess.Play();
                        break;
                }
                Console.Clear();
                //This is a simple switch method that will either stop the program, run coin flip game or number guesser game
            } while (choice != 0);
            
        }

        public string MainMenu()
        {
            string menu = "Please select the game you would like to play: \n[0] - Exit \n[1] - Flip a coin \n[2] - Guessing game";
            return menu;
        }
    }
}
