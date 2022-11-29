using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.FormFactory;

namespace CoffeePointOfSale.Forms;

public partial class FormMain : FormBase
{
   
    public FormMain(IAppSettings appSettings) : base(appSettings) 
    {
        InitializeComponent();
    }

 
    private void OnFormMainClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }

    private void buttonOrder_Click(object sender, EventArgs e)
    {
        Hide(); //closes this form
        FormFactory.Get<FormOrder>().Show(); 
    }

    private void buttonCustomerList_Click(object sender, EventArgs e)
    {
        Hide(); //closes this form
        FormFactory.Get<FormCustomerList>().Show();
    }
    private void ManagementButton_Click(object sender, EventArgs e)
    {
        Hide(); //closes this form
        FormFactory.Get<FormManagement>().Show(); 
    }
}