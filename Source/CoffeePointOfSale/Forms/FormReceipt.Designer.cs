namespace CoffeePointOfSale.Forms.Base
{
    partial class FormReceipt
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.ItemsDetailsLabel = new System.Windows.Forms.Label();
            this.CostDetailsLabel = new System.Windows.Forms.Label();
            this.PaymentDetailsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.MainMenuButton.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuButton.ForeColor = System.Drawing.Color.Snow;
            this.MainMenuButton.Location = new System.Drawing.Point(945, 557);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(331, 132);
            this.MainMenuButton.TabIndex = 1;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = false;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Snow;
            this.pictureBox1.Location = new System.Drawing.Point(377, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 554);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Snow;
            this.TitleLabel.Enabled = false;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.ForeColor = System.Drawing.Color.Black;
            this.TitleLabel.Location = new System.Drawing.Point(532, 89);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(135, 45);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Reciept";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(404, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "____________________________";
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.BackColor = System.Drawing.Color.Snow;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomerNameLabel.Location = new System.Drawing.Point(478, 144);
            this.CustomerNameLabel.MaximumSize = new System.Drawing.Size(500, 0);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(257, 25);
            this.CustomerNameLabel.TabIndex = 5;
            this.CustomerNameLabel.Text = "Order Placed by (Name here)";
            this.CustomerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemsDetailsLabel
            // 
            this.ItemsDetailsLabel.AutoSize = true;
            this.ItemsDetailsLabel.BackColor = System.Drawing.Color.Snow;
            this.ItemsDetailsLabel.Enabled = false;
            this.ItemsDetailsLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ItemsDetailsLabel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.ItemsDetailsLabel.Location = new System.Drawing.Point(404, 216);
            this.ItemsDetailsLabel.MaximumSize = new System.Drawing.Size(448, 300);
            this.ItemsDetailsLabel.Name = "ItemsDetailsLabel";
            this.ItemsDetailsLabel.Size = new System.Drawing.Size(272, 28);
            this.ItemsDetailsLabel.TabIndex = 6;
            this.ItemsDetailsLabel.Text = "This will list out items ordered";
            // 
            // CostDetailsLabel
            // 
            this.CostDetailsLabel.AutoSize = true;
            this.CostDetailsLabel.BackColor = System.Drawing.Color.Snow;
            this.CostDetailsLabel.Enabled = false;
            this.CostDetailsLabel.Location = new System.Drawing.Point(404, 440);
            this.CostDetailsLabel.Name = "CostDetailsLabel";
            this.CostDetailsLabel.Size = new System.Drawing.Size(116, 15);
            this.CostDetailsLabel.TabIndex = 7;
            this.CostDetailsLabel.Text = "This will list out cost ";
            this.CostDetailsLabel.Click += new System.EventHandler(this.CostDetailsLabel_Click);
            // 
            // PaymentDetailsLabel
            // 
            this.PaymentDetailsLabel.AutoSize = true;
            this.PaymentDetailsLabel.BackColor = System.Drawing.Color.Snow;
            this.PaymentDetailsLabel.Enabled = false;
            this.PaymentDetailsLabel.Location = new System.Drawing.Point(404, 557);
            this.PaymentDetailsLabel.Name = "PaymentDetailsLabel";
            this.PaymentDetailsLabel.Size = new System.Drawing.Size(154, 15);
            this.PaymentDetailsLabel.TabIndex = 8;
            this.PaymentDetailsLabel.Text = "This will list payment details";
            // 
            // FormReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.PaymentDetailsLabel);
            this.Controls.Add(this.CostDetailsLabel);
            this.Controls.Add(this.ItemsDetailsLabel);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MainMenuButton);
            this.Name = "FormReceipt";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button MainMenuButton;
        private PictureBox pictureBox1;
        private Label TitleLabel;
        private Label label1;
        private Label CustomerNameLabel;
        private Label ItemsDetailsLabel;
        private Label CostDetailsLabel;
        private Label PaymentDetailsLabel;
    }
}