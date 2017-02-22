using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Droid : IDroid
    {
        private string material;
        private string model;
        private string color;
        private decimal baseCost;
        private decimal totalCost;

        public decimal BaseCost
        {
            get
            {
                return baseCost;
            }
            set
            {
                baseCost = value;
            }
        }


        public decimal TotalCost
        {
            get
            {
                return totalCost;
            }
            set
            {
                totalCost = value;
            }
        }

        public Droid(string modelin, string materialin, string colorin)
        {
            material = materialin;
            model = modelin;
            color = colorin;

           // CalculateBaseCost(material, model);

        }
        public void CalculateBaseCost(string material, string model)
        {
            baseCost = 0;
            if (model == "Protocol")
            { baseCost += 150m; }
            if (model == "Astromech")
            { baseCost += 130m; }
            if (model == "Utility")
            { baseCost += 100m; }
            if (model == "Janitor")
            { baseCost += 50m; }

            if (material == "Adamantium")
                { baseCost += 1000m; }
            if (material == "Durasteal")
                { baseCost += 500m; }
            if (material == "Carbon Fiber")
                { baseCost += 100m; }

        }
        public virtual void CalculateTotalCost()
        {
            totalCost = baseCost;
        }

        public override string ToString()

        {
            CalculateBaseCost(material, model);
            CalculateTotalCost();
            return Environment.NewLine + "Droid Model: " + model + Environment.NewLine + "Droid Material: " + material + Environment.NewLine + "Droid Color: " + color;

        }

        public string costToString()

        {
            CalculateBaseCost(material, model);
            CalculateTotalCost();
            return Environment.NewLine + "-----------------------------" + Environment.NewLine + "Base Cost: " + baseCost.ToString("C")
                + Environment.NewLine + "Total Cost: " + totalCost.ToString("C") + Environment.NewLine + Environment.NewLine;
             
        }

    }
}
