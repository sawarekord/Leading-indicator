using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using IndicatorLibrary.Models;

namespace IndicatorLibrary.Processors
{
    public static class ExcelProcessor
    {
        public static void SavingManufacturingIndustries(PmiModel model, int column)
        {
            _Application excel = new Application();

            Workbook workbook = excel.Workbooks.Open(@"D:/IsmIndex.xlsx");
            Worksheet worksheet = workbook.Worksheets[1];
            Worksheet secondSheet = workbook.Worksheets[2];


            SavePonders(worksheet, model.ManufacturingIndustries, 7, column);
            SavePonders(secondSheet, model.NewOrders, 7, column);
            SavePonders(secondSheet, model.Production, 31, column);
            SavePonders(secondSheet, model.Employment, 55, column);


            workbook.Save();
            workbook.Close();
        }

        private static void SavePonders(Worksheet worksheet, ManufacturingIndustries model,int row, int column)
        {
            worksheet.Cells[row, column] = model.ApparelLeatherAlliedProducts;
            worksheet.Cells[row+1, column] = model.ChemicalProducts;
            worksheet.Cells[row+2, column] = model.ComputerElectronicProducts;
            worksheet.Cells[row+3, column] = model.ElectricalEqAppliancesComponents;
            worksheet.Cells[row+4, column] = model.FurnitureRelatedProducts;
            worksheet.Cells[row+5, column] = model.FabricatedMetalProducts;
            worksheet.Cells[row+6, column] = model.FoodBeverageTobaccoProducts;
            worksheet.Cells[row+7, column] = model.NonmetallicMineralProducts;
            worksheet.Cells[row+8, column] = model.MiscellaneousManufacturing;
            worksheet.Cells[row+9, column] = model.Machinery;
            worksheet.Cells[row+10, column] = model.PrintingRelatedSupportActivities;
            worksheet.Cells[row+11, column] = model.PetroleumCoalProducts;
            worksheet.Cells[row+12, column] = model.PrimaryMetals;
            worksheet.Cells[row+13, column] = model.PaperProducts;
            worksheet.Cells[row+14, column] = model.PlasticsRubberProducts;
            worksheet.Cells[row+15, column] = model.TextileMills;
            worksheet.Cells[row+16, column] = model.TransportationEquipment;
            worksheet.Cells[row+17, column] = model.WoodProducts;
        }
    }
}
