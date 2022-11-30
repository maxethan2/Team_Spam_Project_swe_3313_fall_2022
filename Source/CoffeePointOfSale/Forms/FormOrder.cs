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

namespace CoffeePointOfSale.Forms
{
    /*
     * Current Customer is tracked through variable selectedCustomer located in FormNoCloseBase
     * this variable acts as an indexer for the customer list
     * if there is a better method to track which customer is being used feel free to change it 
     */
    public partial class FormOrder : FormNoCloseBase
    {
        private readonly ICustomerService _customerService;
        private readonly IDrinkMenuService _drinkMenuService;
        private IAppSettings _appSettings;
        public FormOrder(IAppSettings appSettings, ICustomerService customerService, IDrinkMenuService drinkMenuService) : base(appSettings)
        {
            _customerService = customerService;
            _appSettings = appSettings;
            _drinkMenuService = drinkMenuService;
            InitializeComponent();
            button8.Enabled = false;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            selectedCustomer = 0; // sets the customer back to anonymous
            Close(); //closes this form
            FormFactory.Get<FormMain>().Show(); 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
            FormFactory.Get<FormPayment>().Show();
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //Latte Button
        {
            //for (var customizationIdx = 0; customizationIdx < _customerService.Customers.List.Count; customizationIdx++)
            //{
            //    var customizations = _drinkMenuService;
            //    dataGridView1.Rows.Add();
            //}
            dataGridView1.Rows.Add("Foam A | No Foam");
            dataGridView1.Rows.Add("Foam B | Lots of Foam");
            dataGridView1.Rows.Add("Size A | Small");
            dataGridView1.Rows.Add("Size B | Large");
            dataGridView1.Rows.Add("Size C | Mega");
            dataGridView1.Rows.Add("Creamer A | Room for Cream");
            dataGridView1.Rows.Add("Creamer B | Non-Fat Milk");
            dataGridView1.Rows.Add("Creamer C | Whole Milk");
            dataGridView1.Rows.Add("Creamer D | Oat Milk");
            dataGridView1.Rows.Add("Creamer E | Soy Milk");
            dataGridView1.Rows.Add("Espresso | 1 Extra Shot");
            dataGridView1.Rows.Add("Caffeine | Decaffeinated");
            dataGridView1.Rows.Add("Sweetener A | 1 Sugar");
            dataGridView1.Rows.Add("Sweetener B | 1 Stevia");
            dataGridView1.Rows.Add("Sweetener C | 1 Sweet'N Low");
            dataGridView1.Rows.Add("Temperature A | Less Hot");
            dataGridView1.Rows.Add("Temperature B | Very Hot");


            //Disables all button so user cannot constantly add customizations to list
            button2.Enabled= false;
            button3.Enabled= false;
            button4.Enabled= false;
            button5.Enabled= false;
            button6.Enabled= false;
            button7.Enabled= false;
            button8.Enabled= true;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button5_Click(object sender, EventArgs e) //Coffee Button
        {
            dataGridView1.Rows.Add("Size A | Small");
            dataGridView1.Rows.Add("Size B | Large");
            dataGridView1.Rows.Add("Size C | Mega");
            dataGridView1.Rows.Add("Creamer A | Room for Cream");
            dataGridView1.Rows.Add("Creamer B | Non-Fat Milk");
            dataGridView1.Rows.Add("Creamer C | Whole Milk");
            dataGridView1.Rows.Add("Creamer D | Oat Milk");
            dataGridView1.Rows.Add("Creamer E | Soy Milk");
            dataGridView1.Rows.Add("Espresso | 1 Extra Shot");
            dataGridView1.Rows.Add("Sweetener A | 1 Sugar");
            dataGridView1.Rows.Add("Sweetener B | 1 Stevia");
            dataGridView1.Rows.Add("Sweetener C | 1 Sweet'N Low");
            dataGridView1.Rows.Add("Temperature A | Less Hot");
            dataGridView1.Rows.Add("Temperature B | Very Hot");

            //Disables all button so user cannot constantly add customizations to list
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e) // Iced Latte Button
        {
            dataGridView1.Rows.Add("Foam A | No Foam");
            dataGridView1.Rows.Add("Foam B | Lots of Foam");
            dataGridView1.Rows.Add("Size A | Large");
            dataGridView1.Rows.Add("Creamer A | Room for Cream");
            dataGridView1.Rows.Add("Creamer B | Non-Fat Milk");
            dataGridView1.Rows.Add("Creamer C | Whole Milk");
            dataGridView1.Rows.Add("Creamer D | Oat Milk");
            dataGridView1.Rows.Add("Creamer E | Soy Milk");
            dataGridView1.Rows.Add("Espresso | 1 Extra Shot");
            dataGridView1.Rows.Add("Caffeine | Decaffeinated");
            dataGridView1.Rows.Add("Sweetener A | 1 Sugar");
            dataGridView1.Rows.Add("Sweetener B | 1 Stevia");
            dataGridView1.Rows.Add("Sweetener C | 1 Sweet'N Low");
            dataGridView1.Rows.Add("Ice A | Extra Ice");
            dataGridView1.Rows.Add("Ice B | No Ice");

            //Disables all button so user cannot constantly add customizations to list
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = true;

        }

        private void button4_Click(object sender, EventArgs e) // Iced Matcha green Tea Latte Button
        {
            dataGridView1.Rows.Add("Foam A | No Foam");
            dataGridView1.Rows.Add("Foam B | Lots of Foam");
            dataGridView1.Rows.Add("Size A | Large");
            dataGridView1.Rows.Add("Creamer A | Room for Cream");
            dataGridView1.Rows.Add("Creamer B | Non-Fat Milk");
            dataGridView1.Rows.Add("Creamer C | Whole Milk");
            dataGridView1.Rows.Add("Creamer D | Oat Milk");
            dataGridView1.Rows.Add("Creamer E | Soy Milk");
            dataGridView1.Rows.Add("Matcha | 1 Extra Dose");
            dataGridView1.Rows.Add("Sweetener A | 1 Sugar");
            dataGridView1.Rows.Add("Sweetener B | 1 Stevia");
            dataGridView1.Rows.Add("Sweetener C | 1 Sweet'N Low");
            dataGridView1.Rows.Add("Ice A | Extra Ice");
            dataGridView1.Rows.Add("Ice B | No Ice");

            //Disables all button so user cannot constantly add customizations to list
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e) // Iced Water Button
        {
            //Disables all button so user cannot constantly add customizations to list
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e) // Espresso Button
        {
            dataGridView1.Rows.Add("Espresso | 1 Extra Shot");
            //Disables all button so user cannot constantly add customizations to list
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = false;
            dataGridView1.Rows.Clear();
        }
    }
}
