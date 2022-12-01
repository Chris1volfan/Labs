/*///<summary>
 ////File: Lab 13
 ///Name: Chris Brown
 ////Email: Cbrown36@stumail.northeaststate.edu
 ///Class: CISP1010
 ///Semester: Fall 2022
 ///Lab 13: Object Modeling - Television
 /// </summary>
 */

using System.Security.Cryptography.X509Certificates;

namespace Lab13
{
    /// <summary>
    /// A program that uses a Television object to do basic functions
    /// </summary>
    internal class Lab13
    {
        /// Summary
        /// This is the Main Method and entry point for this program
        /// summary
        static void Main(string[] args)
        {
            Television soni = new Television();
            Television senyo = new Television();
            //set chanel soni
            soni.SetChannel(128);

            //set chnel senyo
            senyo.Channel = 256;

            // increments soni's channel 26835 times
            for (int i = 0; i < 267835; i++)
            {
                soni.ChannelUp();
            }
            //decrements senyo's channel 12651 times
            for (int i = 0; i < 12651; i++)
            {
                senyo.ChannelDown();
            }
            //increments soni's volume 55 times
            for (int i = 0; i < 55; i++)
            {
                soni.VolumeUP();
            }
            //decrements senyo's volume 2 times
            for (int i = 0; i < 2; i++)
            {
                senyo.VolumeDown();
            }
            /// Displays each Television data and Pauses for user to press key
            Console.WriteLine("soni " + soni);
            Console.WriteLine("senyo " + senyo);
            Console.ReadLine();

        }

    }
}
