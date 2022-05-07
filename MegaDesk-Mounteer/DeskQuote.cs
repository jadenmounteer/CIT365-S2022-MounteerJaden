using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Mounteer
{

    public class DeskQuote
    {
        // Fields
        private int rushDays;
        private string customerName;
        private string quoteDate;
        public double BaseDeskPrice = 200;

        // Properties
        public Desk Desk;
        public int RushDays { get { return rushDays; } set { rushDays = value; } }
        public string CustomerName { get { return customerName; } set { customerName = value; } }
        public string QuoteDate { get { return quoteDate; } set { quoteDate = value; } }

        // Constructor
        public DeskQuote(string customerName, int rushDays, Desk desk)
        {
            this.CustomerName = customerName;
            this.RushDays = rushDays;
            this.Desk = desk;
            DateTime today = DateTime.Today;
            this.QuoteDate = today.ToString("dd MMMM yyyy");
        }

        // Methods
        public double CalculateRushOrderCost(Desk desk)
        {
            int sizeOfDesk = desk.GetSize();

            if (this.RushDays == 3 && sizeOfDesk < 1000)
            {
                return 60;
            }

            if (this.RushDays == 5 && sizeOfDesk < 1000)
            {
                return 40;
            }

            if (this.RushDays == 7 && sizeOfDesk < 1000)
            {
                return 30;
            }

            if (this.RushDays == 3 && (sizeOfDesk >= 1000 && sizeOfDesk <= 2000))
            {
                return 70;
            }

            if (this.RushDays == 5 && (sizeOfDesk >= 1000 && sizeOfDesk <= 2000))
            {
                return 50;
            }

            if (this.RushDays == 7 && (sizeOfDesk >= 1000 && sizeOfDesk <= 2000))
            {
                return 35;
            }

            if (this.RushDays == 3 && sizeOfDesk > 2000)
            {
                return 80;
            }

            if (this.RushDays == 5 && sizeOfDesk > 2000)
            {
                return 60;
            }

            if (this.RushDays == 7 && sizeOfDesk > 2000)
            {
                return 40;
            }


            return 0;
        }

        public double CalculateDrawersCost(Desk desk)
        {
            return (double)desk.NumberOfDrawers * 50;
        }

        public double CalculaeSurfaceMaterialsCost(Desk desk)
        {
            switch (desk.DesktopMaterial)
            {
                case "oak":
                    return 200;

                case "laminate":
                    return 100;

                case "pine":
                    return 50;

                case "rosewood":
                    return 300;

                case "veneer":
                    return 125;
            }

            return 0;
        }

        public double CalculateTotalPrice(Desk desk)
        {
            double rushOrderCost = this.CalculateRushOrderCost(desk);
            double surfaceMaterialsCost = this.CalculaeSurfaceMaterialsCost(desk);
            double drawersCost = this.CalculateDrawersCost(desk);
            double surfaceAreaCost = desk.GetSize();
            return rushOrderCost + surfaceMaterialsCost + drawersCost + surfaceAreaCost + BaseDeskPrice;
        }








    }
}
