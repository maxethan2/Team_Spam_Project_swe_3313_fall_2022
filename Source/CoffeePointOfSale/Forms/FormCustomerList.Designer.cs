namespace CoffeePointOfSale.Forms
{
    partial class FormCustomerList
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
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.CustomerListTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderSelectedCustomerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerListTable)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Red;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.ForeColor = System.Drawing.Color.Snow;
            this.CancelButton.Location = new System.Drawing.Point(1123, 658);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(192, 50);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.AddCustomerButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddCustomerButton.ForeColor = System.Drawing.Color.Snow;
            this.AddCustomerButton.Location = new System.Drawing.Point(903, 658);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(192, 50);
            this.AddCustomerButton.TabIndex = 2;
            this.AddCustomerButton.Text = "Add Customer";
            this.AddCustomerButton.UseVisualStyleBackColor = false;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // CustomerListTable
            // 
            this.CustomerListTable.AllowUserToAddRows = false;
            this.CustomerListTable.AllowUserToDeleteRows = false;
            this.CustomerListTable.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.CustomerListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerListTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.CustomerListTable.Location = new System.Drawing.Point(120, 79);
            this.CustomerListTable.MultiSelect = false;
            this.CustomerListTable.Name = "CustomerListTable";
            this.CustomerListTable.ReadOnly = true;
            this.CustomerListTable.RowHeadersWidth = 62;
            this.CustomerListTable.RowTemplate.Height = 33;
            this.CustomerListTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CustomerListTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerListTable.Size = new System.Drawing.Size(1184, 501);
            this.CustomerListTable.TabIndex = 3;
            this.CustomerListTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerListTable_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(381, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "TEST LABEL REMOVE THIS";
            // 
            // OrderSelectedCustomerButton
            // 
            this.OrderSelectedCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.OrderSelectedCustomerButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrderSelectedCustomerButton.ForeColor = System.Drawing.Color.Snow;
            this.OrderSelectedCustomerButton.Location = new System.Drawing.Point(609, 605);
            this.OrderSelectedCustomerButton.Name = "OrderSelectedCustomerButton";
            this.OrderSelectedCustomerButton.Size = new System.Drawing.Size(263, 103);
            this.OrderSelectedCustomerButton.TabIndex = 5;
            this.OrderSelectedCustomerButton.Text = "Use this Customer";
            this.OrderSelectedCustomerButton.UseVisualStyleBackColor = false;
            this.OrderSelectedCustomerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1344, 712);
            this.Controls.Add(this.OrderSelectedCustomerButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerListTable);
            this.Controls.Add(this.AddCustomerButton);
            this.Controls.Add(this.CancelButton);
            this.Margin = new System.Windows.Forms.Padding(13, 22, 13, 22);
            this.Name = "FormCustomerList";
            this.Text = "FormCustomerList";
            ((System.ComponentModel.ISupportInitialize)(this.CustomerListTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CancelButton;
        private Button AddCustomerButton;
        private DataGridView CustomerListTable;
        private DataGridViewTextBoxColumn Column1;
        private Label label1;
        private Button OrderSelectedCustomerButton;
    }
}