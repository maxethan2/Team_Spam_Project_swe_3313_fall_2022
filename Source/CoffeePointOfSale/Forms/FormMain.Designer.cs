namespace CoffeePointOfSale.Forms;

sealed partial class FormMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.btnManagement = new System.Windows.Forms.Button();
            this.CustomerList = new System.Windows.Forms.Button();
            this.CustomerListButton = new System.Windows.Forms.Button();
            this.OrderButton = new System.Windows.Forms.Button();
            this.ManagementButton = new System.Windows.Forms.Button();
            this.MainMenuFakeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManagement
            // 
            this.btnManagement.Location = new System.Drawing.Point(0, 0);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Size = new System.Drawing.Size(75, 23);
            this.btnManagement.TabIndex = 0;
            // 
            // CustomerList
            // 
            this.CustomerList.Location = new System.Drawing.Point(0, 0);
            this.CustomerList.Name = "CustomerList";
            this.CustomerList.Size = new System.Drawing.Size(75, 23);
            this.CustomerList.TabIndex = 0;
            // 
            // CustomerListButton
            // 
            this.CustomerListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.CustomerListButton.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomerListButton.ForeColor = System.Drawing.Color.Snow;
            this.CustomerListButton.Location = new System.Drawing.Point(688, 146);
            this.CustomerListButton.Name = "CustomerListButton";
            this.CustomerListButton.Size = new System.Drawing.Size(544, 278);
            this.CustomerListButton.TabIndex = 1;
            this.CustomerListButton.Text = "Customer List";
            this.CustomerListButton.UseVisualStyleBackColor = false;
            this.CustomerListButton.Click += new System.EventHandler(this.buttonCustomerList_Click);
            // 
            // OrderButton
            // 
            this.OrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.OrderButton.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrderButton.ForeColor = System.Drawing.Color.Snow;
            this.OrderButton.Location = new System.Drawing.Point(113, 146);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(549, 489);
            this.OrderButton.TabIndex = 2;
            this.OrderButton.Text = "ORDER";
            this.OrderButton.UseVisualStyleBackColor = false;
            this.OrderButton.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // ManagementButton
            // 
            this.ManagementButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.ManagementButton.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ManagementButton.ForeColor = System.Drawing.Color.Snow;
            this.ManagementButton.Location = new System.Drawing.Point(688, 452);
            this.ManagementButton.Name = "ManagementButton";
            this.ManagementButton.Size = new System.Drawing.Size(546, 183);
            this.ManagementButton.TabIndex = 3;
            this.ManagementButton.Text = "Management";
            this.ManagementButton.UseVisualStyleBackColor = false;
            this.ManagementButton.Click += new System.EventHandler(this.ManagementButton_Click);
            // 
            // MainMenuFakeButton
            // 
            this.MainMenuFakeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(82)))), ((int)(((byte)(94)))));
            this.MainMenuFakeButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuFakeButton.ForeColor = System.Drawing.Color.Snow;
            this.MainMenuFakeButton.Location = new System.Drawing.Point(114, 56);
            this.MainMenuFakeButton.Name = "MainMenuFakeButton";
            this.MainMenuFakeButton.Size = new System.Drawing.Size(1120, 55);
            this.MainMenuFakeButton.TabIndex = 4;
            this.MainMenuFakeButton.Text = "Main Menu";
            this.MainMenuFakeButton.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.MainMenuFakeButton);
            this.Controls.Add(this.ManagementButton);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.CustomerListButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormMainClosed);
            this.ResumeLayout(false);

    }

    #endregion

    private Button btnManagement;
    private Button CustomerList;
    private Button CustomerListButton;
    private Button OrderButton;
    private Button ManagementButton;
    private Button MainMenuFakeButton;
}