using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class DroidCollection 
    {
        public void AddDroid(IDroid[] droidList, int Index)
        {
            UserInterface ui = new UserInterface();
            string Model;

            int type = ui.GetAddInput();
            string materal = ui.GetMaterial;
            string color = ui.GetColor;
            
            if (type == 1)
            {
                Model = "Astromech";
             
            }

            if (type == 2)
            {
                Model = "Janitor";
                bool 

            }

            if (type == 3)
            {
                Model = "Protocol";
                int numberOfLanguages = ui.GetLanguages;
                droidList[Index] = new Protocol(Model, materal, color, numberOfLanguages);

            }

            if (type == 4)
            {
                Model = "Utility";

            }

        }


 
    }
}
