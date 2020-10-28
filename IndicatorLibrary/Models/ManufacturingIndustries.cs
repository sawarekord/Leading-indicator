using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndicatorLibrary.Models
{
    /// <summary>
    /// List of all Manufacturing Industries
    /// </summary>
    public class ManufacturingIndustries
    {
        public float IndexValue { get; set; }

        public float ApparelLeatherAlliedProducts { get; set; }

        public float ChemicalProducts { get; set; }

        public float ComputerElectronicProducts { get; set; }

        public float ElectricalEqAppliancesComponents { get; set; }

        public float FurnitureRelatedProducts { get; set; }

        public float FabricatedMetalProducts { get; set; }

        public float FoodBeverageTobaccoProducts { get; set; }

        public float NonmetallicMineralProducts { get; set; }

        public float MiscellaneousManufacturing { get; set; }

        public float Machinery { get; set; }

        public float PrintingRelatedSupportActivities { get; set; }

        public float PetroleumCoalProducts { get; set; }

        public float PrimaryMetals { get; set; }

        public float PaperProducts { get; set; }

        public float PlasticsRubberProducts { get; set; }

        public float TextileMills { get; set; }

        public float TransportationEquipment { get; set; }

        public float WoodProducts { get; set; }

        public static List<string> GetAllIndustries()
        {
            List<string> industries = new List<string>();

            industries.Add("Apparel");
            industries.Add("Chemical");
            industries.Add("Computer");
            industries.Add("Appliances");
            industries.Add("Furniture");
            industries.Add("Fabricated");
            industries.Add("Food");
            industries.Add("Nonmetallic");
            industries.Add("Miscellaneous");
            industries.Add("Machinery");
            industries.Add("Printing");
            industries.Add("Petroleum");
            industries.Add("Primary");
            industries.Add("Paper");
            industries.Add("Plastics");
            industries.Add("Textile");
            industries.Add("Transportation");
            industries.Add("Wood");

            return industries;
        }
    }
}
