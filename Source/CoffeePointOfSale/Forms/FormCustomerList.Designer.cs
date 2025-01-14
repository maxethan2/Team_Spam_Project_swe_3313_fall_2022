﻿namespace CoffeePointOfSale.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.CustomerListTable = new System.Windows.Forms.DataGridView();
            this.CustomerList = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.CustomerList});
            this.CustomerListTable.Location = new System.Drawing.Point(77, 73);
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
            // CustomerList
            // 
            this.CustomerList.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.CustomerList.DefaultCellStyle = dataGridViewCellStyle1;
            this.CustomerList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerList.HeaderText = "";
            this.CustomerList.MinimumWidth = 8;
            this.CustomerList.Name = "CustomerList";
            this.CustomerList.ReadOnly = true;
            this.CustomerList.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // OrderSelectedCustomerButton
            // 
            this.OrderSelectedCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.OrderSelectedCustomerButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrderSelectedCustomerButton.ForeColor = System.Drawing.Color.Snow;
            this.OrderSelectedCustomerButton.Location = new System.Drawing.Point(537, 597);
            this.OrderSelectedCustomerButton.Name = "OrderSelectedCustomerButton";
            this.OrderSelectedCustomerButton.Size = new System.Drawing.Size(263, 103);
            this.OrderSelectedCustomerButton.TabIndex = 5;
            this.OrderSelectedCustomerButton.Text = "Use this Customer";
            this.OrderSelectedCustomerButton.UseVisualStyleBackColor = false;
            this.OrderSelectedCustomerButton.Click += new System.EventHandler(this.OrderSelectedCustomerButton_Click);
            // 
            // FormCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.OrderSelectedCustomerButton);
            this.Controls.Add(this.CustomerListTable);
            this.Controls.Add(this.AddCustomerButton);
            this.Controls.Add(this.CancelButton);
            this.Margin = new System.Windows.Forms.Padding(13, 22, 13, 22);
            this.Name = "FormCustomerList";
            this.Text = "FormCustomerList";
            ((System.ComponentModel.ISupportInitialize)(this.CustomerListTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button CancelButton;
        private Button AddCustomerButton;
        private DataGridView CustomerListTable;
        private Button OrderSelectedCustomerButton;
        private DataGridViewButtonColumn CustomerList;
    }
}