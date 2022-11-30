using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Services.CsvExtract;
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
            CustomerNameLabel.Text = "Order Placed by " + _customerService.Customers.List[selectedCustomer].FirstName + " " + _customerService.Customers.List[selectedCustomer].LastName;
            printOrder();
            printOrderTotal();
            printPaymentDetails();
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

        }
        /*
        * 
        */
        private void printOrder()
        {
            var customer = _customerService.Customers.List[selectedCustomer];

            var OrderIndex = customer.Orders.Count;
            //var Order = customer.Orders[OrderIndex - 1];
            var Order = customer.Orders[0];
            var OrderList = Order.OrderedItems;
            var OrderedItems = "";
            // drink in OrderList
            foreach (var Drink in OrderList)
            {
                OrderedItems += Drink.DrinkName + " " + Drink.Quantity + ": ";
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
            var customer = _customerService.Customers.List[selectedCustomer];

            var OrderIndex = customer.Orders.Count;
            //var Order = customer.Orders[OrderIndex - 1];
            var Order = customer.Orders[0];

            var details = $"Total: {Order.Total}\nSubTotal: {Order.Subtotal}\nTax: {Order.Tax}";

            CostDetailsLabel.Text = details;
        }

        private void printPaymentDetails()
        {
            var customer = _customerService.Customers.List[selectedCustomer];

            var OrderIndex = customer.Orders.Count;
            //var Order = customer.Orders[OrderIndex - 1];
            var Order = customer.Orders[0];

            var details = "";
            
            if (Order.PaymentMethod.Equals("Credit"))
            {
                details += "Payed in credit card ending in ******";
            }
            else
            {
                details += "Payed with x rewards points";
            }
            PaymentDetailsLabel.Text = details;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CostDetailsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
