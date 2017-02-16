using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UserInterface
    {
        //Output, used for print
        public void Output(string outputString)
        {
            Console.WriteLine(outputString);
        }

        public int GetInput()
        {
            //Main menu update            
            this.Menu();

            //Get the input from the user
            String input = Console.ReadLine();

            //While te imput is not valid re-get the input
            while (input != "1" && input != "2" && input != "3")
            {

                //Print Error message
                this.PrintErrorMessage();

                //re-spring the menu
                this.Menu();

                //Get the input from the console again
                input = Console.ReadLine();

            }

            return Int32.Parse(input);
        }

        public void Menu()
        {
            Console.WriteLine("");
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("1- Print Current Inventory");
            Console.WriteLine("2- Add New Droid");
            Console.WriteLine("3- Exit");
        }

        private void PrintErrorMessage()
        {
            Console.WriteLine("That is not a valid entry");
            Console.WriteLine("Please make a valid choice");
            Console.WriteLine();
        }
    }
}
