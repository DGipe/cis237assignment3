using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Astromech : Utility
    {
        private bool fireExting;
        private int numships;
        private const decimal shipCost = 7m;

        public Astromech(string model, string material, string color, bool toolbox, bool commConn, bool arm, bool fire, int numShips)
            : base(model, material, color, toolbox, commConn, arm)
        {
            fireExting = fire;
            numships = numShips;
        }

        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();
            TotalCost += (numships * shipCost);
            if (fireExting == true)
            { TotalCost += 120m; }
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "Fire extinguisher present: " + fireExting + Environment.NewLine + "Number of ships droid can dock with: "
                + numships  + base.costToString();

        }
    }
}
