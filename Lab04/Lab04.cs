/*///<summary>
 ////File: Lab4
 ///Name: Chris Brown
 ////Email: Cbrown36@stumail.northeaststate.edu
 ///Class: CISP1010
 ///Semester: Fall 2022
 ///</summary>*Lab 4- Prompt the user for the variable values and calculates the acceleration by finding the change in velocity and dividing by time
*////the variables are then displayed along with the calculated acceleration

namespace Lab04
{

    /// <sumary>
    /// A Physics Acceleration Calculator program
    internal class Lab04
    {
        //program entry point
        static void Main(string[] args)

        {
            //Declairing the variables
            float acceleration, velocity0, velocity1, time;

            //assign value by requesting user input
            Console.WriteLine("Physics Acceleration Calculator:");
            Console.WriteLine();
            Console.Write("Enter a value for velocity0 in meters/secound: ");
            velocity0 = Convert.ToSingle(Console.ReadLine());
            Console.Write("" + "Enter a value for velocity1 in meters/secound: ");
            velocity1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter a value for time greater than 0 secounds: ");
            time = Convert.ToSingle(Console.ReadLine());

            //Calculation
            acceleration = (velocity1 - velocity0) / time;
            //Printing to the results to the screen
            Console.WriteLine();
            Console.WriteLine("velocity0 = " + velocity0 + " m/s");
            Console.WriteLine("velocity1 = " + velocity1 + " m/s");
            Console.WriteLine("time = " + time + " s");
            Console.WriteLine("acceleration = " + System.Math.Round(acceleration, 1) + " m/s^2");
            Console.WriteLine();
            Console.WriteLine();
            //Prints message propting user the ablity to exit
            Console.WriteLine("" + "Press any key to exit");
            //Pause for user to press key to exit
            Console.ReadKey();

        }
       
    }

}