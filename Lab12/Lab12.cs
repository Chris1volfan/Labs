/*///<summary>
 ////File: Lab12
 ///Name: Chris Brown
 ////Email: Cbrown36@stumail.northeaststate.edu
 ///Class: CISP1010
 ///Semester: Fall 2022
 ///</summary>*Lab 12
*/
using System.Xml;
///
namespace Lab12
{

    /// <sumary>
    /// This program will give will generate random dice rolls for the dungeon and dragons dice 
    /// with six, eight, ten, twelve, and twenty sides. The results are displayed for user to view.
    internal class Lab12
    {
        //Entry point for program
        static void Main(string[] args)

        
        {
            //declare arrays, including the amount of dice rolls
            uint[] d4Rolls = new uint[4];
            uint[] d6Rolls = new uint[6];
            uint[] d8Rolls = new uint[8];
            uint[] d10Rolls = new uint[10];
            uint[] d12Rolls = new uint[12];
            uint[] d20Rolls = new uint[20];
            
            //call RollDice method
            RollDice(d4Rolls, 4);
            RollDice(d6Rolls, 6);
            RollDice(d8Rolls, 8);
            RollDice(d10Rolls, 10); 
            RollDice(d12Rolls, 12); 
            RollDice(d20Rolls, 20); 

            //Display results of random dice rolls
            Console.Write("d4 rolls: " + ArrayToString(d4Rolls) + "\n");
            Console.Write("d6 rolls: " + ArrayToString(d6Rolls) + "\n");
            Console.Write("d8 rolls: " + ArrayToString(d8Rolls) + "\n");
            Console.Write("d10 rolls: " + ArrayToString(d10Rolls) + "\n");
            Console.Write("d12 rolls: " + ArrayToString(d12Rolls) + "\n");
            Console.Write("d20 rolls: " + ArrayToString(d20Rolls) + "\n");
            
            //allow display to remain until user presses a key
            {
                Console.ReadKey();
            }

            //create a object of type Random
            Random r = new Random();
                              
            
        }
        
        //Method for getting random dice rolls with various number of sides 
        
        static uint RollDice(uint numSides)
        {
            Random r = new Random();
            int temp = r.Next(1, Convert.ToInt32(numSides +1));
            uint output = Convert.ToUInt32(temp);
            return output;
        }
        //A method for every element in diceRolls is set to a random value rolled by using
        //the method RollDice(unit sides)
        static void RollDice(uint[] diceRolls, uint sides)
        {
            //sets up an array for each dice array when called
            //uint[] diceArray = new uint[diceRolls.Length];
            //string result;

            for (int i = 0; i < diceRolls.Length; i++)
            {
                diceRolls[i] = RollDice(sides);
            }
            //result = diceArray;
        }
        // A method for every element in array, to concatenate the element's value and add a space to a string between
        // variable upon return of the string variable
        static string ArrayToString(uint[] array)
        {
            //string output;
            //add value for loop display
            string output = "";
            foreach(uint item in array)
            {
            //rolls = Convert.ToString(roll);
                output += item + " ";
            }   
            return output;
        }
       
    }
}
