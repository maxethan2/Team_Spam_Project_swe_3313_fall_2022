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
     * Current Customer is tracked through _customerService.SelectedCustomer
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
        public string size;
        public string creamer;
        public string sweetner;
        public string foam;
        public string iceOrTemp;
        public string espressoOrMatOrDecaf; //this string is for either espresso, matcha, or decaffeinated


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

            //Disables all customizations that do not apply to drink
            radioButton8.Enabled = false;
            radioButton10.Enabled = false;
            radioButton17.Enabled = false;
            radioButton18.Enabled = false;

            //Disables all button so user cannot constantly add customizations to list
            LatteButton.Enabled= false;
            IcedLatteButton.Enabled= false;
            MatchaButton.Enabled= false;
            CoffeeButton.Enabled= false;
            WaterButton.Enabled= false;
            EspressoButton.Enabled= false;
            AddDrinkButton.Enabled= true;

            //Adds the base description to the different variables for the customizations
            size = "Medium";
            iceOrTemp = "Hot";
            creamer = "2% Milk";
            espressoOrMatOrDecaf = "2 shots of espresso";
            sweetner = "Unsweetened";

        }

        private void CoffeeButton_Click(object sender, EventArgs e) //Coffee Button
        {

            //Disables all customizations that do not apply to drink
            radioButton9.Enabled = false;
            radioButton10.Enabled = false;
            radioButton17.Enabled = false;
            radioButton18.Enabled = false;

            //Disables all button so user cannot constantly add customizations to list
            LatteButton.Enabled = false;
            IcedLatteButton.Enabled = false;
            MatchaButton.Enabled = false;
            CoffeeButton.Enabled = false;
            WaterButton.Enabled = false;
            EspressoButton.Enabled = false;
            AddDrinkButton.Enabled = true;

            //Adds the base description to the different variables for the customizations
            size = "Medium";
            iceOrTemp = "Hot";
            sweetner = "Unsweetened";
        }

        private void IcedLatteButton_Click(object sender, EventArgs e) // Iced Latte Button
        {
            //Disables all customizations that do not apply to drink
            radioButton3.Enabled = false;
            radioButton12.Enabled = false;
            radioButton8.Enabled= false;
            radioButton16.Enabled= false;
            radioButton19.Enabled= false;

            //Disables all button so user cannot constantly add customizations to list
            LatteButton.Enabled = false;
            IcedLatteButton.Enabled = false;
            MatchaButton.Enabled = false;
            CoffeeButton.Enabled = false;
            WaterButton.Enabled = false;
            EspressoButton.Enabled = false;
            AddDrinkButton.Enabled = true;

            //Adds the base description to the different variables for the customizations
            size = "Medium";
            iceOrTemp = "Cold";
            creamer = "2% Milk";
            espressoOrMatOrDecaf = "2 Shots";
            sweetner = "Unsweetened";


        }

        private void MatchaButton_Click(object sender, EventArgs e) // Iced Matcha green Tea Latte Button
        {
            //Disables all customizations that do not apply to drink
            radioButton3.Enabled= false;
            radioButton12.Enabled= false;
            radioButton8.Enabled= false; 
            radioButton16.Enabled= false;
            radioButton19.Enabled= false;
            radioButton11.Enabled= false;
            radioButton9.Enabled= false;

            //Disables all button so user cannot constantly add customizations to list
            LatteButton.Enabled = false;
            IcedLatteButton.Enabled = false;
            MatchaButton.Enabled = false;
            CoffeeButton.Enabled = false;
            WaterButton.Enabled = false;
            EspressoButton.Enabled = false;
            AddDrinkButton.Enabled = true;

            //Adds the base description to the different variables for the customizations
            size = "Medium";
            iceOrTemp = "Hot";
            creamer = "2% Milk";
            espressoOrMatOrDecaf = "2 Shots Matcha";

        }

        private void WaterButton_Click(object sender, EventArgs e) // Iced Water Button
        {
            //Disables all customizations that do not apply to drink
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton5.Enabled = false;
            radioButton6.Enabled = false;
            radioButton7.Enabled = false;
            radioButton8.Enabled = false;
            radioButton9.Enabled = false;
            radioButton10.Enabled = false;
            radioButton11.Enabled = false;
            radioButton12.Enabled = false;
            radioButton13.Enabled = false;
            radioButton14.Enabled = false;
            radioButton15.Enabled = false;
            radioButton16.Enabled = false;
            radioButton17.Enabled = false;
            radioButton18.Enabled = false;
            radioButton19.Enabled = false;
            radioButton20.Enabled = false;

            //Disables all button so user cannot constantly add customizations to list
            LatteButton.Enabled = false;
            IcedLatteButton.Enabled = false;
            MatchaButton.Enabled = false;
            CoffeeButton.Enabled = false;
            WaterButton.Enabled = false;
            EspressoButton.Enabled = false;
            AddDrinkButton.Enabled = true;

            //Iced water does not have any customizations

        }

        private void EspressoButton_Click(object sender, EventArgs e) // Espresso Button
        {
            //Disables all customizations that do not apply to drink
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton5.Enabled = false;
            radioButton6.Enabled = false;
            radioButton7.Enabled = false;
            radioButton8.Enabled = false;
            radioButton9.Enabled = false;
            radioButton10.Enabled = false;
            radioButton12.Enabled = false;
            radioButton13.Enabled = false;
            radioButton14.Enabled = false;
            radioButton15.Enabled = false;
            radioButton16.Enabled = false;
            radioButton17.Enabled = false;
            radioButton18.Enabled = false;
            radioButton19.Enabled = false;
            radioButton20.Enabled = false;

            //Disables all button so user cannot constantly add customizations to list
            LatteButton.Enabled = false;
            IcedLatteButton.Enabled = false;
            MatchaButton.Enabled = false;
            CoffeeButton.Enabled = false;
            WaterButton.Enabled = false;
            EspressoButton.Enabled = false;
            AddDrinkButton.Enabled = true;

            //Adds the base description to the different variables for the customizations
            iceOrTemp = "Hot";
            sweetner = "Unsweetened";
            espressoOrMatOrDecaf = "1 Shot Espresso";
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TestLabel_Click(object sender, EventArgs e) //click this label to see current customer
        {
            TestLabel.Text = _customerService.SelectedCustomer.FirstName;
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Enables all radio buttons again once drink has been added to order
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton5.Enabled = true;
            radioButton6.Enabled = true;
            radioButton7.Enabled = true;
            radioButton8.Enabled = true;
            radioButton9.Enabled = true;
            radioButton10.Enabled = true;
            radioButton11.Enabled = true;
            radioButton12.Enabled = true;
            radioButton13.Enabled = true;
            radioButton14.Enabled = true;
            radioButton15.Enabled = true;
            radioButton16.Enabled = true;
            radioButton17.Enabled = true;
            radioButton18.Enabled = true;
            radioButton19.Enabled = true;
            radioButton20.Enabled = true;

            //Deselects all radio buttons
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
            radioButton14.Checked = false;
            radioButton15.Checked = false;
            radioButton16.Checked = false;
            radioButton17.Checked = false;
            radioButton18.Checked = false;
            radioButton19.Checked = false;
            radioButton20.Checked = false;



            //Enables all of the drink options once customization is done
            LatteButton.Enabled = true;
            IcedLatteButton.Enabled = true;
            MatchaButton.Enabled = true;
            CoffeeButton.Enabled = true;
            WaterButton.Enabled = true;
            EspressoButton.Enabled = true;
        }
    }
}
