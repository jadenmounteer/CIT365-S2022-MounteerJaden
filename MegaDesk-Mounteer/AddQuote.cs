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
            string errorMsg;

            // Validate the width
            if (!isValidWidth(DeskWidthField.Text, out errorMsg)) {
                errorMsg = "Please enter a number between 24 and 96";
                this.errorProvider1.SetError(DeskWidthField, errorMsg);
                return;
            }

            // Validate the depth
            if (!isValidDepth(DeskDepthField.Text))
            {
                this.errorProvider1.SetError(DeskDepthField, "Please enter a number between 12 and 48");
                return;
            }

            // Create a desk object with the validated data
            int deskWidth = Int32.Parse(DeskWidthField.Text);
            int deskDepth = Int32.Parse(DeskDepthField.Text);
            int deskNumOfDrawers = Int32.Parse(NumOfDrawersBox.Text);
            Desk desk = new(deskWidth, deskDepth, deskNumOfDrawers, SurfaceMaterialBox.Text);

            // Create a quote object
            int rushDays = Int32.Parse(RushOrderBox.Text);
            DeskQuote quote = new DeskQuote(CustomerNameField.Text, rushDays, desk);

            // Navigate to the view quote menu
            DisplayQuote viewQuote = new DisplayQuote(desk, quote); // TODO pass our desk object and quote information into the constructor of the new window
            viewQuote.Tag = this;
            viewQuote.Show(this);
            this.Hide();
        }

        private void DeskWidthField_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!isValidWidth(DeskWidthField.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                DeskWidthField.Select(0, DeskWidthField.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(DeskWidthField, errorMsg);
            }
        }

        private bool isValidWidth(string text, out string errorMessage)
        {
            // Check if blank
            if (text.Length == 0)
            {
                errorMessage = "Width is required";
                return false;
            }

            // Check if alphanumeric
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    errorMessage = "Please enter a number";
                    return false;
                }
            }

            // Check if correct range
            int numWidth = Int32.Parse(text);
            if (numWidth > 94 || numWidth < 24)
            {
                errorMessage = "Please enter a number between 24 and 94";
                return false;
            }

            // Looks like we're good, so don't set a message
            errorMessage = "";
            return true;
        }

        private void DeskWidthField_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(DeskWidthField, "");
        }

        private void DeskDepthField_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Check if valid character
                if (!isValidDepth(DeskDepthField.Text))
                {
                    // If not, throw an exeption
                    throw new Exception();
                }
                
            }
            catch (Exception)
            {
                this.errorProvider1.SetError(DeskDepthField, "Please enter a number between 12 and 48");
            }
        }

        private bool isValidDepth(string text)
        {
            // Check if blank
            if (text.Length == 0)
            {
                return false;
            }

            // Check if alphanumeric
            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            // Check if correct range
            int numWidth = Int32.Parse(text);
            if (numWidth > 48 || numWidth < 12)
            {
                return false;
            }


            // It is valid...
            this.errorProvider1.SetError(DeskDepthField, "");
            return true;
        }



    }
}
