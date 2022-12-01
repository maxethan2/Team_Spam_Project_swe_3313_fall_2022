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

        //variables for the customizations
        public string size;
        public string creamer;
        public string sweetner;
        public string foam;
        public string iceOrTemp;
        public string espressoOrMatOrDecaf; //this string is for either espresso, matcha, or decaffeinated

        //base price variable
        public decimal basePrice;

        //prices for the different customizations
        public decimal sizePrice;
        public decimal creamerPrice;
        public decimal espressoOrMatOrDecafPrice; 

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

            //Adds the base price to the basePrice decimal for the drink
            basePrice = 4;

        }

        private void CoffeeButton_Click(object sender, EventArgs e) //Coffee Button
        {

            //Disables all customizations that do not apply to drink
            radioButton9.Enabled = false;
            radioButton10.Enabled = false;
            radioButton17.Enabled = false;
            radioButton18.Enabled = false;
            radioButton4.Enabled = false;
            radioButton21.Enabled = false;

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

            //Adds the base price to the basePrice decimal for the drink
            basePrice = 2.5M;
        }

        private void IcedLatteButton_Click(object sender, EventArgs e) // Iced Latte Button
        {
            //Disables all customizations that do not apply to drink
            radioButton3.Enabled = false;
            radioButton12.Enabled = false;
            radioButton8.Enabled= false;
            radioButton16.Enabled= false;
            radioButton19.Enabled= false;
            radioButton4.Enabled = false;
            radioButton21.Enabled = false;

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

            //Adds the base price to the basePrice decimal for the drink
            basePrice = 5.25M;
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
            radioButton4.Enabled = false;
            radioButton21.Enabled = false;

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

            //Adds the base price to the basePrice decimal for the drink
            basePrice = 4;
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
            radioButton4.Enabled = false;
            radioButton21.Enabled = false;

            //Disables all button so user cannot constantly add customizations to list
            LatteButton.Enabled = false;
            IcedLatteButton.Enabled = false;
            MatchaButton.Enabled = false;
            CoffeeButton.Enabled = false;
            WaterButton.Enabled = false;
            EspressoButton.Enabled = false;
            AddDrinkButton.Enabled = true;

            //Iced water does not have any customizations

            //Adds the base price to the basePrice decimal for the drink
            basePrice = 0;
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
            radioButton4.Enabled = false;
            radioButton21.Enabled = false;

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

            //Adds the base price to the basePrice decimal for the drink
            basePrice = 2.5M;
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
            if (radioButton8.Checked == true)
            {
                creamer = "Room For Cream";
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked == true)
            {
                espressoOrMatOrDecaf = "1 Extra Shot of Espresso";
                espressoOrMatOrDecafPrice = 1.25m;
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton10.Checked == true)
            {
                espressoOrMatOrDecaf = "1 Extra Shot of Matcha";
                espressoOrMatOrDecafPrice = 2.5m;
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton9.Checked == true)
            {
                espressoOrMatOrDecaf = "Decaffeinated";
                espressoOrMatOrDecafPrice = 0;
            }
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton13.Checked == true)
            {
                sweetner = "Sweet'N Low";
            }
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton20.Checked == true)
            {
                creamer = "Non-Fat Milk";
                creamerPrice = 0;
            }
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

        private void label1_Click_1(object sender, EventArgs e)
        {
            label1.Text = size + " " + iceOrTemp;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton12.Checked == true)
            {
                size = "Small";
                sizePrice = -1;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked == true)
            {
                size = "Large";
                sizePrice = 1;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton3.Checked == true)
            {
                size = "Mega";
                sizePrice = 2;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton5.Checked == true)
            {
                creamer = "Whole Milk";
                creamerPrice = 0;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                creamer = "Oat Milk";
                creamerPrice = 1.5m;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                creamer = "Almond Milk";
                creamerPrice = 1.5m;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                creamer = "Soy Milk";
                creamerPrice = 1.5m;
            }
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton15.Checked == true)
            {
                sweetner = "Sugar";
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton14.Checked == true)
            {
                sweetner = "Stevia";
            }
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton18.Checked == true)
            {
                iceOrTemp = "Extra Ice";
            }
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton17.Checked == true)
            {
                iceOrTemp = "No Ice";
            }
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true)
            {
                iceOrTemp = "Less hot";
            }
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton19.Checked == true)
            {
                iceOrTemp = "Very Hot";
            }
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton21.Enabled== true)
            {
                foam = "Lots of Foam";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Enabled == true)
            {
                foam = "No Foam";
            }
        }
    }
}
