using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeePointOfSale.Forms
{
    public partial class FormPayment : FormNoCloseBase
    {
        private readonly ICustomerService _customerService;
        private IAppSettings _appSettings;
        public FormPayment(IAppSettings appSettings, ICustomerService customerService) : base(appSettings)
        {
            _customerService = customerService;
            _appSettings = appSettings;
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close(); //closes this form
            FormFactory.Get<FormMain>().Show();
        }

        private void CardInfoTextBox_TextChanged(object sender, EventArgs e)
        {
            this.Text= string.Empty;
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TotalRewardPointsLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
