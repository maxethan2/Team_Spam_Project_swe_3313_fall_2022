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
            this.SuspendLayout();
            // 
            // FinalizeTransactionLabel
            // 
            this.FinalizeTransactionLabel.AutoSize = true;
            this.FinalizeTransactionLabel.Enabled = false;
            this.FinalizeTransactionLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FinalizeTransactionLabel.ForeColor = System.Drawing.Color.Snow;
            this.FinalizeTransactionLabel.Location = new System.Drawing.Point(474, 13);
            this.FinalizeTransactionLabel.Name = "FinalizeTransactionLabel";
            this.FinalizeTransactionLabel.Size = new System.Drawing.Size(247, 37);
            this.FinalizeTransactionLabel.TabIndex = 0;
            this.FinalizeTransactionLabel.Text = "Finalize Transaction";
            // 
            // PayCardLabel
            // 
            this.PayCardLabel.AutoSize = true;
            this.PayCardLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PayCardLabel.ForeColor = System.Drawing.Color.Snow;
            this.PayCardLabel.Location = new System.Drawing.Point(122, 205);
            this.PayCardLabel.Name = "PayCardLabel";
            this.PayCardLabel.Size = new System.Drawing.Size(193, 28);
            this.PayCardLabel.TabIndex = 1;
            this.PayCardLabel.Text = "Pay With Credit Card";
            // 
            // EnterCardLabel
            // 
            this.EnterCardLabel.AutoSize = true;
            this.EnterCardLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterCardLabel.ForeColor = System.Drawing.Color.Snow;
            this.EnterCardLabel.Location = new System.Drawing.Point(70, 279);
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
            this.TotalRewardPointsLabel.Location = new System.Drawing.Point(845, 279);
            this.TotalRewardPointsLabel.Name = "TotalRewardPointsLabel";
            this.TotalRewardPointsLabel.Size = new System.Drawing.Size(174, 25);
            this.TotalRewardPointsLabel.TabIndex = 5;
            this.TotalRewardPointsLabel.Text = "Total Reward Points: ";
            // 
            // RewardPayLabel
            // 
            this.RewardPayLabel.AutoSize = true;
            this.RewardPayLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RewardPayLabel.ForeColor = System.Drawing.Color.Snow;
            this.RewardPayLabel.Location = new System.Drawing.Point(897, 205);
            this.RewardPayLabel.Name = "RewardPayLabel";
            this.RewardPayLabel.Size = new System.Drawing.Size(216, 28);
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
            this.RewardPointsNeededLabel.Location = new System.Drawing.Point(845, 348);
            this.RewardPointsNeededLabel.Name = "RewardPointsNeededLabel";
            this.RewardPointsNeededLabel.Size = new System.Drawing.Size(199, 25);
            this.RewardPointsNeededLabel.TabIndex = 7;
            this.RewardPointsNeededLabel.Text = "Reward Points Needed: ";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(70, 335);
            this.maskedTextBox1.Mask = "0000 0000 0000 0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(245, 23);
            this.maskedTextBox1.TabIndex = 8;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1348, 721);
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
    }
}