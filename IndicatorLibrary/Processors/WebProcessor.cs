using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;


namespace IndicatorLibrary.Processors
{
    public static class WebProcessor
    {
        public static string GetHttpSourceCode(string url)
        {
            string output = "";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                output = reader.ReadToEnd();
            }

            response.Close();

            return output;
        }

        public static string HtmlTagRemover(string str)
        {
            string output = Regex.Replace(str, "<[^>]*>", "\n");
            output = Regex.Replace(output, @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);
            output = Regex.Replace(output, "(&#|&)[a-zA-Z0-9;]{2,5}", string.Empty);
            output = output.Replace("Committee:", string.Empty);

            return output;
        }
    }
}
