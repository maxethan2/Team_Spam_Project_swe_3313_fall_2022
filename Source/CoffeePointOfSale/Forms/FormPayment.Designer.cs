namespace CoffeePointOfSale.Forms
{
    partial class FormPayment
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
            this.FinalizeTransactionLabel = new System.Windows.Forms.Label();
            this.PayCardLabel = new System.Windows.Forms.Label();
            this.EnterCardLabel = new System.Windows.Forms.Label();
            this.TotalRewardPointsLabel = new System.Windows.Forms.Label();
            this.RewardPayLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.RewardPointsNeededLabel = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.RewardsTotalLabel = new System.Windows.Forms.Label();
            this.RewardsNeededLabel = new System.Windows.Forms.Label();
            this.PayWithCreditButton = new System.Windows.Forms.Button();
            this.PayRewardsButton = new System.Windows.Forms.Button();
            this.FakeAccentButton = new System.Windows.Forms.Button();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FinalizeTransactionLabel
            // 
            this.FinalizeTransactionLabel.AutoSize = true;
            this.FinalizeTransactionLabel.Enabled = false;
            this.FinalizeTransactionLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FinalizeTransactionLabel.ForeColor = System.Drawing.Color.Snow;
            this.FinalizeTransactionLabel.Location = new System.Drawing.Point(552, 25);
            this.FinalizeTransactionLabel.Name = "FinalizeTransactionLabel";
            this.FinalizeTransactionLabel.Size = new System.Drawing.Size(247, 37);
            this.FinalizeTransactionLabel.TabIndex = 0;
            this.FinalizeTransactionLabel.Text = "Finalize Transaction";
            this.FinalizeTransactionLabel.Click += new System.EventHandler(this.FinalizeTransactionLabel_Click);
            // 
            // PayCardLabel
            // 
            this.PayCardLabel.AutoSize = true;
            this.PayCardLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PayCardLabel.ForeColor = System.Drawing.Color.Snow;
            this.PayCardLabel.Location = new System.Drawing.Point(170, 187);
            this.PayCardLabel.Name = "PayCardLabel";
            this.PayCardLabel.Size = new System.Drawing.Size(330, 46);
            this.PayCardLabel.TabIndex = 1;
            this.PayCardLabel.Text = "Pay With Credit Card";
            // 
            // EnterCardLabel
            // 
            this.EnterCardLabel.AutoSize = true;
            this.EnterCardLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterCardLabel.ForeColor = System.Drawing.Color.Snow;
            this.EnterCardLabel.Location = new System.Drawing.Point(208, 279);
            this.EnterCardLabel.Name = "EnterCardLabel";
            this.EnterCardLabel.Size = new System.Drawing.Size(245, 25);
            this.EnterCardLabel.TabIndex = 2;
            this.EnterCardLabel.Text = "Enter Credit Card Information";
            // 
            // TotalRewardPointsLabel
            // 
            this.TotalRewardPointsLabel.AutoSize = true;
            this.TotalRewardPointsLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalRewardPointsLabel.ForeColor = System.Drawing.Color.Snow;
            this.TotalRewardPointsLabel.Location = new System.Drawing.Point(869, 279);
            this.TotalRewardPointsLabel.Name = "TotalRewardPointsLabel";
            this.TotalRewardPointsLabel.Size = new System.Drawing.Size(174, 25);
            this.TotalRewardPointsLabel.TabIndex = 5;
            this.TotalRewardPointsLabel.Text = "Total Reward Points: ";
            // 
            // RewardPayLabel
            // 
            this.RewardPayLabel.AutoSize = true;
            this.RewardPayLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RewardPayLabel.ForeColor = System.Drawing.Color.Snow;
            this.RewardPayLabel.Location = new System.Drawing.Point(860, 187);
            this.RewardPayLabel.Name = "RewardPayLabel";
            this.RewardPayLabel.Size = new System.Drawing.Size(371, 46);
            this.RewardPayLabel.TabIndex = 4;
            this.RewardPayLabel.Text = "Pay With Reward Points";
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Red;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.ForeColor = System.Drawing.Color.Snow;
            this.CancelButton.Location = new System.Drawing.Point(1123, 646);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(192, 50);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // RewardPointsNeededLabel
            // 
            this.RewardPointsNeededLabel.AutoSize = true;
            this.RewardPointsNeededLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RewardPointsNeededLabel.ForeColor = System.Drawing.Color.Snow;
            this.RewardPointsNeededLabel.Location = new System.Drawing.Point(860, 373);
            this.RewardPointsNeededLabel.Name = "RewardPointsNeededLabel";
            this.RewardPointsNeededLabel.Size = new System.Drawing.Size(199, 25);
            this.RewardPointsNeededLabel.TabIndex = 7;
            this.RewardPointsNeededLabel.Text = "Reward Points Needed: ";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(114, 322);
            this.maskedTextBox1.Mask = "0000 0000 0000 0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(431, 23);
            this.maskedTextBox1.TabIndex = 8;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // RewardsTotalLabel
            // 
            this.RewardsTotalLabel.AutoSize = true;
            this.RewardsTotalLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RewardsTotalLabel.ForeColor = System.Drawing.Color.Snow;
            this.RewardsTotalLabel.Location = new System.Drawing.Point(1075, 279);
            this.RewardsTotalLabel.Name = "RewardsTotalLabel";
            this.RewardsTotalLabel.Size = new System.Drawing.Size(156, 25);
            this.RewardsTotalLabel.TabIndex = 9;
            this.RewardsTotalLabel.Text = "RewardsTotalLabel";
            // 
            // RewardsNeededLabel
            // 
            this.RewardsNeededLabel.AutoSize = true;
            this.RewardsNeededLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RewardsNeededLabel.ForeColor = System.Drawing.Color.Snow;
            this.RewardsNeededLabel.Location = new System.Drawing.Point(1065, 373);
            this.RewardsNeededLabel.Name = "RewardsNeededLabel";
            this.RewardsNeededLabel.Size = new System.Drawing.Size(181, 25);
            this.RewardsNeededLabel.TabIndex = 10;
            this.RewardsNeededLabel.Text = "RewardsNeededLabel";
            // 
            // PayWithCreditButton
            // 
            this.PayWithCreditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.PayWithCreditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayWithCreditButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PayWithCreditButton.ForeColor = System.Drawing.Color.Snow;
            this.PayWithCreditButton.Location = new System.Drawing.Point(204, 461);
            this.PayWithCreditButton.Name = "PayWithCreditButton";
            this.PayWithCreditButton.Size = new System.Drawing.Size(249, 68);
            this.PayWithCreditButton.TabIndex = 11;
            this.PayWithCreditButton.Text = "Pay";
            this.PayWithCreditButton.UseVisualStyleBackColor = false;
            this.PayWithCreditButton.Click += new System.EventHandler(this.PayWithCreditButton_Click);
            // 
            // PayRewardsButton
            // 
            this.PayRewardsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.PayRewardsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayRewardsButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PayRewardsButton.ForeColor = System.Drawing.Color.Snow;
            this.PayRewardsButton.Location = new System.Drawing.Point(914, 461);
            this.PayRewardsButton.Name = "PayRewardsButton";
            this.PayRewardsButton.Size = new System.Drawing.Size(249, 68);
            this.PayRewardsButton.TabIndex = 12;
            this.PayRewardsButton.Text = "Pay";
            this.PayRewardsButton.UseVisualStyleBackColor = false;
            // 
            // FakeAccentButton
            // 
            this.FakeAccentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.FakeAccentButton.Location = new System.Drawing.Point(674, 171);
            this.FakeAccentButton.Name = "FakeAccentButton";
            this.FakeAccentButton.Size = new System.Drawing.Size(2, 500);
            this.FakeAccentButton.TabIndex = 13;
            this.FakeAccentButton.Text = "button2";
            this.FakeAccentButton.UseVisualStyleBackColor = false;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalPrice.ForeColor = System.Drawing.Color.Snow;
            this.TotalPrice.Location = new System.Drawing.Point(610, 91);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(124, 28);
            this.TotalPrice.TabIndex = 14;
            this.TotalPrice.Text = "Your total is: ";
            this.TotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ErrorLabel.ForeColor = System.Drawing.Color.Snow;
            this.ErrorLabel.Location = new System.Drawing.Point(227, 357);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(202, 21);
            this.ErrorLabel.TabIndex = 15;
            this.ErrorLabel.Text = "Error Messages will go here";
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1348, 694);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.FakeAccentButton);
            this.Controls.Add(this.PayRewardsButton);
            this.Controls.Add(this.PayWithCreditButton);
            this.Controls.Add(this.RewardsNeededLabel);
            this.Controls.Add(this.RewardsTotalLabel);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.RewardPointsNeededLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.TotalRewardPointsLabel);
            this.Controls.Add(this.RewardPayLabel);
            this.Controls.Add(this.EnterCardLabel);
            this.Controls.Add(this.PayCardLabel);
            this.Controls.Add(this.FinalizeTransactionLabel);
            this.Name = "FormPayment";
            this.Text = "FormPayment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label FinalizeTransactionLabel;
        private Label PayCardLabel;
        private Label EnterCardLabel;
        private Label TotalRewardPointsLabel;
        private Label RewardPayLabel;
        private Button CancelButton;
        private Label RewardPointsNeededLabel;
        private MaskedTextBox maskedTextBox1;
        private Label RewardsTotalLabel;
        private Label RewardsNeededLabel;
        private Button PayWithCreditButton;
        private Button PayRewardsButton;
        private Button FakeAccentButton;
        private Label TotalPrice;
        private Label ErrorLabel;
    }
}