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
            this.components = new System.ComponentModel.Container();
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.ViewQuoteButton = new System.Windows.Forms.Button();
            this.CustomerNameField = new System.Windows.Forms.TextBox();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.DeskWidthLabel = new System.Windows.Forms.Label();
            this.DeskDepthLabel = new System.Windows.Forms.Label();
            this.NumOfDrawersLabel = new System.Windows.Forms.Label();
            this.RushOrderLabel = new System.Windows.Forms.Label();
            this.DeskWidthField = new System.Windows.Forms.TextBox();
            this.DeskDepthField = new System.Windows.Forms.TextBox();
            this.InchesLabel1 = new System.Windows.Forms.Label();
            this.InchesLabel2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.SurfaceMaterialLabel = new System.Windows.Forms.Label();
            this.NumOfDrawersBox = new System.Windows.Forms.ComboBox();
            this.SurfaceMaterialBox = new System.Windows.Forms.ComboBox();
            this.RushOrderBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MainMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainMenuButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.MainMenuButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainMenuButton.Location = new System.Drawing.Point(31, 369);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(197, 60);
            this.MainMenuButton.TabIndex = 6;
            this.MainMenuButton.Text = "&Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = false;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // ViewQuoteButton
            // 
            this.ViewQuoteButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ViewQuoteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewQuoteButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ViewQuoteButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ViewQuoteButton.Location = new System.Drawing.Point(31, 303);
            this.ViewQuoteButton.Name = "ViewQuoteButton";
            this.ViewQuoteButton.Size = new System.Drawing.Size(197, 60);
            this.ViewQuoteButton.TabIndex = 5;
            this.ViewQuoteButton.Text = "&View Quote";
            this.ViewQuoteButton.UseVisualStyleBackColor = false;
            this.ViewQuoteButton.Click += new System.EventHandler(this.ViewQuoteButton_Click);
            // 
            // CustomerNameField
            // 
            this.CustomerNameField.Location = new System.Drawing.Point(169, 30);
            this.CustomerNameField.Name = "CustomerNameField";
            this.CustomerNameField.Size = new System.Drawing.Size(271, 23);
            this.CustomerNameField.TabIndex = 0;
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustomerNameLabel.Location = new System.Drawing.Point(12, 29);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(151, 24);
            this.CustomerNameLabel.TabIndex = 7;
            this.CustomerNameLabel.Text = "Customer Name:";
            // 
            // DeskWidthLabel
            // 
            this.DeskWidthLabel.AutoSize = true;
            this.DeskWidthLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeskWidthLabel.Location = new System.Drawing.Point(12, 63);
            this.DeskWidthLabel.Name = "DeskWidthLabel";
            this.DeskWidthLabel.Size = new System.Drawing.Size(114, 24);
            this.DeskWidthLabel.TabIndex = 8;
            this.DeskWidthLabel.Text = "Desk Width:";
            // 
            // DeskDepthLabel
            // 
            this.DeskDepthLabel.AutoSize = true;
            this.DeskDepthLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeskDepthLabel.Location = new System.Drawing.Point(12, 101);
            this.DeskDepthLabel.Name = "DeskDepthLabel";
            this.DeskDepthLabel.Size = new System.Drawing.Size(114, 24);
            this.DeskDepthLabel.TabIndex = 9;
            this.DeskDepthLabel.Text = "Desk Depth:";
            // 
            // NumOfDrawersLabel
            // 
            this.NumOfDrawersLabel.AutoSize = true;
            this.NumOfDrawersLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumOfDrawersLabel.Location = new System.Drawing.Point(12, 138);
            this.NumOfDrawersLabel.Name = "NumOfDrawersLabel";
            this.NumOfDrawersLabel.Size = new System.Drawing.Size(181, 24);
            this.NumOfDrawersLabel.TabIndex = 10;
            this.NumOfDrawersLabel.Text = "Number of Drawers:";
            // 
            // RushOrderLabel
            // 
            this.RushOrderLabel.AutoSize = true;
            this.RushOrderLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RushOrderLabel.Location = new System.Drawing.Point(12, 224);
            this.RushOrderLabel.Name = "RushOrderLabel";
            this.RushOrderLabel.Size = new System.Drawing.Size(192, 24);
            this.RushOrderLabel.TabIndex = 11;
            this.RushOrderLabel.Text = "Rush Order Selection:";
            // 
            // DeskWidthField
            // 
            this.DeskWidthField.Location = new System.Drawing.Point(169, 63);
            this.DeskWidthField.Name = "DeskWidthField";
            this.DeskWidthField.Size = new System.Drawing.Size(72, 23);
            this.DeskWidthField.TabIndex = 1;
            this.DeskWidthField.Validating += new System.ComponentModel.CancelEventHandler(this.DeskWidthField_Validating);
            this.DeskWidthField.Validated += new System.EventHandler(this.DeskWidthField_Validated);
            // 
            // DeskDepthField
            // 
            this.DeskDepthField.Location = new System.Drawing.Point(169, 101);
            this.DeskDepthField.Name = "DeskDepthField";
            this.DeskDepthField.Size = new System.Drawing.Size(72, 23);
            this.DeskDepthField.TabIndex = 2;
            // 
            // InchesLabel1
            // 
            this.InchesLabel1.AutoSize = true;
            this.InchesLabel1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InchesLabel1.Location = new System.Drawing.Point(247, 62);
            this.InchesLabel1.Name = "InchesLabel1";
            this.InchesLabel1.Size = new System.Drawing.Size(63, 24);
            this.InchesLabel1.TabIndex = 16;
            this.InchesLabel1.Text = "inches";
            // 
            // InchesLabel2
            // 
            this.InchesLabel2.AutoSize = true;
            this.InchesLabel2.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InchesLabel2.Location = new System.Drawing.Point(247, 101);
            this.InchesLabel2.Name = "InchesLabel2";
            this.InchesLabel2.Size = new System.Drawing.Size(63, 24);
            this.InchesLabel2.TabIndex = 17;
            this.InchesLabel2.Text = "inches";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // SurfaceMaterialLabel
            // 
            this.SurfaceMaterialLabel.AutoSize = true;
            this.SurfaceMaterialLabel.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SurfaceMaterialLabel.Location = new System.Drawing.Point(12, 176);
            this.SurfaceMaterialLabel.Name = "SurfaceMaterialLabel";
            this.SurfaceMaterialLabel.Size = new System.Drawing.Size(228, 24);
            this.SurfaceMaterialLabel.TabIndex = 18;
            this.SurfaceMaterialLabel.Text = "Desktop Surface Material:";
            // 
            // NumOfDrawersBox
            // 
            this.NumOfDrawersBox.FormattingEnabled = true;
            this.NumOfDrawersBox.Location = new System.Drawing.Point(199, 139);
            this.NumOfDrawersBox.Name = "NumOfDrawersBox";
            this.NumOfDrawersBox.Size = new System.Drawing.Size(121, 23);
            this.NumOfDrawersBox.TabIndex = 19;
            // 
            // SurfaceMaterialBox
            // 
            this.SurfaceMaterialBox.FormattingEnabled = true;
            this.SurfaceMaterialBox.Location = new System.Drawing.Point(246, 180);
            this.SurfaceMaterialBox.Name = "SurfaceMaterialBox";
            this.SurfaceMaterialBox.Size = new System.Drawing.Size(121, 23);
            this.SurfaceMaterialBox.TabIndex = 20;
            // 
            // RushOrderBox
            // 
            this.RushOrderBox.FormattingEnabled = true;
            this.RushOrderBox.Location = new System.Drawing.Point(210, 225);
            this.RushOrderBox.Name = "RushOrderBox";
            this.RushOrderBox.Size = new System.Drawing.Size(121, 23);
            this.RushOrderBox.TabIndex = 21;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 441);
            this.Controls.Add(this.RushOrderBox);
            this.Controls.Add(this.SurfaceMaterialBox);
            this.Controls.Add(this.NumOfDrawersBox);
            this.Controls.Add(this.SurfaceMaterialLabel);
            this.Controls.Add(this.InchesLabel2);
            this.Controls.Add(this.InchesLabel1);
            this.Controls.Add(this.DeskDepthField);
            this.Controls.Add(this.DeskWidthField);
            this.Controls.Add(this.RushOrderLabel);
            this.Controls.Add(this.NumOfDrawersLabel);
            this.Controls.Add(this.DeskDepthLabel);
            this.Controls.Add(this.DeskWidthLabel);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.CustomerNameField);
            this.Controls.Add(this.ViewQuoteButton);
            this.Controls.Add(this.MainMenuButton);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Quote";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button MainMenuButton;
        private Button ViewQuoteButton;
        private TextBox CustomerNameField;
        private Label CustomerNameLabel;
        private Label DeskWidthLabel;
        private Label DeskDepthLabel;
        private Label NumOfDrawersLabel;
        private Label RushOrderLabel;
        private TextBox DeskWidthField;
        private TextBox DeskDepthField;
        private Label InchesLabel1;
        private Label InchesLabel2;
        private ErrorProvider errorProvider1;
        private ComboBox SurfaceMaterialBox;
        private ComboBox NumOfDrawersBox;
        private Label SurfaceMaterialLabel;
        private ComboBox RushOrderBox;
    }
}