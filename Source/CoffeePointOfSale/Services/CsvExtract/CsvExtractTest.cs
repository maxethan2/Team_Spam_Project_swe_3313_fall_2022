using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;
using System.Globalization;
using System.Security;
using CoffeePointOfSale.Services.Customer;
using System.Formats.Asn1;

namespace CoffeePointOfSale.Services.CsvExtract
{
    internal class CsvExtractTest
    {
        /*
        public static void Main(string[] args)
        {

            
            var csvPath = $"C:\\Users\\me03h\\Desktop\\Team_Spam_Project_swe_3313_fall_2022\\Source\\CoffeePointOfSale\\Services\\CsvExtract\\TestCsvData\\TestCsv-{DateTime.Now:yyyy-MM-dd-HH-mm-s}.csv";
            using (var streamWriter = new StreamWriter(csvPath))
            {
                using (var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture))
                {
                    var test = "test, test   test ;TEST";
                    csvWriter.WriteRecords(test);
                }
            }

        }
        */

        public static void ExtractToCsv(String test)
        {


            var csvPath = $"C:\\Users\\me03h\\Desktop\\Team_Spam_Project_swe_3313_fall_2022\\Source\\CoffeePointOfSale\\Services\\CsvExtract\\TestCsvData\\TestCsv-{DateTime.Now:yyyy-MM-dd-HH-mm-s}.csv";
            using (var streamWriter = new StreamWriter(csvPath))
            {
                using (var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture))
                {
                    csvWriter.WriteRecords(test.ToString());
                }
            }

        }


        public static void ExtractToCsv(List<string> test)
        {


            var csvPath = $"C:\\Users\\me03h\\Desktop\\Team_Spam_Project_swe_3313_fall_2022\\Source\\CoffeePointOfSale\\Services\\CsvExtract\\TestCsvData\\TestCsv-{DateTime.Now:yyyy-MM-dd-HH-mm-s}.csv";

            string printThis = "";

            foreach (string k in test){
                printThis += k;
            }

            using (var streamWriter = new StreamWriter(csvPath))
            {
                using (var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture))
                {
                    csvWriter.WriteRecords(printThis);
                }
            }

        }


    }
}
