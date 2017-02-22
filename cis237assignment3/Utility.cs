using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Utility : Droid
    { 
        //Variables
        private bool toolBox;
        private bool compconn;
        private bool Arm;
        //Pulling this one in because it was the only way I could figure out how to get the cost to print at the bottom of the list
        private string Model;

        public Utility(string model, string material, string color, bool toolbox, bool compConn, bool arm) : base(model, material, color)
        {
            Model = model;
            toolBox = toolbox;
            compconn = compConn;
            Arm = arm;
        }

        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();
            if (toolBox == true)
            { TotalCost += 40m; }
            if (compconn == true)
            { TotalCost += 15m; }
            if (Arm == true)
            { TotalCost += 90m; }
        }

        public override string ToString()        
        {
            if (Model == "Utility")
            {
                return base.ToString() + Environment.NewLine + "Toolbox present: " + toolBox + Environment.NewLine + "Ability to connect to computer: "
                    + compconn + Environment.NewLine + "Utility arm present: " + Arm + base.costToString();
            }
            else
            {
                return base.ToString() + Environment.NewLine + "Toolbox present: " + toolBox + Environment.NewLine + "Ability to connect to computer: "
                    + compconn + Environment.NewLine + "Utility arm present: " + Arm;
            }

        }
    }
}
