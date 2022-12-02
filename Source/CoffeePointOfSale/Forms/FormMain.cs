using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;

namespace CoffeePointOfSale.Forms;

public partial class FormMain : FormBase
{
    ICustomerService _customerService;
    public FormMain(ICustomerService customerService, IAppSettings appSettings) : base(appSettings)
    {
        _customerService = customerService;
        InitializeComponent();
    }


    private void OnFormMainClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }

    private void buttonOrder_Click(object sender, EventArgs e)
    {
        _customerService.SelectedCustomer = _customerService.Customers[Customer.AnonymousCustomerId];
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
        Hide(); //closes this form D:
        FormFactory.Get<FormManagement>().Show(); 
    }
}