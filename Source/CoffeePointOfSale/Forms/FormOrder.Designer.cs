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
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.CheckoutButton.Size = new System.Drawing.Size(218, 67);
            this.CheckoutButton.TabIndex = 3;
            this.CheckoutButton.Text = "Continue to Checkout";
            this.CheckoutButton.UseVisualStyleBackColor = true;
            this.CheckoutButton.Click += new System.EventHandler(this.CheckoutButton_Click_1);
            // 
            // LatteButton
            // 
            this.LatteButton.Location = new System.Drawing.Point(14, 67);
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
            this.IcedLatteButton.Location = new System.Drawing.Point(196, 67);
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
            this.MatchaButton.Location = new System.Drawing.Point(373, 67);
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
            this.CoffeeButton.Location = new System.Drawing.Point(550, 67);
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
            this.WaterButton.Location = new System.Drawing.Point(725, 67);
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
            this.EspressoButton.Location = new System.Drawing.Point(902, 67);
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
            this.TestLabel.Location = new System.Drawing.Point(600, 605);
            this.TestLabel.Name = "TestLabel";
            this.TestLabel.Size = new System.Drawing.Size(116, 15);
            this.TestLabel.TabIndex = 14;
            this.TestLabel.Text = "TEST LABEL REMOVE";
            this.TestLabel.Click += new System.EventHandler(this.TestLabel_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(15, 383);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 27;
            this.button13.Text = "Sugar";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(107, 383);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 28;
            this.button14.Text = "Stevia";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(195, 383);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 29;
            this.button15.Text = "Sweet\'N Low";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(15, 421);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 30;
            this.button16.Text = "Extra Ice";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(107, 421);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 23);
            this.button17.TabIndex = 31;
            this.button17.Text = "No Ice";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(195, 421);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 23);
            this.button18.TabIndex = 32;
            this.button18.Text = "Less Hot";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(287, 421);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 23);
            this.button19.TabIndex = 33;
            this.button19.Text = "Very Hot";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(1123, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(218, 553);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton2.Location = new System.Drawing.Point(71, 265);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(54, 19);
            this.radioButton2.TabIndex = 36;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Large";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton3.Location = new System.Drawing.Point(126, 265);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(55, 19);
            this.radioButton3.TabIndex = 37;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Mega";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton4.Location = new System.Drawing.Point(11, 290);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(95, 19);
            this.radioButton4.TabIndex = 38;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Non-Fat Milk";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton1.Location = new System.Drawing.Point(287, 290);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 19);
            this.radioButton1.TabIndex = 39;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Almond Milk";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton5.Location = new System.Drawing.Point(112, 290);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(85, 19);
            this.radioButton5.TabIndex = 40;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Whole Milk";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton6.Location = new System.Drawing.Point(211, 290);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(70, 19);
            this.radioButton6.TabIndex = 41;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Oat Milk";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton7.Location = new System.Drawing.Point(387, 290);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(70, 19);
            this.radioButton7.TabIndex = 42;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Soy Milk";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton8.Location = new System.Drawing.Point(463, 290);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(113, 19);
            this.radioButton8.TabIndex = 43;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Room for Cream";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton9.Location = new System.Drawing.Point(152, 315);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(97, 19);
            this.radioButton9.TabIndex = 46;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "decaffeinated";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton10.Location = new System.Drawing.Point(81, 315);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(65, 19);
            this.radioButton10.TabIndex = 45;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Matcha";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton11.Location = new System.Drawing.Point(11, 315);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(70, 19);
            this.radioButton11.TabIndex = 44;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "Espresso";
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.CheckedChanged += new System.EventHandler(this.radioButton11_CheckedChanged);
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton12.Location = new System.Drawing.Point(12, 265);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(54, 19);
            this.radioButton12.TabIndex = 47;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "Small";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.radioButton12);
            this.Controls.Add(this.radioButton9);
            this.Controls.Add(this.radioButton10);
            this.Controls.Add(this.radioButton11);
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton1;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private RadioButton radioButton8;
        private RadioButton radioButton9;
        private RadioButton radioButton10;
        private RadioButton radioButton11;
        private RadioButton radioButton12;
    }
}