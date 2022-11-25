using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Services.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;

namespace CoffeePointOfSale.Forms
{
  
    public partial class FormAddCustomer : FormNoCloseBase
    {
        private readonly ICustomerService _customerService;
        private IAppSettings _appSettings;
        public  FormAddCustomer(IAppSettings appSettings, ICustomerService customerService) :base(appSettings)
        {
            _customerService = customerService;
            _appSettings = appSettings;
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close(); //closes this form
            FormFactory.Get<FormMain>().Show(); //re-opens the main form
        }

        private void FormAddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.Text = string.Empty;
        }
        
        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            this.Text = string.Empty;
        }

        private void AddCustomerConfirmButton_Click(object sender, EventArgs e)
        {
            Close(); //closes this form
            FormFactory.Get<FormOrder>().Show();
        }
    }
}
