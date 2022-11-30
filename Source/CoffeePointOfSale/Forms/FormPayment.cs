using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;
using CreditCardValidator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
            RewardsTotalLabel.Text = _customerService.Customers.List[selectedCustomer].RewardPoints.ToString();
            if (_customerService.Customers.List[selectedCustomer].RewardPoints == 0)//disables and changes button color when customer is too poor
            {
                PayRewardsButton.BackColor = Color.Black;//placeholder color #todo
                PayRewardsButton.Enabled = false;
            }
            ErrorLabel.Text = "";
            //TotalPrice.Text = 
            //RewardPointsNeededLabel.Text =
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            selectedCustomer = 0; //resets back to anonymous
            Close(); //closes this form
            FormFactory.Get<FormMain>().Show();
        }

        private void CardInfoTextBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void PayWithCreditButton_Click(object sender, EventArgs e)
        {
            try
            {
                CreditCardDetector detector = new CreditCardDetector(maskedTextBox1.Text);
                if (detector.IsValid() == true)
                {
                    //flow to complete purchase 
                    
                    Close(); //closes this form
                    FormFactory.Get<FormReceipt>().Show();
                }
                else
                {
                    ErrorLabel.Text = "Invalid Credit Card";
                }
            }
            catch (Exception ex) { }
        }
    }
}

