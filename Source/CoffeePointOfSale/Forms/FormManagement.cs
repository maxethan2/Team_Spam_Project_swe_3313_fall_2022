using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Forms.Base;
using CoffeePointOfSale.Services.CsvExtract;
using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.FormFactory;
using CsvHelper;
using System.Diagnostics;
using System.Globalization;

namespace CoffeePointOfSale.Forms;

public partial class FormManagement : FormNoCloseBase
{
    private readonly ICustomerService _customerService;
    private IAppSettings _appSettings;

    public FormManagement(IAppSettings appSettings, ICustomerService customerService) : base(appSettings)
    {
        _customerService = customerService;
        _appSettings = appSettings;
        InitializeComponent();
    }

    private void OnClickBtnClose(object sender, EventArgs e)
    {
        Close(); //closes this form
        FormFactory.Get<FormMain>().Show(); //re-opens the main form
    }

    /// <summary>
    /// Remove this from your project... here to show you how to get the customer list
    /// </summary>
    private void DemonstrateGettingCustomerList()
    {
        var customerList = _customerService.Customers.List;


        for (var customerIdx = 0; customerIdx < customerList.Count; customerIdx++)
        {
            var customer = customerList[customerIdx];
            txtDeleteThis.AppendText($"{customerIdx + 1}. {customer}{Environment.NewLine}");
        }

        // creates a flat list of orders and order details
        var flatList = new List<CsvExtractLine>();
        // loop through customers
        foreach (var customer in _customerService.Customers.List)
        {
            // loop through customer orders
            foreach (var order in customer.Orders)
            {
                var flatEntry = new CsvExtractLine();
                // set data from customer
                flatEntry.CustomerId = customer.CustomerId;
                flatEntry.CustomerPhoneNumber = customer.Phone;
                flatEntry.CustomerFirstName = customer.FirstName;
                flatEntry.CustomerLastName = customer.LastName;
                flatEntry.CustomerRewardsPoints = customer.RewardPoints;

                flatEntry.OrderDate = order.Date;
                flatEntry.OrderTotal = order.Total;
                flatEntry.OrderSubtotal = order.Subtotal;
                flatEntry.OrderTax = order.Tax;

                



                var details = "";
                foreach(var drink in order.OrderedItems)
                {
                    details += drink.DrinkName + ", ";

                    details += "Quantity: " + drink.Quantity + ": ";
                    foreach(var customization in drink.Customizations)
                    {
                        details += customization + ", ";
                    }
                    //make a space between multiple drinks 
                    details += "     ";
                }

                flatEntry.OrderDetail = details;

                flatList.Add(flatEntry);
            }
        }

        var csvPath = $"C:\\Users\\me03h\\Desktop\\Team_Spam_Project_swe_3313_fall_2022\\Source\\CoffeePointOfSale\\Services\\CsvExtract\\TestCsvData\\TestCsv-{DateTime.Now:yyyy-MM-dd-HH-mm-s}.csv";
        using (var writer = new StreamWriter(csvPath))
        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
            csv.WriteRecords(flatList);
        }



        //open the csv file automatically
        var dir = $"C:\\Users\\me03h\\Desktop\\Team_Spam_Project_swe_3313_fall_2022\\Source\\CoffeePointsOfSale\\Services\\CsvExtract\\TestCsvData";
        var fn = "TestCsv -{ DateTime.Now:yyyy - MM - dd - HH - mm - s}.csv";

        try
        {
            var processStartInfo = new ProcessStartInfo(csvPath);
            processStartInfo.WorkingDirectory = dir;
            processStartInfo.UseShellExecute = true;
            Process.Start(processStartInfo);

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to open: {ex.Message}");
        }





    }

    private void OnLoadFormManagement(object sender, EventArgs e)
    {
        DemonstrateGettingCustomerList();
    }

    private void CancelButton_Click(object sender, EventArgs e)
    {
        Close(); //closes this form
        FormFactory.Get<FormMain>().Show();
    }
}