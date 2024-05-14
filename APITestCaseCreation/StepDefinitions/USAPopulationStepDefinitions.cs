using APITestCaseCreation.Pages;
using NUnit.Framework;
using System;
using System.Net;
using TechTalk.SpecFlow;

namespace APITestCaseCreation.StepDefinitions
{
    [Binding]
    public class USAPopulationStepDefinitions
    {
        
        [Given(@"Retrieve data from (.*) and validate data is retrieved")]
        public void GivenRetrieveDataFromHttpsDatausa_IoApiDataDrilldownsNationMeasuresPopulationAndValidateDataIsRetrieved(string resourceUrl)
        {
            Assert.AreEqual(HttpStatusCode.OK,USAPopulationData.GetPopulationData(resourceUrl).StatusCode);
        }
       

        [When(@"Deserialize the data retrieved from (.*) and get entities out of it and create csv file with name as (.*)")]
        public void WhenDeserializeTheDataRetrievedFromHttpsDatausa_IoApiDataDrilldownsNationMeasuresPopulationAndGetEntitiesOutOfItAndConvertToCsv(string resourceURL , string filename)
        {
            USAPopulationData.DesrializeDataAndConvertToCSV(resourceURL, filename);
        }


        [Then(@"Validate CSV file is created with name as (.*)")]
        public void ThenValidateCSVFileIsCreated(string filename)
        {
           Assert.IsTrue( USAPopulationData.ValidateFileExist(filename+".csv"));
            File.Delete(filename + ".csv");
        }
    }
}
