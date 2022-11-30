namespace CoffeePointOfSale.Forms
{
    partial class FormAddCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddCustomerConfirmButton = new System.Windows.Forms.Button();
            this.PhoneNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Red;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.ForeColor = System.Drawing.Color.Snow;
            this.CancelButton.Location = new System.Drawing.Point(1130, 658);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(192, 50);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Document);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(369, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Name (Last, First)";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Document);
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(369, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phone Number";
            // 
            // AddCustomerConfirmButton
            // 
            this.AddCustomerConfirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.AddCustomerConfirmButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddCustomerConfirmButton.ForeColor = System.Drawing.Color.Snow;
            this.AddCustomerConfirmButton.Location = new System.Drawing.Point(528, 539);
            this.AddCustomerConfirmButton.Name = "AddCustomerConfirmButton";
            this.AddCustomerConfirmButton.Size = new System.Drawing.Size(294, 81);
            this.AddCustomerConfirmButton.TabIndex = 5;
            this.AddCustomerConfirmButton.Text = "Confirm";
            this.AddCustomerConfirmButton.UseVisualStyleBackColor = false;
            this.AddCustomerConfirmButton.Click += new System.EventHandler(this.AddCustomerConfirmButton_Click);
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(369, 328);
            this.PhoneNumberTextBox.Mask = "999-000-0000";
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(610, 33);
            this.PhoneNumberTextBox.TabIndex = 6;
            this.PhoneNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PhoneNumberTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameTextBox.Location = new System.Drawing.Point(369, 238);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.PlaceholderText = "Enter Name Here";
            this.NameTextBox.Size = new System.Drawing.Size(610, 34);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
 
            // 
            // FormAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.AddCustomerConfirmButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.CancelButton);
            this.Margin = new System.Windows.Forms.Padding(13, 22, 13, 22);
            this.Name = "FormAddCustomer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormAddCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CancelButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button AddCustomerConfirmButton;
        private MaskedTextBox PhoneNumberTextBox;
        private TextBox NameTextBox;
    }
}