//221024-net repo, PisithS
using System;

namespace PokemonApp{

    class Program{

        static void Main(string[] args)
        {
            //Initializing an object
            //We call the constructor, and pass it the desired values for this object
            Pokemon pikachu = new Pokemon("Pikachu", 25, "Electric", 12, "Static");

            //Calling an Instance method - belongs to the object itself.
            //Called by using object.method() 
            pikachu.PrintName();
            
            //Calling a Static method - belongs to the class.
            //Called by using Class.method()
            Pokemon.PrintMessage();

            //Accessing a Static field - belongs to the class.
            //Called by referencing the class itself.
            Console.WriteLine(Pokemon.isPokemon);

        }
        

    }

}