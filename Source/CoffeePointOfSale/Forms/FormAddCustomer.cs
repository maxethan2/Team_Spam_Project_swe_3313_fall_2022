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
using System.Text.RegularExpressions;
using System.Drawing.Text;
using CoffeePointOfSale.Services.Storage;

namespace CoffeePointOfSale.Forms
{

    public partial class FormAddCustomer : FormNoCloseBase
    {
        string FullName;
        string PhoneNumber;

        private readonly ICustomerService _customerService;
        private IAppSettings _appSettings;
        public FormAddCustomer(IAppSettings appSettings, ICustomerService customerService) : base(appSettings)
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

        private void AddCustomerConfirmButton_Click(object sender, EventArgs e)
        {
            string nameTextBoxInput = NameTextBox.Text;
            string phoneTextBoxInput = PhoneNumberTextBox.Text;
            if ((ValidateNameInput(nameTextBoxInput) == true) &&
                (ValidatePhoneInput(phoneTextBoxInput) == true))
                    AddCustomer(nameTextBoxInput);

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)//this textbox only accepts 10 integers
        {

        }
        private bool ValidateNameInput(string names)
        {
            Regex regex = new Regex(@"[a-zA-Z]+,[a-zA-Z]"); //checks for comma
            if (regex.IsMatch(names) == false)
            {
                NameTextBox.Text += " Please Enter in correct format";
                return false;
            }
            return true;
        }
        private bool ValidatePhoneInput(string phone)
        {
            if (phone != null && phone.Length == 12)//accounting for dashes
            {
                return true;
            }
            NameTextBox.Text += " Phone Number Text is wrong";
            return false;
        }

        private void AddCustomer(string nameTextBoxInput)
        {
            try
            {
                string[] customerName = nameTextBoxInput.Split(',');
                string lastName = customerName[0];
                string firstName = customerName[1];
                Customer tempCust = new Customer();
                tempCust.FirstName = firstName;
                tempCust.LastName = lastName;
                tempCust.Phone = PhoneNumberTextBox.Text;


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
            catch (Exception ex) { NameTextBox.Text = nameTextBoxInput + " Please Enter in correct format"; }
        }
   
    }
}   


