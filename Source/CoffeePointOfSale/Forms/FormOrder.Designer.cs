namespace CoffeePointOfSale.Forms
{
    partial class FormOrder
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.CheckoutButton = new System.Windows.Forms.Button();
            this.LatteButton = new System.Windows.Forms.Button();
            this.IcedLatteButton = new System.Windows.Forms.Button();
            this.MatchaButton = new System.Windows.Forms.Button();
            this.CoffeeButton = new System.Windows.Forms.Button();
            this.WaterButton = new System.Windows.Forms.Button();
            this.EspressoButton = new System.Windows.Forms.Button();
            this.AddDrinkButton = new System.Windows.Forms.Button();
            this.AddCustomizationButton = new System.Windows.Forms.Button();
            this.TestLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Red;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.ForeColor = System.Drawing.Color.Snow;
            this.CancelButton.Location = new System.Drawing.Point(1123, 658);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(218, 67);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.Location = new System.Drawing.Point(900, 658);
            this.CheckoutButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(218, 51);
            this.CheckoutButton.TabIndex = 3;
            this.CheckoutButton.Text = "Continue to Checkout";
            this.CheckoutButton.UseVisualStyleBackColor = true;
            this.CheckoutButton.Click += new System.EventHandler(this.CheckoutButton_Click_1);
            // 
            // LatteButton
            // 
            this.LatteButton.Location = new System.Drawing.Point(15, 27);
            this.LatteButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.LatteButton.Name = "LatteButton";
            this.LatteButton.Size = new System.Drawing.Size(167, 160);
            this.LatteButton.TabIndex = 4;
            this.LatteButton.Text = "Latte";
            this.LatteButton.UseVisualStyleBackColor = true;
            this.LatteButton.Click += new System.EventHandler(this.LatteButton_Click);
            // 
            // IcedLatteButton
            // 
            this.IcedLatteButton.Location = new System.Drawing.Point(195, 27);
            this.IcedLatteButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.IcedLatteButton.Name = "IcedLatteButton";
            this.IcedLatteButton.Size = new System.Drawing.Size(167, 160);
            this.IcedLatteButton.TabIndex = 5;
            this.IcedLatteButton.Text = "Iced Latte";
            this.IcedLatteButton.UseVisualStyleBackColor = true;
            this.IcedLatteButton.Click += new System.EventHandler(this.IcedLatteButton_Click);
            // 
            // MatchaButton
            // 
            this.MatchaButton.Location = new System.Drawing.Point(373, 27);
            this.MatchaButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.MatchaButton.Name = "MatchaButton";
            this.MatchaButton.Size = new System.Drawing.Size(167, 160);
            this.MatchaButton.TabIndex = 6;
            this.MatchaButton.Text = "Iced Matcha Green Tea Latte";
            this.MatchaButton.UseVisualStyleBackColor = true;
            this.MatchaButton.Click += new System.EventHandler(this.MatchaButton_Click);
            // 
            // CoffeeButton
            // 
            this.CoffeeButton.Location = new System.Drawing.Point(549, 27);
            this.CoffeeButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.CoffeeButton.Name = "CoffeeButton";
            this.CoffeeButton.Size = new System.Drawing.Size(167, 160);
            this.CoffeeButton.TabIndex = 7;
            this.CoffeeButton.Text = "Coffee";
            this.CoffeeButton.UseVisualStyleBackColor = true;
            this.CoffeeButton.Click += new System.EventHandler(this.CoffeeButton_Click);
            // 
            // WaterButton
            // 
            this.WaterButton.Location = new System.Drawing.Point(725, 27);
            this.WaterButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.WaterButton.Name = "WaterButton";
            this.WaterButton.Size = new System.Drawing.Size(167, 160);
            this.WaterButton.TabIndex = 8;
            this.WaterButton.Text = "Iced Water";
            this.WaterButton.UseVisualStyleBackColor = true;
            this.WaterButton.Click += new System.EventHandler(this.WaterButton_Click);
            // 
            // EspressoButton
            // 
            this.EspressoButton.Location = new System.Drawing.Point(902, 27);
            this.EspressoButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.EspressoButton.Name = "EspressoButton";
            this.EspressoButton.Size = new System.Drawing.Size(167, 160);
            this.EspressoButton.TabIndex = 9;
            this.EspressoButton.Text = "Espresso";
            this.EspressoButton.UseVisualStyleBackColor = true;
            this.EspressoButton.Click += new System.EventHandler(this.EspressoButton_Click);
            // 
            // AddDrinkButton
            // 
            this.AddDrinkButton.Location = new System.Drawing.Point(889, 801);
            this.AddDrinkButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddDrinkButton.Name = "AddDrinkButton";
            this.AddDrinkButton.Size = new System.Drawing.Size(179, 79);
            this.AddDrinkButton.TabIndex = 12;
            this.AddDrinkButton.Text = "Add Drink";
            this.AddDrinkButton.UseVisualStyleBackColor = true;
            this.AddDrinkButton.Click += new System.EventHandler(this.AddDrinkButton_Click);
            // 
            // AddCustomizationButton
            // 
            this.AddCustomizationButton.Location = new System.Drawing.Point(688, 801);
            this.AddCustomizationButton.Name = "AddCustomizationButton";
            this.AddCustomizationButton.Size = new System.Drawing.Size(171, 79);
            this.AddCustomizationButton.TabIndex = 13;
            this.AddCustomizationButton.Text = "Add Customization";
            this.AddCustomizationButton.UseVisualStyleBackColor = true;
            // 
            // TestLabel
            // 
            this.TestLabel.AutoSize = true;
            this.TestLabel.ForeColor = System.Drawing.Color.Snow;
            this.TestLabel.Location = new System.Drawing.Point(393, 214);
            this.TestLabel.Name = "TestLabel";
            this.TestLabel.Size = new System.Drawing.Size(116, 15);
            this.TestLabel.TabIndex = 14;
            this.TestLabel.Text = "TEST LABEL REMOVE";
            this.TestLabel.Click += new System.EventHandler(this.TestLabel_Click);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.TestLabel);
            this.Controls.Add(this.AddCustomizationButton);
            this.Controls.Add(this.AddDrinkButton);
            this.Controls.Add(this.EspressoButton);
            this.Controls.Add(this.WaterButton);
            this.Controls.Add(this.CoffeeButton);
            this.Controls.Add(this.MatchaButton);
            this.Controls.Add(this.IcedLatteButton);
            this.Controls.Add(this.LatteButton);
            this.Controls.Add(this.CheckoutButton);
            this.Controls.Add(this.CancelButton);
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CancelButton;
        private Button CheckoutButton;
        private Button LatteButton;
        private Button IcedLatteButton;
        private Button MatchaButton;
        private Button CoffeeButton;
        private Button WaterButton;
        private Button EspressoButton;
        private Button AddDrinkButton;
        private Button AddCustomizationButton;
        private Label TestLabel;
    }
}