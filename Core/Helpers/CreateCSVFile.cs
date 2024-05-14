using Core.Settings;
using CsvHelper;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using Newtonsoft.Json;

namespace Core.Helpers
{
    public class CreateCSVFile
    {

        public static void ConvertJsonToCSV(string jsonContent ,string fileName)
        {
            string filePath = WebDriverSettings.DOWNLOADSLOCATION;
            //string csvPath = jsonContent.ToCsv(filePath,fileName);
            var expandos = JsonConvert.DeserializeObject<ExpandoObject>(jsonContent);
            using (TextWriter writer = new StreamWriter(Path.Combine(filePath, fileName)))
            {
                using (var csv = new CsvWriter(writer, System.Globalization.CultureInfo.CurrentCulture))
                {
                    csv.WriteRecords((expandos as dynamic));
                }              
            }
        }
    }
}
