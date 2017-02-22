using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Utility : Droid
    {
        private bool toolBox;
        private bool compconn;
        private bool Arm;

        public Utility(string material, string model, string color, bool toolbox, bool compConn, bool arm) : base(material, model, color)
        {
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
            return base.ToString() + Environment.NewLine + "Toolbox present: " + toolBox + Environment.NewLine + "Ability to connect to computer: "
                + compconn + Environment.NewLine + "Utility arm present: " + Arm + Environment.NewLine;

        }
    }
}
