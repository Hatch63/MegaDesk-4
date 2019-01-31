using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class DeskQuotes
    {
        public string CustomerName { get; set; }
        public int numShippingDay { get; set; }
        public DateTime quoteDate { get; set; }
        public decimal shippingCost { get; set; }
        public decimal surfaceAreaCost { get; set; }
        public decimal structureCost { get; set; }
        public decimal baseCost { get; set; }
        public Desk Desk { get; set; }
        public string material { get; set; }


        public decimal getQuote()
        {
            decimal totalCost = surfaceAreaCost + structureCost;
            return totalCost;
        }

        public decimal getSurfaceAreaCost()
        {
            //SURFACE AREA COST
 
            decimal surfaceArea = Desk.Width + Desk.Depth;
            decimal costPerSqIn = 1;
            surfaceAreaCost = surfaceArea * costPerSqIn;

            //SWITCH FOR MATERIAL

            /*
            switch (Desk.Material = )
            {
                case Desk.Material.oak:
                    materialCost = 200;
                    break;
                case Desk.Material.laminate:
                    materialCost = 100;
                    break;
                case Desk.Material.pine:
                    materialCost = 50;
                    break;
                case Desk.Material.rosewood:
                    materialCost = 300;
                    break;
                case Desk.Material.veneer:
                    materialCost = 125;
                    break;
                default:
                    break;
            }
            */

            return surfaceAreaCost;


        }

        public decimal getStructureCost()
        {
            //STRUCTURE COST
            decimal baseCost = 200;
            decimal drawerCost = Desk.DrawerNum * 50;
            structureCost = baseCost + drawerCost;

            return structureCost;
        }
    }
}
