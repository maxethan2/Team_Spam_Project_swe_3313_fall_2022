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
    /*
     * Current Customer is tracked through variable selectedCustomer located in FormNoCloseBase
     * this variable acts as an indexer for the customer list
     * if there is a better method to track which customer is being used feel free to change it 
     */
    public partial class FormOrder : FormNoCloseBase
    {
        private readonly ICustomerService _customerService;
        private IAppSettings _appSettings;
        public FormOrder(IAppSettings appSettings, ICustomerService customerService) : base(appSettings)
        {
            _customerService = customerService;
            _appSettings = appSettings;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedCustomer = 0; // sets the customer back to anonymous
            Close(); //closes this form
            FormFactory.Get<FormMain>().Show(); 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void FormOrder_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
