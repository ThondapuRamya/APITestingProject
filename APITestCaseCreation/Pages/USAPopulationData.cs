using APILearningRestSharpFramework;
using APITestCaseCreation.Configurations;
using APITestCaseCreation.Models;
using Core.Helpers;
using Core.Settings;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using SpecFlow.Internal.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APITestCaseCreation.Pages
{
    public class USAPopulationData
    {
        public static RestResponse GetPopulationData(string resourceURL)
        {
            string baseURL = ConfigurationProvider.APICredentials.baseUrl;
            string url =baseURL+ resourceURL;
            RestRequest restRequest = RestClientUtils.CreateRequest(url, Method.Get, DataFormat.Json);
            RestResponse restResponse=  RestClientUtils.ExecuteRequest(restRequest);

            return restResponse;
        }

        public static void DesrializeDataAndConvertToCSV(string resourceURL , string fileName)
        {
            string content = GetPopulationData(resourceURL).Content;
            USAPopulationResponceRoot uSAPopulationResponceRoot= JsonConvert.DeserializeObject<USAPopulationResponceRoot>(content);
            CreateCSVFile.ConvertJsonToCSV(content, fileName+".csv");
        }


        public static bool ValidateFileExist(string fileName)
        {
           
            string csvFiles = new DirectoryInfo(WebDriverSettings.DOWNLOADSLOCATION).GetFiles("*.csv").OrderByDescending(f => f.CreationTime).Select(f => f.FullName).ToList()[0];
           
           return csvFiles.Contains(fileName);           

        }
    }
}
