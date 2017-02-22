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
            string model;

            int type = ui.GetAddInput();
            string material = ui.GetMaterial();
            string color = ui.GetColor();

            if (type == 3)
            {
                model = "Protocol";
                int numberOfLanguages = ui.GetLanguages();
                droidList[Index] = new Protocol(model, material, color, numberOfLanguages);

            }

            else
            {
                bool toolbox = ui.getTool();
                bool compConn = ui.getComp();
                bool arm = ui.getArm();

                if (type == 1)
                {
                    model = "Astromech";
                    bool fire = ui.GetFire();
                    int numShips = ui.GetShips();
                   droidList[Index] = new Astromech(model, material, color, toolbox, compConn, arm, fire, numShips);
                }

                if (type == 2)
                {
                    model = "Janitor";
                    bool trashCompact = ui.GetTrash();
                    bool vaccum = ui.GetVac();
                   droidList[Index] = new Janitor(model, material, color, toolbox, compConn, arm, trashCompact, vaccum);
    
                 }
                
                if (type == 4)
                {
                    model = "Utility";
                    droidList[Index] = new Utility(model, material, color, toolbox, compConn, arm);
                }
            }
        }


 
    }
}
