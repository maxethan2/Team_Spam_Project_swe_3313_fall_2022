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
    public partial class FormCustomerList : FormNoCloseBase
    {
        public int index;
        private readonly ICustomerService _customerService;
        private IAppSettings _appSettings;
        public FormCustomerList(IAppSettings appSettings, ICustomerService customerService) : base(appSettings)
        {
            _customerService = customerService;
            _appSettings = appSettings;
            InitializeComponent();
            DemonstrateGettingCustomerList();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close(); //closes this form
            FormFactory.Get<FormMain>().Show(); //re-opens the main form
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            Close(); //closes this form
            FormFactory.Get<FormAddCustomer>().Show(); //re-opens the main form
        }
        private void DemonstrateGettingCustomerList()
        {            
           for (var customerIdx = 0; customerIdx < _customerService.Customers.List.Count; customerIdx++)
            {
               var customers = _customerService.Customers.List[customerIdx];   
               CustomerListTable.Rows.Add(customers);
            }
        }

        private void CustomerListTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            index = this.CustomerListTable.SelectedRows[0].Cells[0].RowIndex;
            selectedCustomer = index; // tracks customer 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();//closes this form
            FormFactory.Get<FormOrder>().Show();
        }
    }
}
