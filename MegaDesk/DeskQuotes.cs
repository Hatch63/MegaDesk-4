using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public class DeskQuotes
    {
        public enum ShippingOptions { ThreeDays, FiveDays, SevenDays, FourteenDays }

        //DESK INSTANCE
        public Desk Desk { get; set; }
        public DateTime QuoteDate { get; set; }
        public string CustomerName { get; set; }

        public ShippingOptions Shipping { get; set; }
        public decimal QuoteTotal { get; set; }

        //CONSTANTS
        public const decimal BASECOST = 200;
        public const decimal OAKCOST = 200;
        public const decimal LAMINATECOST = 100;
        public const decimal PINECOST = 50;
        public const decimal ROSEWOODCOST = 300;
        public const decimal VENEERCOST = 125;

        public const int DRAWERCOST = 50;
        public const decimal COSTPERSQIN = 1;

        public const decimal THREE_DAYS_LESS_THAN_1000 = 60;
        public const decimal THREE_DAYS_1000_2000 = 70;
        public const decimal THREE_DAYS_2000 = 80;
        public const decimal FIVE_DAYS_LESS_THAN_1000 = 40;
        public const decimal FIVE_DAYS_1000_2000 = 50;
        public const decimal FIVE_DAYS_2000 = 60;
        public const decimal SEVEN_DAYS_LESS_THAN_1000 = 30;
        public const decimal SEVEN_DAYS_1000_2000 = 35;
        public const decimal SEVEN_DAYS_2000 = 40;


        public decimal GetQuote()
        {
            //BASE DESK COST
            decimal quoteTotal = BASECOST;

            //SURFACE AREA COST
            decimal surfaceArea = this.Desk.Width * this.Desk.Depth;
            decimal surfacePrice = 0;

            //IF OVER 1000SQIN
            if(surfaceArea > 1000)
            {
                surfacePrice = (surfaceArea - 1000) * COSTPERSQIN;
            }

            quoteTotal += surfacePrice;

            //ADD DRAWER COST
            decimal drawerCost = this.Desk.DrawerNum * DRAWERCOST;
            quoteTotal += drawerCost;


            //DELIVERY COSTS
            switch (Shipping)
            {
                case ShippingOptions.ThreeDays:
                    if(surfaceArea < 1000)
                    {
                        quoteTotal += THREE_DAYS_LESS_THAN_1000;
                    }
                    else if(surfaceArea >= 1000 && surfaceArea < 2000)
                    {
                        quoteTotal += THREE_DAYS_1000_2000;
                    }
                    else
                    {
                        quoteTotal += THREE_DAYS_2000;
                    }
                    break;
                case ShippingOptions.FiveDays:
                    if (surfaceArea < 1000)
                    {
                        quoteTotal += FIVE_DAYS_LESS_THAN_1000;
                    }
                    else if (surfaceArea >= 1000 && surfaceArea < 2000)
                    {
                        quoteTotal += FIVE_DAYS_1000_2000;
                    }
                    else
                    {
                        quoteTotal += FIVE_DAYS_2000;
                    }
                    break;
                case ShippingOptions.SevenDays:
                    if (surfaceArea < 1000)
                    {
                        quoteTotal += SEVEN_DAYS_LESS_THAN_1000;
                    }
                    else if (surfaceArea >= 1000 && surfaceArea < 2000)
                    {
                        quoteTotal += SEVEN_DAYS_1000_2000;
                    }
                    else
                    {
                        quoteTotal += SEVEN_DAYS_2000;
                    }
                    break;
            }

            //DESK MATERIAL COST
            switch (Desk.Material)
            {
                case Desk.DesktopMaterial.oak:
                    quoteTotal += OAKCOST;
                    break;
                case Desk.DesktopMaterial.laminate:
                    quoteTotal += LAMINATECOST;
                    break;
                case Desk.DesktopMaterial.pine:
                    quoteTotal += PINECOST;
                    break;
                case Desk.DesktopMaterial.rosewood:
                    quoteTotal += ROSEWOODCOST;
                    break;
                case Desk.DesktopMaterial.veneer:
                    quoteTotal += VENEERCOST;
                    break;
            }

            return quoteTotal;

        }
    }
}
