﻿using System.Data;
using ExcelDataReader;

namespace Selenium.Config
{
    public class ConfigDataAccess
    {
        public static IEnumerable<TestCaseData> ReadDataProduct() { return ReadDataFromExcel("ProductPage"); }

        private static IEnumerable<TestCaseData>ReadDataFromExcel(string SheetName)
        {
            string? executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string filePath = Path.Combine(executableLocation + "/Data/TestData/TestData.xlsx");
            //string filePath = Path.Combine(executableLocation + "/Data/TestData/TestData.csv");

            var testCases = new List<TestCaseData>();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {

                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    if (reader == null)
                        throw new Exception(string.Format("No data return from file, file name:{0}", filePath));


                    DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = false
                        }
                    });

                    //string? expression = "TestScriptID = " + TestTestScriptID;
                    //string? sortOrder = "TestScriptID ASC";
                    //DataRow[] foundRows = result.Tables[SheetName].Select();



        
                    while (reader.Read())
                    {
                        var row = new List<string>();
                        var columnCount = reader.FieldCount;
                        for (var i = 0; i < columnCount; i++)
                            row.Add(reader.GetValue(i).ToString());
                        testCases.Add(new TestCaseData(row.ToArray()));
                    }

                }
            }
            if (testCases != null)
                foreach (TestCaseData testCaseData in testCases)
                    yield return testCaseData;
        }
       
    }
}

