﻿using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.DrinkMenu;
using CoffeePointOfSale.Services.FormFactory;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        public string sweetener = "";
        public string foam = "";
        public string iceOrTemp = "";
        public string espressoOrMatOrDecaf = ""; //this string is for either espresso, matcha, or decaffeinated

        //base price variable
        public decimal basePrice = 0;

        //subtotal

        public decimal subTotal = 0m;
        //prices for the different customizations
        public decimal sizePrice = 0m;
        public decimal creamerPrice = 0m;
        public decimal espressoOrMatOrDecafPrice = 0m;
        
        //Total Price
        public decimal totalPrice = 0m;
        public decimal tax;

        //quantity variable
        public int quantity = 1;
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
            _currentOrder.Date = DateTime.Now.ToString("yyyy - MM - dd - HH - mm - s");
            _currentOrder.CustomerId = _customerService.SelectedCustomer.CustomerId;
            
        }

        private void CheckoutButton_Click_1(object sender, EventArgs e)
        {
            _currentOrder.OrderedItems.Add(_currentOrderedItem);
            _customerService.SelectedCustomer.Orders.Add(_currentOrder);
           
            Close();
            FormFactory.Get<FormPayment>().Show();
            
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {

        }

        private void LatteButton_Click(object sender, EventArgs e) //Latte Button
        {
            AllCustomizationEnabled();
            LatteCustomizationOnly();
            ButtonColorReset();
            LatteButton.BackColor = Color.Black; LatteButton.ForeColor = Color.Snow;
            _currentOrderedItem.DrinkName = "Latte";
            basePrice = 4;
            iceOrTemp = ""; espressoOrMatOrDecaf = ""; sweetener = ""; creamer = ""; size = "";

        }

        private void CoffeeButton_Click(object sender, EventArgs e) //Coffee Button
        {
            AllCustomizationEnabled();
            CoffeeCustomizationOnly();
                ButtonColorReset();
                CoffeeButton.BackColor = Color.Black; CoffeeButton.ForeColor = Color.Snow;
            basePrice = 2.5M;
            _currentOrderedItem.DrinkName = "Coffee";
            iceOrTemp = ""; espressoOrMatOrDecaf = ""; sweetener = ""; creamer = ""; size = "";
        }

        private void IcedLatteButton_Click(object sender, EventArgs e) // Iced Latte Button
        {
            AllCustomizationEnabled();
            IcedLatteCustomizationOnly();
                ButtonColorReset();
                IcedLatteButton.BackColor = Color.Black; IcedLatteButton.ForeColor = Color.Snow;
            basePrice = 5.25M;
            _currentOrderedItem.DrinkName = "Iced Latte";
            iceOrTemp = ""; espressoOrMatOrDecaf = ""; sweetener = ""; creamer = ""; size = "";
        }

        private void MatchaButton_Click(object sender, EventArgs e) // Iced Matcha green Tea Latte Button
        {
            AllCustomizationEnabled();
            MatchaCustomizationOnly();
                ButtonColorReset();
                MatchaButton.BackColor = Color.Black; MatchaButton.ForeColor = Color.Snow;
            iceOrTemp = ""; espressoOrMatOrDecaf = ""; sweetener = ""; creamer = ""; size = "";
            basePrice = 4;
            _currentOrderedItem.DrinkName = "Matcha";
        }

        private void WaterButton_Click(object sender, EventArgs e) // Iced Water Button
        {
            AllCustomizationEnabled();
            AllCustomizationDisabled();
                ButtonColorReset();
                WaterButton.BackColor = Color.Black; WaterButton.ForeColor = Color.Snow;
            iceOrTemp = ""; espressoOrMatOrDecaf = ""; sweetener = ""; creamer = ""; size = "";
            basePrice = 0;
            _currentOrderedItem.DrinkName = "Water";
        }

        private void EspressoButton_Click(object sender, EventArgs e) // Espresso Button
        {
            AllCustomizationEnabled();
            EspressoCustomizationOnly();
                ButtonColorReset();
                EspressoButton.BackColor = Color.Black; EspressoButton.ForeColor = Color.Snow;
            iceOrTemp = ""; espressoOrMatOrDecaf = ""; sweetener = ""; creamer = ""; size = "";
            basePrice = 2.5M;

            _currentOrderedItem.DrinkName = "Espresso";
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
                sweetener = "Sweet'N Low";
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
            _currentOrderedItem.Customizations.Add(sweetener);
            _currentOrderedItem.Customizations.Add(creamer);
            _currentOrderedItem.Customizations.Add(size);
            _currentOrder.OrderedItems.Add(_currentOrderedItem);
            OrderedItemDisplayGrid.Rows.Add(_currentOrderedItem.DrinkName);


            if (!iceOrTemp.Equals(""))
                OrderedItemDisplayGrid.Rows.Add("      " + iceOrTemp);

            if (!espressoOrMatOrDecaf.Equals(""))
                OrderedItemDisplayGrid.Rows.Add("      " + espressoOrMatOrDecaf);

            if (!sweetener.Equals(""))
                OrderedItemDisplayGrid.Rows.Add("      " + sweetener);

            if (!creamer.Equals(""))
                OrderedItemDisplayGrid.Rows.Add("      " + creamer);

            if (!size.Equals(""))
                OrderedItemDisplayGrid.Rows.Add("      " + size);
            CalculateCostsUpdateOrder();
            UpdateLabels();

           
         
            iceOrTemp = ""; espressoOrMatOrDecaf = ""; sweetener = ""; creamer = ""; size = "";
        }
        private void CalculateCostsUpdateOrder()
        {
            //calculate
            subTotal += basePrice + creamerPrice + sizePrice + espressoOrMatOrDecafPrice;
            tax = subTotal * _appSettings.Tax.Rate;
            totalPrice = subTotal + tax;

            //order changes
            _currentOrder.Subtotal += subTotal;
            _currentOrder.Total += totalPrice; 
            _currentOrder.Tax = tax;
            _currentOrderedItem.Customizations.Add(foam + sweetener + size + espressoOrMatOrDecaf);
        }
        private void UpdateLabels()
        {
            TaxLabel.Text = "Tax: " + tax.ToString("C2", CultureInfo.CurrentCulture);
            TotalLabel.Text = "Total: " + totalPrice.ToString("C2", CultureInfo.CurrentCulture);
            SubTotalLabel.Text = "Subtotal: " + subTotal.ToString("C2", CultureInfo.CurrentCulture);
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
                sweetener = "Sugar";
            }
        }

        private void SteviaButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SteviaButton.Checked == true)
            {
                sweetener = "Stevia";
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
        public void ButtonColorReset()
        {
            LatteButton.BackColor = Color.FromArgb(71, 82, 94); LatteButton.ForeColor = Color.Snow;
            CoffeeButton.BackColor = Color.FromArgb(71, 82, 94); LatteButton.ForeColor = Color.Snow;
            EspressoButton.BackColor = Color.FromArgb(71, 82, 94); LatteButton.ForeColor = Color.Snow;
            MatchaButton.BackColor = Color.FromArgb(71, 82, 94); LatteButton.ForeColor = Color.Snow;
            WaterButton.BackColor = Color.FromArgb(71, 82, 94); LatteButton.ForeColor = Color.Snow;
            IcedLatteButton.BackColor = Color.FromArgb(71, 82, 94); LatteButton.ForeColor = Color.Snow;
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

        private void SubTotalLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

