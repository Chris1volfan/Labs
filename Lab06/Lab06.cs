/*///<summary>
 ////File: Lab6
 ///Name: Chris Brown
 ////Email: Cbrown36@stumail.northeaststate.edu
 ///Class: CISP1010
 ///Semester: Fall 2022
 ///</summary>*Lab 6- Prompt the user for the variable value and temperature unit and calculates the conversion with proper formula for For C
*////the entered value is displayed with entered unit = to converted value and unit, if invalid unit, then display value with invalid message


namespace CSSP110
{

    /// <sumary>
    /// A Temperature Converter for Fahrenheit to Celsius or Celsius to Fahrenheit program
    internal class Lab6
    {
        //Entry point for program
        static void Main(string[] args)

        {
            //declairing the variables
            double temperatureValue, fahrenheit, celsius;
            string tempInput, unit;
            //assign value by requesting user input for temperature
            Console.WriteLine("Temperature Converter (F->C) or (C->F) (Enter F or C:");
            Console.WriteLine();
            Console.Write("Enter a value for temerature: ");
            tempInput = Console.ReadLine();
            temperatureValue = Convert.ToDouble(Convert.ToDouble(tempInput));
            //prompt the user for the unit input
            Console.Write("Select the unit entered Fahrenheit or Celcius (Enter F or C): ");
            unit = Console.ReadLine();
            //Check for F or f, when true calculate celsius and display results
            if (unit.Equals("F") || unit.Equals("f"))
            {
                celsius = (temperatureValue - 32) * 5 / 9;
                Console.WriteLine();
                Console.WriteLine(temperatureValue + "F" + "=" + System.Math.Round(celsius, 0) + "C");
            }
            //Check for C or c, when true calculate fahrenheit and display results
            else if (unit.Equals("C") || unit.Equals("c"))
            {
                fahrenheit = (temperatureValue * 9 / 5) + 32;
                Console.WriteLine();
                Console.WriteLine(temperatureValue + "C" + "=" + System.Math.Round(fahrenheit, 0) + "F");
            }
            //Check for invalid unit entry display error message
            else
            {
                Console.WriteLine(unit + " is not a valid unit");
            }

            //Printing to the results to the screen
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //prints message propting user the ablity to exit
            Console.WriteLine("" + "Press any key to exit");
            //pause for user to press key to exit
            Console.ReadKey();

        }
    }
}