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


        public virtual void CalculateTotalCost()
        {
           
        }          

        public decimal TotalCost
        {
            get;
            set;
        }
    }
}
