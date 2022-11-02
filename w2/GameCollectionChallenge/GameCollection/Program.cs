 // This is the main method that out program will run from. The amount of coding has been reduced
 // due to creating methods that we can simply call to other classes and folders even


namespace GameCollection.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //We are creating our game object that is referenced to the game.cs file that contains
            //the constructor that we're calling
            Game game = new Game();
            game.run();
        }
    }
}