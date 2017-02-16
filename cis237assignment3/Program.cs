using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create class instances
            Astromech astro = new Astromech();
            Droid drd = new Droid();
            DroidCollection drdc = new DroidCollection();
            Janitor jan = new Janitor();
            Protocol pro = new Protocol();
            UserInterface ui = new UserInterface();
            Utility Util = new Utility();

            //Header (cause console programs are boring)
            ui.Output("************************************************************" + Environment.NewLine +
            "*********                   CIS237                 *********" + Environment.NewLine +
            "********                 Assignment #3              ********" + Environment.NewLine +
            "*******             Jawa Inventory Managment         *******" + Environment.NewLine +
            "************************************************************" + Environment.NewLine);

            //Return tag 
            MenuReturn:

            int choice = ui.GetMainInput();

            //Keep running menu untill user exits
            while (choice != 3)
            {

                //******************************************
                //Print option
                //******************************************
                if (choice == 1)
                {
                    

                    goto MenuReturn;

                }
                //****************************************
                //Add Droid Option
                //****************************************
                if (choice == 2)
                {
                    int type = ui.GetAddInput();

                    goto MenuReturn;
                }
                                
                Environment.Exit(0);
            }

        }
    }
}
