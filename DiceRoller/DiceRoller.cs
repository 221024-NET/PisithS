using System;



public class Program{

    public static void Main(){

        bool looping = true;
        string userinput;
        //have the user input what they would like to roll, based off of the formula that I need to set for
        //formula: #d#+#d#+...
        Console.WriteLine("Welcome to dice roller, here you can roll whatever dice, however many time.");
        Console.WriteLine("To do so enter what you want to roll with the following formula: #d#+#d#+...");
        userinput = Console.ReadLine();
        //Likely user input example: 4d6+1d8
        //Based on the formula we need to split the two values that will be used to call our method
        //We will also eventually call our method again if the "+" signs follows
        int d = userinput.IndexOf('d');
        int plus = userinput.IndexOf('+');
        string temp = userinput.Substring(0,d);
        string temp2 = userinput.Substring(d,plus);
        int firstValue = Int32.Parse(temp);
        int secondValue = Int32.Parse(temp2);

        Console.WriteLine(temp + " " + temp2);
        Console.ReadKey();

        
        // foreach(int i in inputvalue){
        //     if(i == 'd'){
        //         continue;
        //     }
        //     else if(i == '+'){
        //         //determines how many times to recur rolldice()
        //     }
        //     else{
        //         //convert into number and enter into 
        //     }
        // }

        

    }



    public static void rolldice(int num, int type){
        int numofDice = num;
        int typeofDice = type;
        int sumtotal = 0;
        string userinput;
        var rand = new Random();

        // Console.WriteLine("Enter the type of dice you want to roll: ");
        // userinput = Console.ReadLine();
        // typeofDice = Int32.Parse(userinput);

        // Console.WriteLine("Enter the number of dice you want to roll: ");
        // userinput = Console.ReadLine();
        // numofDice = Int32.Parse(userinput);
        
        for(int i = 1; i <= numofDice; i++){

            sumtotal += rand.Next(typeofDice + 1);

        }

        Console.WriteLine("Result: " + sumtotal);
    }

}