/*///<summary>
 ////File: Lab10
 ///Name: Chris Brown
 ////Email: Cbrown36@stumail.northeaststate.edu
 ///Class: CISP1010
 ///Semester: Fall 2022
 ///</summary>*Lab 10- The program will execute four diffrent loops to accomplish diffrent task.
*////Each Loop 1-4 is displayed along with the values of each task.

namespace Lab10
{

    /// <sumary>The Four For Loops and Display the Results.
        internal class Lab10
    {
        //Entry point for program
        static void Main(string[] args)

        {
       
            //Loop 1 - A for look that displays in ascending order all the multiples of 11 from 11 to 220.

            Console.Write("Loop 1: ");
            for (int i = 1; i < 20; i++)

            {
                int value = i * 11;
                Console.Write(value + " ");
            }
            //Loop 2 - A for looop that displays all the even integers in descending order 68 to 32.   
            
            Console.Write(" \nLoop 2: ");
            for (int i = 1; i < 20; i++)
            {
                int value = 70 - (i * 2);
                Console.Write(value + " ");

            }
            //Loop 3 - A for loop that displays in ascending order all the positive integers less than 400 that are evenly divisible by 2 and 13.
            
            Console.Write(" \nLoop 3: ");
            for (int i = 1; i < 16; i++)

            {
                int value = i * 26;
                Console.Write(value + " ");

            }


            //Loop4 - A for loop that will display the first 20 terms of Fibonacci sequence.

            int t1 = 0, t2 = 1, t3 = 1;
            Console.Write(" \nLoop 4:  0 1 ");
            Console.Write(t1 + t2 + " ");

            for (int i = 3; i < 19; i++)

            {

                t1 = t2;
                t2 = t3;
                t3 = t1 + t2;
                if (t2 == 1)
                {
                    Console.Write("2 ");
                }

                Console.Write(t2 + t3 + " ");
            }
            //Display Results

            //prints message propting user the ablity to exit
            Console.WriteLine ();
            Console.WriteLine();
            Console.WriteLine("press a key to exit");
            //pause for user to press key to exit
            Console.ReadKey();

        }


    }

}