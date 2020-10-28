using System;
using System.Collections.Generic;
using System.Linq;
using IndicatorLibrary.Models;

namespace IndicatorLibrary.Processors
{
    public static class TextProcessor
    {
        public static ManufacturingIndustries SetDataIntoModel(string[] contractingIndu, string[] growingIndu)
        {
            var manufacIndu = new ManufacturingIndustries();
            List<string> industries = ManufacturingIndustries.GetAllIndustries();
            float[] ponders = CalculatePonderContracting(contractingIndu);

            foreach (string industry in industries)
            {
                for (int i = 0; i < contractingIndu.Length; i++)
                {
                    if (contractingIndu[i].Contains(industry))
                    {
                        manufacIndu.GetType().GetProperties().First(x => x.Name.Contains(industry)).SetValue(manufacIndu, ponders[i]);
                        break;
                    }
                }
            }

            ponders = CalculatePonderGrowing(growingIndu);

            foreach (string industry in industries)
            {
                for (int i = 0; i < growingIndu.Length; i++)
                {
                    if (growingIndu[i].Contains(industry))
                    {
                        manufacIndu.GetType().GetProperties().First(x => x.Name.Contains(industry)).SetValue(manufacIndu, ponders[i]);
                        break;
                    }
                }
            }

            return manufacIndu;
        }

        private static float[] CalculatePonderGrowing(string[] indu)
        {
            float[] ponders = new float[indu.Length];
            int j = indu.Length;

            for (int i = 0; i < indu.Length; i++, j--)
            {
                ponders[i] = ((float)1 / indu.Length) * j;
            }

            return ponders;
        }

        private static float[] CalculatePonderContracting(string[] indu)
        {
            float[] ponders = new float[indu.Length];
            int j = indu.Length;

            for (int i = 0; i < indu.Length; i++, j--)
            {
                ponders[i] = ((float)1 / indu.Length) * j * -1;
            }

            return ponders;
        }

        public static string GetIndustriesForPmi(this string str)
        {
            int endIndex = str.ToLower().IndexOf("what respondents") - str.IndexOf("latest");
            string output = str.Substring(str.IndexOf("latest"), endIndex);
            output = output.Substring(output.IndexOf(':'));

            return output;
        }

        public static string GetIndustriesForNewOrders(this string str)
        {
            int endIndex = str.ToLower().IndexOf("s production index") - str.ToLower().IndexOf("s new orders index");
            string output = str.Substring(str.ToLower().IndexOf("s new orders index"), endIndex);
            output = output.Substring(output.IndexOf(':'));

            return output;
        }

        public static string GetIndustriesForProduction(this string str)
        {
            int endIndex = str.ToLower().IndexOf("s employment index") - str.ToLower().IndexOf("s production index");
            string output = str.Substring(str.ToLower().IndexOf("s production index"), endIndex);
            output = output.Substring(output.IndexOf(':'));

            return output;
        }

        public static string GetIndustriesForEmployment(this string str)
        {
            int endIndex = str.ToLower().IndexOf("the delivery performance") - str.ToLower().IndexOf("s employment index");
            string output = str.Substring(str.ToLower().IndexOf("s employment index"), endIndex);
            output = output.Substring(output.IndexOf(':'));

            return output;
        }

        public static string[] GetGrowingIndustries(this string str)
        {
            string industries = str.Substring(0, str.IndexOf('.'));

            string[] output = industries.Split(';');

            return output;
        }

        public static string[] GetContractingIndustries(this string str)
        {
            string industries = str.Substring(str.IndexOf("are:"));

            string[] output = industries.Split(';');

            return output;
        }

        public static string[] GetContractingIndustriesNewOrders(this string str)
        {
            int endIndex = str.IndexOf("New Orders") - str.IndexOf("are:");
            string industries = str.Substring(str.IndexOf("are:"), endIndex);

            string[] output = industries.Split(';');

            return output;
        }

        public static string[] GetContractingIndustriesProduction(this string str)
        {
            int endIndex = str.IndexOf("Employment") - str.IndexOf("are:");
            string industries = str.Substring(str.IndexOf("are:"), endIndex);

            string[] output = industries.Split(';');

            return output;
        }

        public static string[] GetContractingIndustriesEmployment(this string str)
        {
            int endIndex = str.IndexOf("Supplier Deliveries") - str.IndexOf("are:");
            string industries = str.Substring(str.IndexOf("are:"), endIndex);

            string[] output = industries.Split(';');

            return output;
        }
    }
}
