namespace MegaDesk_Mounteer
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.AddNewQuoteButton = new System.Windows.Forms.Button();
            this.ViewQuotesButton = new System.Windows.Forms.Button();
            this.SearchQuotesButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNewQuoteButton
            // 
            this.AddNewQuoteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AddNewQuoteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNewQuoteButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddNewQuoteButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddNewQuoteButton.Location = new System.Drawing.Point(33, 33);
            this.AddNewQuoteButton.Name = "AddNewQuoteButton";
            this.AddNewQuoteButton.Size = new System.Drawing.Size(197, 60);
            this.AddNewQuoteButton.TabIndex = 0;
            this.AddNewQuoteButton.Text = "Add New Quote";
            this.AddNewQuoteButton.UseVisualStyleBackColor = false;
            // 
            // ViewQuotesButton
            // 
            this.ViewQuotesButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ViewQuotesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewQuotesButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ViewQuotesButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ViewQuotesButton.Location = new System.Drawing.Point(33, 99);
            this.ViewQuotesButton.Name = "ViewQuotesButton";
            this.ViewQuotesButton.Size = new System.Drawing.Size(197, 60);
            this.ViewQuotesButton.TabIndex = 1;
            this.ViewQuotesButton.Text = "View Quotes";
            this.ViewQuotesButton.UseVisualStyleBackColor = false;
            // 
            // SearchQuotesButton
            // 
            this.SearchQuotesButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SearchQuotesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchQuotesButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.SearchQuotesButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchQuotesButton.Location = new System.Drawing.Point(33, 165);
            this.SearchQuotesButton.Name = "SearchQuotesButton";
            this.SearchQuotesButton.Size = new System.Drawing.Size(197, 60);
            this.SearchQuotesButton.TabIndex = 2;
            this.SearchQuotesButton.Text = "Search Quotes";
            this.SearchQuotesButton.UseVisualStyleBackColor = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ExitButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(33, 231);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(197, 60);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(260, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 232);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(565, 309);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SearchQuotesButton);
            this.Controls.Add(this.ViewQuotesButton);
            this.Controls.Add(this.AddNewQuoteButton);
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button AddNewQuoteButton;
        private Button ViewQuotesButton;
        private Button SearchQuotesButton;
        private Button ExitButton;
        private Button button1;
    }
}