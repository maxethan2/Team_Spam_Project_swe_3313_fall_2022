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
     * 
     * 
     *                                     WELCOME TO THE JUNGLE
     * 
     * 
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
        public string size = "";
        public string creamer = "";
        public string sweetner = "";
        public string foam = "";
        public string iceOrTemp = "";
        public string espressoOrMatOrDecaf = ""; //this string is for either espresso, matcha, or decaffeinated

        //base price variable
        public decimal basePrice = 0;

        //subtotal
        public decimal subTotal = 0;

        //prices for the different customizations
        public decimal sizePrice = 0;
        public decimal creamerPrice = 0;
        public decimal espressoOrMatOrDecafPrice = 0;

        //Total Price
        public decimal totalPrice = 0;

      

        public FormOrder(IAppSettings appSettings, ICustomerService customerService, IDrinkMenuService drinkMenuService) : base(appSettings)
        {
            _customerService = customerService;
            _appSettings = appSettings;
            _drinkMenuService = drinkMenuService;
            InitializeComponent();
           
        }

        private Order _currentOrder = new Order();  //this is a to track ordered items
        private DrinkMenu _currentDrink = new DrinkMenu(); //this is for current drink and store customizations
        private OrderedItem _currentOrderedItem = new OrderedItem();


        private void CancelButton_Click(object sender, EventArgs e)
        {
            _customerService.SelectedCustomer = _customerService.Customers[Customer.AnonymousCustomerId];  // sets the customer back to anonymous
            Close(); //closes this form
            FormFactory.Get<FormMain>().Show();

        }

        private void CheckoutButton_Click_1(object sender, EventArgs e)
        {
            Close();
            FormFactory.Get<FormPayment>().Show();
            _customerService.SelectedCustomer.Orders.Add(_currentOrder);
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {

        }

        private void LatteButton_Click(object sender, EventArgs e) //Latte Button
        {
            AllCustomizationEnabled();
            LatteCustomizationOnly();
            _currentOrderedItem.DrinkName = "Latte";
            basePrice = 4;
            iceOrTemp = ""; espressoOrMatOrDecaf = ""; sweetner = ""; creamer = ""; size = "";

        }

        private void CoffeeButton_Click(object sender, EventArgs e) //Coffee Button
        {
            AllCustomizationEnabled();
            CoffeeCustomizationOnly();
            basePrice = 2.5M;
            _currentOrderedItem.DrinkName = "Coffee";
            iceOrTemp = ""; espressoOrMatOrDecaf = ""; sweetner = ""; creamer = ""; size = "";
        }

        private void IcedLatteButton_Click(object sender, EventArgs e) // Iced Latte Button
        {
            AllCustomizationEnabled();
            IcedLatteCustomizationOnly();
            basePrice = 5.25M;
            _currentOrderedItem.DrinkName = "Iced Latte";
            iceOrTemp = ""; espressoOrMatOrDecaf = ""; sweetner = ""; creamer = ""; size = "";
        }

        private void MatchaButton_Click(object sender, EventArgs e) // Iced Matcha green Tea Latte Button
        {
            AllCustomizationEnabled();
            MatchaCustomizationOnly();
            iceOrTemp = ""; espressoOrMatOrDecaf = ""; sweetner = ""; creamer = ""; size = "";
            basePrice = 4;
            _currentOrderedItem.DrinkName = "Matcha";
        }

        private void WaterButton_Click(object sender, EventArgs e) // Iced Water Button
        {
            AllCustomizationEnabled();
            AllCustomizationDisabled();
            iceOrTemp = ""; espressoOrMatOrDecaf = ""; sweetner = ""; creamer = ""; size = "";
            basePrice = 0;
            _currentOrderedItem.DrinkName = "Water";
        }

        private void EspressoButton_Click(object sender, EventArgs e) // Espresso Button
        {
            AllCustomizationEnabled();
            EspressoCustomizationOnly();
            iceOrTemp = ""; espressoOrMatOrDecaf = ""; sweetner = ""; creamer = ""; size = "";
            basePrice = 2.5M;

            _currentOrderedItem.DrinkName = "Espresso";
        }

        private void label1_Click(object sender, EventArgs e)
        {

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


        //----------------------------ORDER GRID--------------------------------------------- 
        private void OrderDisplayGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RoomCreamButton_CheckedChanged(object sender, EventArgs e)
        {
            if (RoomCreamButton.Checked == true)
            {
                creamer = "Room For Cream";
            }
        }

        private void ExtraEspresso_CheckedChanged(object sender, EventArgs e)
        {
            if (ExtraEspresso.Checked == true)
            {
                espressoOrMatOrDecaf = "1 Extra Shot of Espresso";
                espressoOrMatOrDecafPrice = 1.25m;
            }
        }

        private void ExtraMatchaButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ExtraMatchaButton.Checked == true)
            {
                espressoOrMatOrDecaf = "1 Extra Shot of Matcha";
                espressoOrMatOrDecafPrice = 2.5m;
            }
        }

        private void DecaffeinatedButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DecaffeinatedButton.Checked == true)
            {
                espressoOrMatOrDecaf = "Decaffeinated";
                espressoOrMatOrDecafPrice = 0;
            }
        }

        private void SweetNLowButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SweetNLowButton.Checked == true)
            {
                sweetner = "Sweet'N Low";
            }
        }

        private void NonFatMilkButton_CheckedChanged(object sender, EventArgs e)
        {
            if (NonFatMilkButton.Checked == true)
            {
                creamer = "Non-Fat Milk";
                creamerPrice = 0;
            }
        }

        private void AddDrinkButton_Click_1(object sender, EventArgs e)
        {
            AllCustomizationEnabled();
            DeselectAllButtons();
            _currentOrderedItem.Customizations.Add(iceOrTemp);
            _currentOrderedItem.Customizations.Add(espressoOrMatOrDecaf);
            _currentOrderedItem.Customizations.Add(sweetner);
            _currentOrderedItem.Customizations.Add(creamer);
            _currentOrderedItem.Customizations.Add(size);
            _currentOrder.OrderedItems.Add(_currentOrderedItem);
            OrderedItemDisplayGrid.Rows.Add(_currentOrderedItem.DrinkName);


            if (!iceOrTemp.Equals(""))
                OrderedItemDisplayGrid.Rows.Add("      " + iceOrTemp);

            if (!espressoOrMatOrDecaf.Equals(" "))
                OrderedItemDisplayGrid.Rows.Add("      " + espressoOrMatOrDecaf);

            if (!sweetner.Equals(""))
                OrderedItemDisplayGrid.Rows.Add("      " + sweetner);

            if (!creamer.Equals(""))
                OrderedItemDisplayGrid.Rows.Add("      " + creamer);

            if (!size.Equals(""))
                OrderedItemDisplayGrid.Rows.Add("      " + size);
            //reseting names
            iceOrTemp = ""; espressoOrMatOrDecaf = ""; sweetner = ""; creamer = ""; size = "";
        }


        private void SizeSmallButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SizeSmallButton.Checked == true)
            {
                size = "Small";
                sizePrice = -1;
            }
        }

        private void SizeLargeButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SizeLargeButton.Checked == true)
            {
                size = "Large";
                sizePrice = 1;
            }
        }

        private void SizeMegaButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SizeMegaButton.Checked == true)
            {
                size = "Mega";
                sizePrice = 2;
            }
        }

        private void WholeMilkButton_CheckedChanged(object sender, EventArgs e)
        {
            if (WholeMilkButton.Checked == true)
            {
                creamer = "Whole Milk";
                creamerPrice = 0;
            }
        }

        private void OatMilkButton_CheckedChanged(object sender, EventArgs e)
        {
            if (OatMilkButton.Checked == true)
            {
                creamer = "Oat Milk";
                creamerPrice = 1.5m;
            }
        }

        private void AlmondMilkButton_CheckedChanged(object sender, EventArgs e)
        {
            if (AlmondMilkButton.Checked == true)
            {
                creamer = "Almond Milk";
                creamerPrice = 1.5m;
            }
        }

        private void SoyMilkButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SoyMilkButton.Checked == true)
            {
                creamer = "Soy Milk";
                creamerPrice = 1.5m;
            }
        }

        private void SugarButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SugarButton.Checked == true)
            {
                sweetner = "Sugar";
            }
        }

        private void SteviaButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SteviaButton.Checked == true)
            {
                sweetner = "Stevia";
            }
        }

        private void ExtraIceButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ExtraIceButton.Checked == true)
            {
                iceOrTemp = "Extra Ice";
            }
        }

        private void NoIceButton_CheckedChanged(object sender, EventArgs e)
        {
            if (NoIceButton.Checked == true)
            {
                iceOrTemp = "No Ice";
            }
        }

        private void LessHotButton_CheckedChanged(object sender, EventArgs e)
        {
            if (LessHotButton.Checked == true)
            {
                iceOrTemp = "Less hot";
            }
        }

        private void VeryHotButton_CheckedChanged(object sender, EventArgs e)
        {
            if (VeryHotButton.Checked == true)
            {
                iceOrTemp = "Very Hot";
            }
        }

        private void LotsFoamButton_CheckedChanged(object sender, EventArgs e)
        {
            if (LotsFoamButton.Enabled == true)
            {
                foam = "Lots of Foam";
            }
        }

        private void NoFoamButton_CheckedChanged(object sender, EventArgs e)
        {
            if (NoFoamButton.Enabled == true)
            {
                foam = "No Foam";
            }
        }
        private void DeselectAllButtons()
        {
            AlmondMilkButton.Checked = false;
            SizeLargeButton.Checked = false;
            SizeMegaButton.Checked = false;
            WholeMilkButton.Checked = false;
            OatMilkButton.Checked = false;
            SoyMilkButton.Checked = false;
            RoomCreamButton.Checked = false;
            DecaffeinatedButton.Checked = false;
            ExtraMatchaButton.Checked = false;
            ExtraEspresso.Checked = false;
            SizeSmallButton.Checked = false;
            SweetNLowButton.Checked = false;
            SteviaButton.Checked = false;
            SugarButton.Checked = false;
            LessHotButton.Checked = false;
            NoIceButton.Checked = false;
            ExtraIceButton.Checked = false;
            VeryHotButton.Checked = false;
            NonFatMilkButton.Checked = false;
            NoFoamButton.Checked= false;
        }
        private void CoffeeCustomizationOnly()
        {
            DecaffeinatedButton.Enabled = false;
            ExtraMatchaButton.Enabled = false;
            NoIceButton.Enabled = false;
            ExtraIceButton.Enabled = false;
            NoFoamButton.Enabled = false;
            LotsFoamButton.Enabled = false;
        }
        private void AllCustomizationEnabled()
        {
            AlmondMilkButton.Enabled = true;
            SizeLargeButton.Enabled = true;
            SizeMegaButton.Enabled = true;
            WholeMilkButton.Enabled = true;
            OatMilkButton.Enabled = true;
            SoyMilkButton.Enabled = true;
            RoomCreamButton.Enabled = true;
            DecaffeinatedButton.Enabled = true;
            ExtraMatchaButton.Enabled = true;
            ExtraEspresso.Enabled = true;
            SizeSmallButton.Enabled = true;
            SweetNLowButton.Enabled = true;
            SteviaButton.Enabled = true;
            SugarButton.Enabled = true;
            LessHotButton.Enabled = true;
            NoIceButton.Enabled = true;
            ExtraIceButton.Enabled = true;
            VeryHotButton.Enabled = true;
            NonFatMilkButton.Enabled = true;
        }
        private void AllCustomizationDisabled()
        {
            AlmondMilkButton.Enabled = false;
            SizeLargeButton.Enabled = false;
            SizeMegaButton.Enabled = false;
            WholeMilkButton.Enabled = false;
            OatMilkButton.Enabled = false;
            SoyMilkButton.Enabled = false;
            RoomCreamButton.Enabled = false;
            DecaffeinatedButton.Enabled = false;
            ExtraMatchaButton.Enabled = false;
            ExtraEspresso.Enabled = false;
            SizeSmallButton.Enabled = false;
            SweetNLowButton.Enabled = false;
            SteviaButton.Enabled = false;
            SugarButton.Enabled = false;
            LessHotButton.Enabled = false;
            NoIceButton.Enabled = false;
            ExtraIceButton.Enabled = false;
            VeryHotButton.Enabled = false;
            NonFatMilkButton.Enabled = false;
            NoFoamButton.Enabled = false;
            LotsFoamButton.Enabled = false;
        }
        private void LatteCustomizationOnly()
        {
            RoomCreamButton.Enabled = false;
            ExtraMatchaButton.Enabled = false;
            NoIceButton.Enabled = false;
            ExtraIceButton.Enabled = false;
        }

        private void IcedLatteCustomizationOnly()
        {
            SizeMegaButton.Enabled = false;
            SizeSmallButton.Enabled = false;
            RoomCreamButton.Enabled = false;
            LessHotButton.Enabled = false;
            VeryHotButton.Enabled = false;
            NoFoamButton.Enabled = false;
            LotsFoamButton.Enabled = false;
        }
        private void MatchaCustomizationOnly()
        {
            SizeMegaButton.Enabled = false;
            SizeSmallButton.Enabled = false;
            RoomCreamButton.Enabled = false;
            LessHotButton.Enabled = false;
            VeryHotButton.Enabled = false;
            ExtraEspresso.Enabled = false;
            DecaffeinatedButton.Enabled = false;
            NoFoamButton.Enabled = false;
            LotsFoamButton.Enabled = false;
        }
        private void EspressoCustomizationOnly()
        {
            AlmondMilkButton.Enabled = false;
            SizeLargeButton.Enabled = false;
            SizeMegaButton.Enabled = false;
            WholeMilkButton.Enabled = false;
            OatMilkButton.Enabled = false;
            SoyMilkButton.Enabled = false;
            RoomCreamButton.Enabled = false;
            DecaffeinatedButton.Enabled = false;
            ExtraMatchaButton.Enabled = false;
            SizeSmallButton.Enabled = false;
            SweetNLowButton.Enabled = false;
            SteviaButton.Enabled = false;
            SugarButton.Enabled = false;
            LessHotButton.Enabled = false;
            NoIceButton.Enabled = false;
            ExtraIceButton.Enabled = false;
            VeryHotButton.Enabled = false;
            NonFatMilkButton.Enabled = false;
            NoFoamButton.Enabled = false;
            LotsFoamButton.Enabled = false;
        }

    }
}

