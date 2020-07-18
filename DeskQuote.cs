using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk___Lilly
{
    public enum Delivery
    {
        [Description("Rush 3 Days")]
        Rush3Day,

        [Description("Rush 5 Days")]
        Rush5Day,

        [Description("Rush 7 Days")]
        Rush7Day,

        [Description("No Rush")]
        Normal14Days
    }

    public class DeskQuote
    {
        private const decimal BASE_DESK_PRICE = 200.00M;
        private const decimal SURFACE_AREA_COST = 1.00M;
        private const decimal DRAWER_COST = 50.00M;
        private const decimal OAK_COST = 200.00M;
        private const decimal LAMINATE_COST = 100.00M;
        private const decimal PINE_COST = 50.00M;
        private const decimal ROSEWOOD_COST = 300.00M;
        private const decimal VENEER_COST = 125.00M;

        public Desk Desk { get; set; }
        public string Name { get; set; }
        public DateTime QuoteDate { get; set; }

        private int[,] rushOrderPrices;

        public Delivery DeliveryType { get; set; }
        public decimal QuotePrice { get; set; }

        public decimal GetQuotePrice() {

            getRushOrderPrices();

            decimal totalPrice = BASE_DESK_PRICE;
            decimal surfaceArea = this.Desk.Depth * this.Desk.Width;
            var surfaceMaterial = this.Desk.Material;

            decimal surfacePrice = 0.00M;
            decimal deliveryCost = 0.00M;

            decimal drawersPrice = this.Desk.NumDrawers * DRAWER_COST;


            if (surfaceArea > 1000)
            {
                totalPrice += surfaceArea * SURFACE_AREA_COST;
            }

            switch (surfaceMaterial)
            {
                case DesktopMaterial.Laminate:
                    surfacePrice = LAMINATE_COST;
                    break;
                case DesktopMaterial.Oak:
                    surfacePrice = OAK_COST;
                    break;
                case DesktopMaterial.Rosewood:
                    surfacePrice = ROSEWOOD_COST;
                    break;
                case DesktopMaterial.Veneer:
                    surfacePrice = VENEER_COST;
                    break;
                case DesktopMaterial.Pine:
                    surfacePrice = PINE_COST;
                    break;
                default:
                    break;
            }

            switch (DeliveryType)
            {
                case Delivery.Rush3Day:
                    if (surfaceArea < 1000)
                    {
                        deliveryCost = rushOrderPrices[0, 0];
                    }
                    else if (surfaceArea > 1000 && surfaceArea < 2000)
                    {
                        deliveryCost = rushOrderPrices[0, 1];
                    }
                    else
                    {
                        deliveryCost = rushOrderPrices[0, 2];
                    }
                    break;
                case Delivery.Rush5Day:
                    if (surfaceArea < 1000)
                    {
                        deliveryCost = rushOrderPrices[1, 0];
                    }
                    else if (surfaceArea > 1000 && surfaceArea < 2000)
                    {
                        deliveryCost = rushOrderPrices[1, 1];
                    }
                    else
                    {
                        deliveryCost = rushOrderPrices[1, 2];
                    }
                    break;
                case Delivery.Rush7Day:
                    if (surfaceArea < 1000)
                    {
                        deliveryCost = rushOrderPrices[2, 0];
                    }
                    else if (surfaceArea > 1000 && surfaceArea < 2000)
                    {
                        deliveryCost = rushOrderPrices[2, 1];
                    }
                    else
                    {
                        deliveryCost = rushOrderPrices[2, 2];
                    }
                    break;
                case Delivery.Normal14Days:

                    break;
                default:
                    break;
            }

            totalPrice += surfacePrice + drawersPrice + deliveryCost;

            return totalPrice;
        }

        private void getRushOrderPrices()
        {
            rushOrderPrices = new int[3, 3];

            var pricesFile = @"rushOrderPrices.txt";

            try
            {
                string[] prices = File.ReadAllLines(pricesFile);
                int i = 0, j = 0;

                foreach (string price in prices)
                {
                    rushOrderPrices[i, j] = int.Parse(price);

                    if (j == 2)
                    {
                        i++;
                        j = 0;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
