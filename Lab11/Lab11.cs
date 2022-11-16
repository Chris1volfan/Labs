/*///<summary>
 ////File: Lab11
 ///Name: Chris Brown
 ////Email: Cbrown36@stumail.northeaststate.edu
 ///Class: CISP1010
 ///Semester: Fall 2022
 ///</summary>*Lab 11- Displays a greeting message and then prompt the user for a response, then uses a do while loop to evaluate different responses trigger different messages to 
 *////be displayed and a bye response is reponed to with a goodbye message and the programs exits.

namespace Lab11
{

    /// <sumary>Deckard Cain greeting and user reponse, certain user input have specific responses.
    /// When the user responds bye the Deckard Cain responds a bye message and program ends.
    internal class Lab11
    {
        static void Main(string[] args)

        {
            //declairing the variables
            String r, tr;

            //Display the inital greeting from Deckard Cain
            Console.WriteLine("Deckard Cain: Hello traveler, stay a while and listen!");
            //Console.ReadLine(r);

            //Start Response and Dialoge Loop
            do
            {
                Console.Write(" \nYou: ");
                
                //decalre variables  
                tr = Console.ReadLine();//temporary response                              
                r = tr.ToLower();//temporary response forced to lower case      
                
                //bye user reponse
                if (r == "bye")
                {

                    //Display the Deckard Cain response
                    Console.Write("Deckard Cain: Goodbye traveler");
                    //wait for user to enter key to end program
                    Console.ReadKey();
                    return;
                }
                //lore user response
                else if (r == "lore")
                {
                    //Display the Deckard Cain response
                    Console.Write("Deckard Cain: Tristram something something");
                    //Console.Write(" \nYou: ");
                    //r= Console.ReadLine();

                }

                //diablo user response
                else if (r == "diablo")
                {
                    //Display the Deckard Cain response
                    Console.Write("Deckard Cain: Diablo is, like, the worst");


                }
                //d4 user response
                else if (r == "d4")
                {
                    //Display the Deckard Cain response
                    Console.Write("Deckard Cain: No, I am slated to return for Dioblo 4. I am going into comedy.");


                }
                //who are you? user response
                else if (r == "who are you?")
                {
                    //Display the Deckard Cain response
                    Console.Write("My name is Deckard Cain, sit a while and listen.");
                }
                //unrecognizable user response
                else
                {
                    //Display the Deckard Cain response
                    Console.Write("Deckard Cain: I don't know what you mean. Soo sit a while and listen.");
                }

            }
            while (r != "bye");//check for condition to end loop message bye
        }

    }

}