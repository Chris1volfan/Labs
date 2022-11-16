/*///<summary>
 ////File: Lab07
 ///Name: Chris Brown
 ////Email: Cbrown36@stumail.northeaststate.edu
 ///Class: CISP1010
 ///Semester: Fall 2022
 ///</summary>*Lab 07- Prompt the user for a number of month variable value and a year variable value
*/

using System.Collections;
///then the month and year will be displayed along with has # days 
namespace Lab07
{

    /// <sumary>
    /// A Temperature Converter for Fahrenheit to Celsius or Celsius to Fahrenheit program
    internal class Lab7
    {
        //Entry point for program
        static void Main(string[] args)

        {
            //declairing the variables
            int month, year;
            string tempMonth, tempYear;
            //assign value by requesting user input for month
            Console.Write("Enter a month in the year (e.g., 1 for Jan:) ");
            tempMonth = Console.ReadLine();
            month = Convert.ToInt32(Convert.ToInt32(tempMonth));
            //prompt the user for the year input
            Console.Write("Enter a year: ");
            tempYear = Console.ReadLine();
            year = Convert.ToInt32(Convert.ToInt32(tempYear));
            //Use switching to display the results

            {
                switch (month)
                {
                    case 1:
                        Console.WriteLine("January " + year + "  has 31 days");
                        break;
                    case 2:
                        if (year % 4 == 0 && year % 100 > 0 || year % 400 == 0)
                            Console.WriteLine("February" + year + "  has 29 days");
                        else
                            Console.WriteLine("February" + year + "has 28 days");
                        break;
                    case 3:
                        Console.WriteLine("March " + year + "  has 31 days");
                        break;
                    case 4:
                        Console.WriteLine("April " + year + "  has 30 days");
                        break;
                    case 5:
                        Console.WriteLine("May " + year + "  has 31 days");
                        break;
                    case 6:
                        Console.WriteLine("June " + year + "  has 30 days");
                        break;
                    case 7:
                        Console.WriteLine("July " + year + "  has 31 days");
                        break;
                    case 8:
                        Console.WriteLine("August " + year + "  has 31 days");
                        break;
                    case 9:
                        Console.WriteLine("September " + year + "  has 30 days");
                        break;
                    case 10:
                        Console.WriteLine("October " + year + "  has 31 days");
                        break;
                    case 11:
                        Console.WriteLine("November " + year + "  has 30 days");
                        break;
                    case 12:
                        Console.WriteLine("December " + year + "  has 31 days");
                        break;


                }

            }


            Console.ReadKey();

        }
    }
}