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
using System.Globalization;
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


            var OrderIndex = _customerService.SelectedCustomer.Orders.Count - 1;
            var RequiredRewardsPoints = Math.Ceiling(_customerService.SelectedCustomer.Orders[OrderIndex].Total);
            
            InitializeComponent();
            RewardsTotalLabel.Text = _customerService.SelectedCustomer.RewardPoints.ToString();

            if (_customerService.SelectedCustomer.RewardPoints <= RequiredRewardsPoints)
                //disables and changes button color when customer is too poor
            { 
                PayRewardsButton.BackColor = Color.FromArgb(36, 39, 42); PayRewardsButton.ForeColor = Color.FromArgb(36, 39, 42);
                PayRewardsButton.Enabled = false;
            }



            TotalPrice.Text ="Total Price is: " +_customerService.SelectedCustomer.Orders[OrderIndex].Total.ToString("C2", CultureInfo.CurrentCulture);
            RewardsNeededLabel.Text = RequiredRewardsPoints.ToString();
            ErrorLabel.Text = "";
            ErrorLabel2.Text = "";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
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

                    //get last four digits of credit card number
                    CreditcardLastFour = maskedTextBox1.Text.Substring(14);


                    //set payment method to credit
                    var OrderIndex = _customerService.SelectedCustomer.Orders.Count - 1;
                    _customerService.SelectedCustomer.Orders[OrderIndex].PaymentMethod = "Credit";
                    //add rewards points to customer
                    if (!_customerService.SelectedCustomer.FirstName.Equals("Anonymous"))
                    {
                        _customerService.SelectedCustomer.RewardPoints += (int)Math.Floor(_customerService.SelectedCustomer.Orders[OrderIndex].Total);
                    }
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

        private void FinalizeTransactionLabel_Click(object sender, EventArgs e)
        {

        }

        private void PayRewardsButton_Click(object sender, EventArgs e)
        {
            var OrderIndex = _customerService.SelectedCustomer.Orders.Count - 1;
            var RequiredRewardsPoints = Math.Ceiling(_customerService.SelectedCustomer.Orders[OrderIndex].Total);
            // check to see if customer has enough rewards points
            if (_customerService.SelectedCustomer.RewardPoints >= RequiredRewardsPoints)
            {
                //subtract rewards points
                _customerService.SelectedCustomer.RewardPoints -= (int)RequiredRewardsPoints;

                //set payment method to rewards points
                var OrderIndexR = _customerService.SelectedCustomer.Orders.Count - 1;
                _customerService.SelectedCustomer.Orders[OrderIndexR].PaymentMethod = "Rewards Points";
                Close();
                FormFactory.Get<FormReceipt>().Show();
            }
            else
            {
                ErrorLabel2.Text = "Not enough rewards points";
            }
        }
    }
}

