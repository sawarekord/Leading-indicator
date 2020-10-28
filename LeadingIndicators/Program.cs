using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using IndicatorLibrary;
using IndicatorLibrary.Models;
using IndicatorLibrary.Processors;

namespace LeadingIndicators
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            ////string ism = WebProcessor.GetHttpSourceCode("https://www.prnewswire.com/news-releases/pmi-at-495-february-manufacturing-ism-report-on-business-new-orders-and-production-growing-employment-and-inventories-contracting-supplier-deliveries-faster-300227266.html");
            //string ism = WebProcessor.GetHttpSourceCode("https://www.prnewswire.com/news-releases/pmi-at-513-march-manufacturing-ism-report-on-business-new-orders-production-and-employment-growing-inventories-contracting-supplier-deliveries-faster-200870461.html");
            ////string ism = WebProcessor.GetHttpSourceCode("https://www.instituteforsupplymanagement.org/ismreport/mfgrob.cfm?SSO=1");
            ////string ism = WebProcessor.GetHttpSourceCode("https://www.businesswire.com/news/home/20080201005042/en/January-Manufacturing-ISM-Report-Business-PMI-50.7");

            //ism = WebProcessor.HtmlTagRemover(ism);
            //PmiModel pmi = new PmiModel();

            //string[] growingIndPmi = ism.GetIndustriesForPmi().GetGrowingIndustries();
            //string[] contractingIndPmi = ism.GetIndustriesForPmi().GetContractingIndustries();

            //string[] growingIndNewOrders = ism.GetIndustriesForNewOrders().GetGrowingIndustries();
            //string[] contractingIndNewOrders = ism.GetIndustriesForNewOrders().GetContractingIndustriesNewOrders();

            //string[] growingIndProduction = ism.GetIndustriesForProduction().GetGrowingIndustries();
            //string[] contractingIndProduction = ism.GetIndustriesForProduction().GetContractingIndustriesProduction();

            //string[] growingIndEmployment = ism.GetIndustriesForEmployment().GetGrowingIndustries();
            //string[] contractingIndEmployment = ism.GetIndustriesForEmployment().GetContractingIndustriesProduction();

            //pmi.ManufacturingIndustries = TextProcessor.SetDataIntoModel(contractingIndPmi, growingIndPmi);
            //pmi.NewOrders = TextProcessor.SetDataIntoModel(contractingIndNewOrders, growingIndNewOrders);
            //pmi.Production = TextProcessor.SetDataIntoModel(contractingIndProduction, growingIndProduction);
            //pmi.Employment = TextProcessor.SetDataIntoModel(contractingIndEmployment, growingIndEmployment);


            //ExcelProcessor.SavingManufacturingIndustries(pmi, 5);
        }
    }
}
