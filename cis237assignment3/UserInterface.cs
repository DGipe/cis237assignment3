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

        //Main menu input
        public int GetMainInput()
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


        //Droid add input
        public int GetAddInput()
        {
            //Main menu update            
            this.AddMenu();

            //Get the input from the user
            String input = Console.ReadLine();

            //While te imput is not valid re-get the input
            while (input != "1" && input != "2" && input != "3" && input != "4")
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

        //Material Selection
        public string GetMaterial()
        {
            this.MaterialMenu();
            //Get the input from the user
            String input = Console.ReadLine();

            //While te imput is not valid re-get the input
            while (input != "1" && input != "2" && input != "3")
            {

                //Print Error message
                this.PrintErrorMessage();

                //re-spring the menu
                this.MaterialMenu();

                //Get the input from the console again
                input = Console.ReadLine();

            }
            if (input == "1")
            {
                return "Adamantium";
            }
            else
            {
                if (input == "2")
                {
                    return "Durasteal";
                }
                    else
                       {
                           return "Carbon Fiber";
                       }
            }
         }

        public string GetColor()
        {
            Console.WriteLine("");
            Console.WriteLine("What color is the droid?");
            Console.WriteLine("");
            //Get the input from the user
            string input = Console.ReadLine();
            return input;
        }

        public int GetLanguages()
        {
            Console.WriteLine("");
            Console.WriteLine("How many languages can the droid speak?");
            Console.WriteLine("");
            string input = Console.ReadLine();
            return Int32.Parse(input);
        }

        public bool getTool()
        {
            Console.WriteLine("");
            Console.WriteLine("Does the droid have a toolbox? Y/N");
            Console.WriteLine("");
            string input = Console.ReadLine();
            //While te imput is not valid re-get the input
            while (input != "Y" && input != "N")
            {

                //Print Error message
                this.PrintErrorMessage();

                Console.WriteLine("");
                Console.WriteLine("Does the droid have a toolbox? Y/N");
                Console.WriteLine("");

                //Get the input from the console again
                input = Console.ReadLine();

            }

            if (input == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool getComp()
        {
            Console.WriteLine("");
            Console.WriteLine("Does the droid have a method of connecting to a computer? Y/N");
            Console.WriteLine("");
            string input = Console.ReadLine();
            //While te imput is not valid re-get the input
            while (input != "Y" && input != "N")
            {

                //Print Error message
                this.PrintErrorMessage();

                Console.WriteLine("");
                Console.WriteLine("Does the droid have a method of connecting to a computer? Y/N");
                Console.WriteLine("");

                //Get the input from the console again
                input = Console.ReadLine();

            }
            if (input == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool getArm()
        {
            Console.WriteLine("");
            Console.WriteLine("Does the droid have a utility arm? Y/N");
            Console.WriteLine("");
            string input = Console.ReadLine();
            //While te imput is not valid re-get the input
            while (input != "Y" && input != "N")
            {

                //Print Error message
                this.PrintErrorMessage();

                Console.WriteLine("");
                Console.WriteLine("Does the droid have a utility arm? Y/N");
                Console.WriteLine("");

                //Get the input from the console again
                input = Console.ReadLine();

            }
            if (input == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GetFire()
        {
            Console.WriteLine("");
            Console.WriteLine("Does the droid have a fire extinguisher? Y/N");
            Console.WriteLine("");
            string input = Console.ReadLine();
            //While te imput is not valid re-get the input
            while (input != "Y" && input != "N")
            {

                //Print Error message
                this.PrintErrorMessage();

                Console.WriteLine("");
                Console.WriteLine("Does the droid have a fire extinguisher? Y/N");
                Console.WriteLine("");

                //Get the input from the console again
                input = Console.ReadLine();

            }
            if (input == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetShips()
        {
            Console.WriteLine("");
            Console.WriteLine("How many ships can the droid dock with?");
            Console.WriteLine("");
            string input = Console.ReadLine();
            return Int32.Parse(input);

        }

        public bool GetTrash()
        {
            Console.WriteLine("");
            Console.WriteLine("Does the droid have a trash compactor? Y/N");
            Console.WriteLine("");
            string input = Console.ReadLine();
            //While te imput is not valid re-get the input
            while (input != "Y" && input != "N")
            {

                //Print Error message
                this.PrintErrorMessage();

                Console.WriteLine("");
                Console.WriteLine("Does the droid have a trash compactor? Y/N");
                Console.WriteLine("");

                //Get the input from the console again
                input = Console.ReadLine();

            }
            if (input == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GetVac()
        {
            Console.WriteLine("");
            Console.WriteLine("Does the droid have a vacuum? Y/N");
            Console.WriteLine("");
            string input = Console.ReadLine();
            //While te imput is not valid re-get the input
            while (input != "Y" && input != "N")
            {

                //Print Error message
                this.PrintErrorMessage();

                Console.WriteLine("");
                Console.WriteLine("Does the droid have a trash vacuum? Y/N");
                Console.WriteLine("");

                //Get the input from the console again
                input = Console.ReadLine();

            }
            if (input == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        ////////////////////
        //   Menus
        ///////////////////////
        public void Menu()
        {
            Console.WriteLine("");
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("1- Print Current Inventory");
            Console.WriteLine("2- Add New Droid");
            Console.WriteLine("3- Exit");
            Console.WriteLine("");
        }

        private void PrintErrorMessage()
        {
            Console.WriteLine("That is not a valid entry");
            Console.WriteLine("Please make a valid choice");
            Console.WriteLine();
        }

        private void AddMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("Which type of droid are we adding today?");
            Console.WriteLine("");
            Console.WriteLine("1- Astromech");
            Console.WriteLine("2- Janitor");
            Console.WriteLine("3- Protocol");
            Console.WriteLine("4- Utility");
            Console.WriteLine("");
        }

        private void MaterialMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("What is the droid made of?");
            Console.WriteLine("");
            Console.WriteLine("1- Adamantium");
            Console.WriteLine("2- Durasteal");
            Console.WriteLine("3- Carbon Fiber");
            Console.WriteLine("");
        }

    }
}
