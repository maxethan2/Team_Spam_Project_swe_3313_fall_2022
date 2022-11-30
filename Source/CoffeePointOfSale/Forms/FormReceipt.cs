using CoffeePointOfSale.Configuration;
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

namespace CoffeePointOfSale.Forms.Base
{
    public partial class FormReceipt : FormNoCloseBase
    {
        private readonly ICustomerService _customerService;
        private IAppSettings _appSettings;
        public FormReceipt(IAppSettings appSettings, ICustomerService customerService) : base(appSettings)
        {
            _customerService = customerService;
            _appSettings = appSettings;
            InitializeComponent();
            CustomerNameLabel.Text = "Order Placed by " + _customerService.Customers.List[selectedCustomer].FirstName;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Close(); //closes this form
            FormFactory.Get<FormMain>().Show();
        }
    }
}
