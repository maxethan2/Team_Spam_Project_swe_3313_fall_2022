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
using CoffeePointOfSale.Services.Storage;

namespace CoffeePointOfSale.Forms
{
    
    public partial class FormAddCustomer : FormNoCloseBase
    {
        string FullName;
        string PhoneNumber;

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
            //this.Text = string.Empty;
            FullName = NameTextBox.Text;
        }
        
        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            //this.Text = string.Empty;
            PhoneNumber = PhoneTextBox.Text;
        }

        private void AddCustomerConfirmButton_Click(object sender, EventArgs e)
        {
            //add customer to json list
            string[] FullNameArray = FullName.Split(' ');
            string FirstName = FullNameArray[0];
            string LastName = FullNameArray[1];
            // add customer data to customer object
            Customer tempCust = new Customer();
            tempCust.FirstName = FirstName;
            tempCust.LastName = LastName;
            tempCust.Phone = PhoneNumber;


            // add the customer to the dictionary
            Customers customers = new Customers();
            if (customers.Add(tempCust))
            {
                StorageService storageService = new StorageService();
                CustomerService customerService = new CustomerService(storageService);
                customerService.CreateCustomer(tempCust);
                Close(); //closes this form
                FormFactory.Get<FormOrder>().Show();
            }

        }
    }
}
