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
            //declare arrays
            uint[] d4Rolls = new uint[4];
            uint[] d6Rolls = new uint[6];
            uint[] d8Rolls = new uint[8];
            uint[] d10Rolls = new uint[10];
            uint[] d12Rolls = new uint[12];
            uint[] d20Rolls = new uint[20];

            RollDice(d4Rolls, 4);
            RollDice(d6Rolls, 6);
            RollDice(d8Rolls, 8);
            RollDice(d10Rolls, 10); 
            RollDice(d12Rolls, 12); 
            RollDice(d20Rolls, 20); 

            Console.Write("d4 rolls: " + ArrayToString(d4Rolls) + "\n");
            //RollDice(d4Rolls, 4);
            //create a object of type Random
            Random r = new Random();
            
            {

            //    Console.Write(" " + RollDice(1));
            }
           
            {
                Console.ReadKey();
            }
        }
        
        //Method for getting random dice rolls with various number of sides 
        
        static uint RollDice(uint numSides)
        {
            Random r = new Random();
            int temp = r.Next(1, Convert.ToInt32(numSides));
            uint output = Convert.ToUInt32(temp);
            return output;
        }
        static void RollDice(uint[] diceRolls, uint sides)
        {
            //sets up an array for each dice array whin called
            uint[] diceArray = new uint[diceRolls.Length];
            string result;

            for (int i = 0; i < diceRolls.Length; i++)
            {
                diceArray[i] = RollDice(sides);
            }
            result = ArrayToString(diceArray);
        }
        static string ArrayToString(uint[] array)
        {
            //string rolls;
            //add value for loop display
            string diceRolls = "";
            foreach(uint roll in array)
            {
                diceRolls += roll + " ";
            }   
            return diceRolls;
        }
        //intiate six sided random dice roll            
        //
        //{
        //    Console.Write("d4 = ");
        //}
        //for (int i = 0; i < 4; i++)
        //{
        //
        //    Console.Write(" " + RollDice(5));
        //}
        //{
        //    Console.Write("\nd6 = ");
        //}
        //for (int i = 0; i< 6; i++)
        //{
        //     
        //     Console.Write(" "+ RollDice(7));
        // }
        //intiate eight sided random dice roll 
        //{
        //    Console.Write("\nd8 = ");
        // }
        // for (int i = 0; i < 8; i++)
        //{
        //     
        //    Console.Write(" " + RollDice(9));
        // }
        //intiate ten sided random dice roll 
        //{
        //     Console.Write("\nd10 = ");
        // }
        // for (int i = 0; i < 10; i++)
        // {
        //
        //    Console.Write(" " + RollDice(11));
        //}
        //intiate twelve sided random dice roll 
        //{
        //     Console.Write("\nd12 = ");
        //}
        // for (int i = 0; i < 12; i++)
        //intiate twenty sided random dice roll 
        //{
        //    Console.Write("\nd20 = ");
        //}
        //for (int i = 0; i < 20; i++)
        //{
        //
        //    Console.Write(" " + RollDice(20));
        //}
    }
}
