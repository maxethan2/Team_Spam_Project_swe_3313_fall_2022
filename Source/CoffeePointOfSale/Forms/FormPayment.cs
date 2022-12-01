﻿using CoffeePointOfSale.Configuration;
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
            RewardsTotalLabel.Text = _customerService.SelectedCustomer.RewardPoints.ToString();
            if (_customerService.SelectedCustomer.RewardPoints == 0)//disables and changes button color when customer is too poor
            {                                                       //replace 0 with cost amount
                PayRewardsButton.BackColor = Color.Black;//placeholder color #todo
                PayRewardsButton.Enabled = false;
            }
            ErrorLabel.Text = "";
            ErrorLabel2.Text = "";
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

        private void FinalizeTransactionLabel_Click(object sender, EventArgs e)
        {

        }

        private void PayRewardsButton_Click(object sender, EventArgs e)
        {
            // check to see if customer has enough rewards points
            if (_customerService.SelectedCustomer.RewardPoints >= 0)
            {
                //subtract rewards points
                _customerService.SelectedCustomer.RewardPoints -= 100;
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

