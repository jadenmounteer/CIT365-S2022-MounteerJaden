﻿using System;
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
        
            // TODO pass data from one for to the other

            // Navigate to the view quote menu
            DisplayQuote viewQuote = new DisplayQuote();
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
            if (numWidth > 96 || numWidth < 24)
            {
                errorMessage = "Please enter a number between 24 and 96";
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
    }
}
