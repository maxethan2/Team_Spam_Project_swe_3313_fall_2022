using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.DrinkMenu;
using CoffeePointOfSale.Services.FormFactory;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace CoffeePointOfSale.Forms
{
    /*
     * Current Customer is tracked through variable selectedCustomer located in FormNoCloseBase
     * this variable acts as an indexer for the customer list
     * if there is a better method to track which customer is being used feel free to change it 
     */
    public partial class FormOrder : FormNoCloseBase
    {
        public string OrderedItems;
        public decimal OrderTotal;
        public static int index;
        bool isCoffee;
        private readonly ICustomerService _customerService;
        private readonly IDrinkMenuService _drinkMenuService;
        private IAppSettings _appSettings;
        public FormOrder(IAppSettings appSettings, ICustomerService customerService, IDrinkMenuService drinkMenuService) : base(appSettings)
        {
            _customerService = customerService;
            _appSettings = appSettings;
            _drinkMenuService = drinkMenuService;
            InitializeComponent();
            AddDrinkButton.Enabled = false;
        }
      
        private Order _currentOrder = new Order();  //this is a to track ordered items
        private DrinkMenu _currentDrink = new DrinkMenu(); //this is for current drink and store customizations
   

        private void button1_Click(object sender, EventArgs e)
        {
            _customerService.SelectedCustomer = _customerService.Customers[Customer.AnonymousCustomerId];  // sets the customer back to anonymous
            Close(); //closes this form
            FormFactory.Get<FormMain>().Show(); 
        }

        private void CheckoutButton_Click_1(object sender, EventArgs e)
        {
            Close();
            FormFactory.Get<FormPayment>().Show();
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {

        }

        private void LatteButton_Click(object sender, EventArgs e) //Latte Button
        {
            //Disables all button so user cannot constantly add customizations to list
            LatteButton.Enabled= false;
            IcedLatteButton.Enabled= false;
            MatchaButton.Enabled= false;
            CoffeeButton.Enabled= false;
            WaterButton.Enabled= false;
            EspressoButton.Enabled= false;
            AddDrinkButton.Enabled= true;

        }

        private void CoffeeButton_Click(object sender, EventArgs e) //Coffee Button
        {
            isCoffee = true;


            //Disables all button so user cannot constantly add customizations to list
            LatteButton.Enabled = false;
            IcedLatteButton.Enabled = false;
            MatchaButton.Enabled = false;
            CoffeeButton.Enabled = false;
            WaterButton.Enabled = false;
            EspressoButton.Enabled = false;
            AddDrinkButton.Enabled = true;
        }

        private void IcedLatteButton_Click(object sender, EventArgs e) // Iced Latte Button
        {


            //Disables all button so user cannot constantly add customizations to list
            LatteButton.Enabled = false;
            IcedLatteButton.Enabled = false;
            MatchaButton.Enabled = false;
            CoffeeButton.Enabled = false;
            WaterButton.Enabled = false;
            EspressoButton.Enabled = false;
            AddDrinkButton.Enabled = true;

        }

        private void MatchaButton_Click(object sender, EventArgs e) // Iced Matcha green Tea Latte Button
        {


            //Disables all button so user cannot constantly add customizations to list
            LatteButton.Enabled = false;
            IcedLatteButton.Enabled = false;
            MatchaButton.Enabled = false;
            CoffeeButton.Enabled = false;
            WaterButton.Enabled = false;
            EspressoButton.Enabled = false;
            AddDrinkButton.Enabled = true;
        }

        private void WaterButton_Click(object sender, EventArgs e) // Iced Water Button
        {
            //Disables all button so user cannot constantly add customizations to list
            LatteButton.Enabled = false;
            IcedLatteButton.Enabled = false;
            MatchaButton.Enabled = false;
            CoffeeButton.Enabled = false;
            WaterButton.Enabled = false;
            EspressoButton.Enabled = false;
            AddDrinkButton.Enabled = true;
        }

        private void EspressoButton_Click(object sender, EventArgs e) // Espresso Button
        {

            //Disables all button so user cannot constantly add customizations to list
            LatteButton.Enabled = false;
            IcedLatteButton.Enabled = false;
            MatchaButton.Enabled = false;
            CoffeeButton.Enabled = false;
            WaterButton.Enabled = false;
            EspressoButton.Enabled = false;
            AddDrinkButton.Enabled = true;
        }

        private void AddDrinkButton_Click(object sender, EventArgs e)
        {
            LatteButton.Enabled = true;
            IcedLatteButton.Enabled = true;
            MatchaButton.Enabled = true;
            CoffeeButton.Enabled = true;
            WaterButton.Enabled = true;
            EspressoButton.Enabled = true;
            AddDrinkButton.Enabled = false;
            isCoffee = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TestLabel_Click(object sender, EventArgs e) //click this label to see current customer
        {
            TestLabel.Text = _customerService.SelectedCustomer.FirstName;
        }
    }
}
