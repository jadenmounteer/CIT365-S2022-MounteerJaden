namespace MegaDesk_Mounteer
{
    partial class AddQuote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MainMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.MainMenuButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainMenuButton.Location = new System.Drawing.Point(31, 218);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(197, 60);
            this.MainMenuButton.TabIndex = 4;
            this.MainMenuButton.Text = "&Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = false;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 311);
            this.Controls.Add(this.MainMenuButton);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.ResumeLayout(false);

        }

        #endregion

        private Button MainMenuButton;
    }
}