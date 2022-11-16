/*///<summary>
 ////File: Lab03
 ///Name: Chris Brown
 ////Email: Cbrown36@stumail.northeaststate.edu
 ///Class: CISP1010
 ///Semester: Fall 2022
 ///</summary>*Lab 03- The program calculates the acceleration by finding the change in velocity and dividing by time
*////of preassigned variables. The variables are then displayed along with the calculated acceleration.

 
namespace Lab03
{

    internal class Lab03
    {
        /// <sumary>
        /// A Physics Acceleration Calculator, program entry point
        static void Main(string[] args)
        {
            //Declairing the variables
            float acceleration, velocity0, velocity1, time;
            //assigning variable values
            velocity0 = 5.6f;
            velocity1 = 10.5f;
            time = .5f;
            //Calculation
            acceleration = (velocity1 - velocity0) / time;
            //Printing to screen the variables and result
            Console.WriteLine("   velocity0 = " + velocity0 + "m/s");
            Console.WriteLine("   velocity1 = " + velocity1 + "m/s");
            Console.WriteLine("   time = " + time + "s");
            Console.WriteLine("   acceleration = " + acceleration + "m/s^2");
            //Give instructions for exit
            Console.WriteLine("   press any key to exit");
            //Allow for time to see the resuls and for user to exit
            Console.ReadKey();

        }
    }
}
