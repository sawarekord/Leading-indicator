using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndicatorLibrary.Models
{
    public class PmiModel
    {
        /// <summary>
        /// Main PMI Manufacturing Index.
        /// </summary>
        public string Date { get; set; }

        public ManufacturingIndustries ManufacturingIndustries { get; set; }

        public ManufacturingIndustries NewOrders { get; set; }

        public ManufacturingIndustries Production { get; set; }

        public ManufacturingIndustries Employment { get; set; }

        public ManufacturingIndustries SupplierDeliveries { get; set; }

        public ManufacturingIndustries Inventories { get; set; }

        public ManufacturingIndustries CustomersInventories { get; set; }

        public ManufacturingIndustries Prices { get; set; }

        public ManufacturingIndustries BacklogOfOrders { get; set; }

        public ManufacturingIndustries NewExportOrders { get; set; }

        public ManufacturingIndustries Imports { get; set; }
    }
}
