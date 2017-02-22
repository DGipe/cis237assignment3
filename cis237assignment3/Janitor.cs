using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Janitor : Utility
    {
        private bool trashComp;
        private bool vac;

        public Janitor(string model, string material, string color, bool toolbox, bool commConn, bool arm, bool trashCompact, bool vacuum)
            : base(model, material, color, toolbox, commConn, arm)
        {
            trashComp = trashCompact;
            vac = vacuum;
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "Trash compactor present: " + trashComp + Environment.NewLine + "Vacuum present: "
                + vac + Environment.NewLine;

        }
    }
}
