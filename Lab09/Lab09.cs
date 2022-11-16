/*///<summary>
 ////File: Lab09
 ///Name: Chris Brown
 ////Email: Cbrown36@stumail.northeaststate.edu
 ///Class: CISP1010
 ///Semester: Fall 2022
 ///</summary>*Lab 09- Prompt the user for multiple variable values of different types.
*////The variables are then displayed along with the inputed values.
namespace Lab09
{

    /// <sumary>
    /// Prompt user for input values for displayed variable types.
    internal class Lab09
    {
        //Entry point for program
        static void Main(string[] args)

        {
            //declairing the variables
            sbyte promptSbyte;
            byte promptByte;
            short promptShort;
            ushort promptUshort;
            int promptInt;
            uint promptUint;
            long promptLong;
            ulong promptUlong;
            float promptFloat;
            double promptDouble;
            decimal promptDecimal;
            char promptChar;
            string promptString;
            bool promptBool;

            ///Receive Prompt for user input by calling methods
            promptSbyte = PromptForSignedByte("Enter a sbyte: ");
            promptByte = PromptForByte("Enter a byte ");
            promptShort = PromptForShort("Enter a short ");
            promptUshort = PromptForUshort("Enter a ushort ");
            promptInt = PromptForInt("Enter a int: ");
            promptUint = PromptForUnsignedInt("Enter a uint ");
            promptLong = PromptForLong("Enter a long ");
            promptUlong = PromptForUlong("Enter a ulong ");
            promptFloat = PromptForFloat("Enter a float: ");
            promptDouble = PromptForDouble("Pardon me, may I have a double? ");
            promptDecimal = PromptForDecimal("Enter a decimal: ");
            promptChar = PromptForChar("Enter a char: ");
            promptString = PromptForString("Enter a string: ");
            promptBool = PromptForBool("Enter a bool ");
            Console.WriteLine();

            //Display Results
            Console.WriteLine("prompted sbyte = " + promptSbyte);
            Console.WriteLine("prompted byte = " + promptByte);
            Console.WriteLine("prompted short = " + promptShort);
            Console.WriteLine("prompted ushort = " + promptUshort);
            Console.WriteLine("prompted integer = " + promptInt);
            Console.WriteLine("prompted uinteger =" + promptUint);
            Console.WriteLine("prompted long = " + promptLong);
            Console.WriteLine("prompted ulong = " + promptUlong);
            Console.WriteLine("prompted float = " + promptFloat);
            Console.WriteLine("prompted double = " + promptDouble);
            Console.WriteLine("prompted deceimal = " + promptDecimal);
            Console.WriteLine("prompted string = " + promptString);
            Console.WriteLine("prompted bool = " + promptBool);
            //prints message propting user the ablity to exit
            Console.WriteLine("" + "Press any key to exit");
            //pause for user to press key to exit
            Console.ReadKey();

        }
        //Method for to prompt user for sbyte 
        static sbyte PromptForSignedByte(string prompt)
        {
            Console.Write(prompt);
            return Convert.ToSByte(Console.ReadLine());

        }
        //Method for to prompt user for byte
        static byte PromptForByte(string prompt)
        {
            Console.Write(prompt);
            return Convert.ToByte(Console.ReadLine());

        }
        //Method for to prompt user for a short
        static short PromptForShort(string prompt)
        {
            Console.Write(prompt);
            return Convert.ToInt16(Console.ReadLine());

        }
        //Method for to prompt user for a ushort
        static ushort PromptForUshort(string prompt)
        {
            Console.Write(prompt);
            return Convert.ToUInt16(Console.ReadLine());

        }
        //Method for to prompt user for a int
        static int PromptForInt(string prompt)
        {
            Console.Write(prompt);
            return Convert.ToInt32(Console.ReadLine());

        }
        //Method for to prompt user for a uint
        static uint PromptForUnsignedInt(string prompt)
        {
            Console.Write(prompt);
            return Convert.ToUInt32(Console.ReadLine());
        }
        //Method for to prompt user for a long
        static long PromptForLong(string prompt)
        {
            Console.Write(prompt);
            return Convert.ToInt64(Console.ReadLine());

        }
        //Method for to prompt user for a ulong
        static ulong PromptForUlong(string prompt)
        {
            Console.Write(prompt);
            return Convert.ToUInt64(Console.ReadLine());
        }
        //Method for to prompt user for a float
        static float PromptForFloat(string prompt)
        {
            Console.Write(prompt);
            return Convert.ToSingle(Console.ReadLine());

        }
        //Method for to prompt user for a double
        static double PromptForDouble(string prompt)
        {
            Console.Write(prompt);
            return Convert.ToDouble(Console.ReadLine());
        }
        //Method for to prompt user for a decimal
        static decimal PromptForDecimal(string prompt)
        {
            Console.Write(prompt);
            return Convert.ToDecimal(Console.ReadLine());

        }
        //Method for to prompt user for a char
        static char PromptForChar(string prompt)
        {
            Console.Write(prompt);
            return Convert.ToChar(Console.ReadLine());

        }
        //Method for to prompt user for a string
        static string PromptForString(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
        //Method for to prompt user for a bool
        static bool PromptForBool(string prompt)
        {
            Console.Write(prompt);
            return Convert.ToBoolean(Console.ReadLine());
        }
    }

}
