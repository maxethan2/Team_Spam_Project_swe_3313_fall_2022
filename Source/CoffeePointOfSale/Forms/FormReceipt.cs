﻿using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Services.CsvExtract;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;
using CoffeePointOfSale.Services.Storage;
using System.Globalization;
using CoffeePointOfSale.Services.Storage;
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

            CustomerNameLabel.Text = _customerService.SelectedCustomer.FirstName + " " + _customerService.SelectedCustomer.LastName;

            CustomerNameLabel.Text = "Order Placed by " + _customerService.SelectedCustomer.FirstName + " " + _customerService.SelectedCustomer.LastName;
            printOrder();
            printOrderTotal();
            printPaymentDetails();

            //if customer is not ananymous write to json
            if (!customerService.SelectedCustomer.FirstName.Equals("Anonymous"))
            {
                StorageService storageService = new StorageService();
                CustomerService customerService1 = new CustomerService(storageService);
                customerService1.CreateCustomer(_customerService.SelectedCustomer);
            }

            
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Close(); //closes this form
            FormFactory.Get<FormMain>().Show();
        }

        private void OrderListLabel_Click(object sender, EventArgs e)
        {
            //useless
        }


        private void printOrder()
        {
            var customer = _customerService.SelectedCustomer;


            var OrderIndex = customer.Orders.Count - 1;
            var Order = customer.Orders[OrderIndex];

            var OrderList = Order.OrderedItems;
            var OrderedItems = "";
            // drink in OrderList
            foreach (var Drink in OrderList)
            {
                OrderedItems += Drink.DrinkName + " x" + Drink.Quantity + ": ";
                // Custimization in each drink
                foreach (var custimization in Drink.Customizations)
                {
                    OrderedItems += custimization + " ";
                }
                // create new line for formatting
                OrderedItems += "\n";
            }

            ItemsDetailsLabel.Text = OrderedItems;
        }

        private void printOrderTotal()
        {
            var customer = _customerService.SelectedCustomer;


            var OrderIndex = customer.Orders.Count - 1;
            var Order = customer.Orders[OrderIndex];

            var details = $"Total: {Order.Total.ToString("C2", CultureInfo.CurrentCulture)}\nSubTotal: {Order.Subtotal.ToString("C2", CultureInfo.CurrentCulture)}\nTax: {Order.Tax.ToString("C2", CultureInfo.CurrentCulture)}";
            CostDetailsLabel.Text = details;
        }

        private void printPaymentDetails()
        {
            var customer = _customerService.SelectedCustomer;


            var OrderIndex = customer.Orders.Count - 1;
            var Order = customer.Orders[OrderIndex];

            var details = "";
            if (Order.PaymentMethod.Equals("Credit"))
            {
                details += $"Paid with credit card ending in {CreditcardLastFour}";
            }
            else // big time
            {
                details += $"Paid with {Math.Ceiling(_customerService.SelectedCustomer.Orders[OrderIndex].Total)} rewards points";
            }
            PaymentDetailsLabel.Text = details;

            _customerService.Customers.Add(customer);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //useless
        }

        private void CostDetailsLabel_Click(object sender, EventArgs e)
        {
            //garbage go away
        }
    }
}