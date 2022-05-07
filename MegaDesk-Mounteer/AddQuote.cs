using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MegaDesk_Mounteer
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            // Navigate back to the main menu
            MainMenu viewMainMenu = new MainMenu();
            viewMainMenu.Show();
            Close();
        }

        private void ViewQuoteButton_Click(object sender, EventArgs e)
        {
            // Navigate to the view quote menu
            DisplayQuote viewQuote = new DisplayQuote();
            viewQuote.Tag = this;
            viewQuote.Show(this);
            this.Hide();
        }

        private void DeskWidthField_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
