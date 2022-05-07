using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Mounteer
{

    internal class DeskQuote
    {
        // Fields
        private int rushDays;
        private string customerName;
        private DateTime quoteDate;

        // Properties
        public double Price;
        public Desk Desk;
        public int RushDays { get { return rushDays; } set { rushDays = value; } }
        public string CustomerName { get { return customerName; } set { customerName = value; } }
        public DateTime QuoteDate { get { return quoteDate; } set { quoteDate = value; } }

        // Constructor
        public DeskQuote(string customerName, int rushDays, Desk desk)
        {
            this.CustomerName = customerName;
            this.RushDays = rushDays;
            this.Desk = desk;
            
            // TODO set the quotedate
        }

        // Methods
        public double CalculateRushOrderCost(Desk desk)
        {
            // TODO complete this method
            double cost = 0;
            return cost;
        }

        public double CalculateDesktopSurfaceAreaCost(Desk desk)
        {
            // TODO Complete this method
            double cost = 0;
            return cost;
        }

        public double CalculateDrawersCost(Desk desk)
        {
            // TODO Complete this method
            double cost = 0;
            return cost;
        }

        public double CalculaeSurfaceMaterialsCost(Desk desk)
        {
            // TODO Complete this method
            double cost = 0;
            return cost;
        }

        public double CalculateTotalPrice(Desk desk)
        {
            // TODO Complete this method
            double cost = 0;
            return cost;
        }








    }
}
