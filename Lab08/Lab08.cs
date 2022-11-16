/*///<summary>
 ////File: Lab08
 ///Name: Chris Brown
 ////Email: Cbrown36@stumail.northeaststate.edu
 ///Class: CISP1010
 ///Semester: Fall 2022
 ///</summary>*Lab08- Prompt the user for the number of sides and the value of their length.
 *////The area of regular polygon is calulated and displayed or an error message is displayed for bad data.

namespace Lab08
{

    /// <sumary>
    /// A Regular Poygon Area Calculator program
    internal class Lab08
    {
        //Entry point for program
        static void Main(string[] args)

        {
            //declairing the variables
            string tempSides, tempLength;
            int sides;
            double length, area;

            //ask for num sides
            Console.Write("Enter a value for the number of sides: ");
            tempSides = Console.ReadLine();
            sides = Convert.ToInt32(tempSides);

            //Check for valid value
            if (sides >= 3)
            {
                //enter length
                Console.Write("Enter a value for the length: ");
                tempLength = Console.ReadLine();
                length = Convert.ToDouble(tempLength);

                if (length > 0.0)
                {
                    //calculate area
                    area = sides * Math.Pow(length, 2) / (4 * Math.Tan(Math.PI / sides));
                    Console.WriteLine("The area of the polygon is " + area);
                }
                else
                {
                    //print invalid length
                    Console.WriteLine("Side length must be greater than 0");
                }
            }
            else
            {
                //print invalid side
                Console.WriteLine("Number of sides must be greater than 2.  Exiting");
            }
            //Print message for user to exit
            Console.WriteLine("press any key to exit");
            //Allow for a pause and wait for user to press key to exit program
            Console.ReadKey();

            return;
        }
    }
}
