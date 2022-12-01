/*///<summary>
 ////File: Lab 14
 ///Name: Chris Brown
 ////Email: Cbrown36@stumail.northeaststate.edu
 ///Class: CISP1010
 ///Semester: Fall 2022
 ///Lab 14: Object Modeling - Regular Polygon
 /// </summary>
 */

namespace Lab14
{
    /// <summary>
    /// A program that intiates using a regular polygon object three regular poygons with varying number 
    /// of sides and lengths. All three polygons are then displayed to show the number of sides the lenght
    /// and the calculated perimeter, and area.
    /// </summary>
    internal class Lab14
    {
        /// <summary>
        /// The Main method is the entry point for this program
        /// </summary>
        static void Main(string[] args)
        {
            // establish the regular poygon objects
            RegularPolygon regularPolygon1 = new RegularPolygon();
            RegularPolygon regularPolygon2 = new RegularPolygon(6, 4.0);
            RegularPolygon regularPolygon3 = new RegularPolygon();

            // set the property values for Polygon 3
            regularPolygon3.NumSides = 12;
            regularPolygon3.SideLength = 1.25;

            // Display the polygons to include values and calculated perimeter and area for each
            Console.WriteLine($"regularPolygon1");
            Console.WriteLine($"\tnumSides = {regularPolygon1.NumSides}");
            Console.WriteLine($"\tsideLength = {regularPolygon1.SideLength}");
            Console.WriteLine($"\tperimeter = {regularPolygon1.Perimeter}");
            Console.WriteLine($"\tarea = {regularPolygon1.Area}");
            Console.WriteLine();
            Console.WriteLine($"regularPolygon2");
            Console.WriteLine($"\tnumSides = {regularPolygon2.NumSides}");
            Console.WriteLine($"\tsideLength = {regularPolygon2.SideLength}");
            Console.WriteLine($"\tperimeter = {regularPolygon2.Perimeter}");
            Console.WriteLine($"\tarea = {regularPolygon2.Area}");
            Console.WriteLine();
            Console.WriteLine($"regularPolygon3");
            Console.WriteLine($"\tnumSides = {regularPolygon3.NumSides}");
            Console.WriteLine($"\tsideLength = {regularPolygon3.SideLength}");
            Console.WriteLine($"\tperimeter = {regularPolygon3.Perimeter}");
            Console.WriteLine($"\tarea = {regularPolygon3.Area}");
            /// Pause to display results and user to press key
            Console.ReadKey();
        }
    }
}