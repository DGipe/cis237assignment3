//David Gipe
//CIS 237
//Assignment 3
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
            UserInterface ui = new UserInterface();

            //Array
            IDroid[] droidList = new IDroid[20];
            DroidCollection droidCollect = new DroidCollection();

            int length = 0;
            string output = "";

            Console.BufferHeight = 1000;
            
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

                    Console.Clear();
                    foreach (IDroid droid in droidList)
                    {
                        if (droid != null)
                        {
                            output += droid.ToString();
                        }


                    }
                    Console.WriteLine(output);
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    goto MenuReturn;

                }
                //****************************************
                //Add Droid Option
                //****************************************
                if (choice == 2)
                {
                    Console.Clear();
                    droidCollect.AddDroid(droidList, length);
                    length++;
                    Console.WriteLine("Complete! Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    goto MenuReturn;
                    
                }
                                
                Environment.Exit(0);
            }

        }
    }
}
