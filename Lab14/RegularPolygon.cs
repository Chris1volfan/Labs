
/*///<summary>
 ////File: RegularPolygon
 ///Name: Chris Brown
 ////Email: Cbrown36@stumail.northeaststate.edu
 ///Class: CISP1010
 ///Semester: Fall 2022
 ///Lab 14: Object Modeling - RegularPolygon
 /// </summary>
 */

namespace Lab14
{
    internal class RegularPolygon
    {
        /// <summary>
        /// Declare variables
        /// </summary>
        private uint numSides;
        private double sideLength;
        /// <summary>
        /// intiate the default contructor and set default property values
        /// </summary>
        public RegularPolygon()
        {
            numSides = 3;
            sideLength = 1;
        }
        /// <summary>
        /// Sets up the RegularPoygon object by with establishing parameters of number of sides and the
        /// length of the sides
        /// </summary>
        /// <param name="numSides"></param>
        /// <param name="sideLength"></param>
        public RegularPolygon(uint numSides, double sideLength)
        {
            this.numSides = numSides;
            this.sideLength = sideLength;
        }
        /// <summary>
        /// Gets and sets numSides for valid values which are greater than or equal to 3
        /// </summary>
        public uint NumSides
        {
            set
            {
                if (numSides >= 3)
                {
                    numSides = value;
                }
            }
            get { return numSides; }
        }
        /// <summary>
        /// Gets and sets sideLength for valid values which are greater than or equal to 1
        /// </summary>
        public double SideLength
        {
            set
            {
                if (sideLength >= 1)
                {
                    sideLength = value;
                }
            }
            get { return sideLength; }
        }
        /// <summary>
        /// The Area of the Polygon is calculated by using the Polygon's number of sides and lenth using
        /// a formula
        /// </summary>
        public double Area
        {

            get
            {
                return numSides * Math.Pow(sideLength, 2) / (4 * (Math.Tan(Math.PI / numSides)));
            }

        }
        /// <summary>
        /// The Perimeter of the Polygon
        /// </summary>
        public double Perimeter
        {

            get
            {
                return numSides * sideLength;
            }

        }
    }
}