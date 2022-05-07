using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Mounteer
{
    public partial class DisplayQuote : Form
    {
        public Desk desk;
        public DeskQuote quote;
        public DisplayQuote(Desk desk, DeskQuote quote)
        {
            this.desk = desk;
            this.quote = quote;
            InitializeComponent();

            // Set the fields to the values
            NameField.Text = quote.CustomerName;
            DateField.Text = quote.QuoteDate;
            BasePriceField.Text = quote.BaseDeskPrice.ToString();
            SurfaceAreaField.Text = desk.GetSize().ToString();
            DrawersField.Text = quote.CalculateDrawersCost(desk).ToString();
            SurfaceMaterialsField.Text = quote.CalculaeSurfaceMaterialsCost(desk).ToString();
            RushOrderField.Text = quote.CalculateRushOrderCost(desk).ToString();
            TotalField.Text = quote.CalculateTotalPrice(desk).ToString();


        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            // Navigate back to the add quote menu
            AddQuote viewAddQuote = (AddQuote)Tag;
            viewAddQuote.Show();
            this.Close();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            // Navigate back to the main menu
            MainMenu viewMainMenu = new MainMenu();
            viewMainMenu.Show();
            Close();
        }
    }
}
