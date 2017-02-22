using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Protocol : Droid
    {
        private int numLang;
        private const decimal langCost = 10m;

        public Protocol(string model, string material, string color, int numberOfLanguages) : base(model, material, color)
        {
            numLang = numberOfLanguages;
        }

        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();
            TotalCost += (numLang * langCost);
        }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + "Languages known: " + numLang + base.costToString();
             
        }
    }
}
