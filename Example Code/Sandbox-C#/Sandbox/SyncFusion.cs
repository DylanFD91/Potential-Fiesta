//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using Syncfusion.XlsIO;
//using Newtonsoft.Json;
//using System.IO;

//namespace Sandbox
//{
//    class SyncFusion
//    {
//        public void ReadExcelToJSON()
//        {
//            //Instantiate the spreadsheet creation engine.
//            using (ExcelEngine excelEngine = new ExcelEngine())
//            {
//                IApplication application = excelEngine.Excel;
                
//                var pathToExcel = "C:\\Users\\mhein\\Desktop\\TestAttendanceBook.xlsx";

//                //The workbook is opened.
//                FileStream fileStream = new FileStream(pathToExcel, FileMode.Open);

//                IWorkbook workbook = application.Workbooks.Open(fileStream, ExcelOpenType.Automatic);
//                IWorksheet worksheet = workbook.Worksheets[0];

//                IRange[] rows = worksheet.Rows;
//                List<ExcelStudent> excelStudents = new List<ExcelStudent>();

//                foreach (IRange row in rows)
//                {
//                    IRange[] cells = row.Cells;

//                    // if is student row...
//                    if (cells[0].CalculatedValue != "Student Names" && cells[0].CalculatedValue != "")
//                    {
//                        // create ExcelStudent, give values, add to list
//                        ExcelStudent excelStudent = new ExcelStudent();

//                        // fill in possible values
//                        string fullName = cells[0].CalculatedValue;
//                        int indexOfFirstSpace = fullName.IndexOf(' ');

//                        excelStudent.FirstName = fullName.Substring(0, indexOfFirstSpace);
//                        excelStudent.LastName = fullName.Substring(indexOfFirstSpace + 1);

//                        excelStudent.AttendancePercentage = double.Parse(cells[1].CalculatedValue);

//                        excelStudents.Add(excelStudent);
//                    }
//                }

//                //Export worksheet data into CLR Objects
//                IList<ExcelStudent> customers = worksheet.ExportData<ExcelStudent>(1, 1, worksheet.UsedRange.LastRow, workbook.Worksheets[0].UsedRange.LastColumn);

//                //open file stream
//                using (StreamWriter file = File.CreateText("../../Output/data.json"))
//                {
//                    JsonSerializer serializer = new JsonSerializer();

//                    //serialize object directly into file stream
//                    // serializer.Serialize(file, customers);
//                }
//            }
//        }
//    }
//}



////// Current JSON approach:
//var pathToExcel = "C:\\Users\\mhein\\Desktop\\TestAttendanceBook.xlsx";
//var sheetName = "TestAttendanceBook";
//// var destinationPath = @"C:\path\to\save\json\file.json";

////Use this connection string if you have Office 2007+ drivers installed and 
////your data is saved in a .xlsx file
//var connectionString = $@"
//    Provider=Microsoft.ACE.OLEDB.12.0;
//    Data Source={pathToExcel};
//    Extended Properties=""Excel 12.0 Xml;HDR=YES""
//";

////Creating and opening a data connection to the Excel sheet 
//using (var conn = new OleDbConnection(connectionString))
//{
//    conn.Open();

//    var cmd = conn.CreateCommand();
//    cmd.CommandText = $"SELECT * FROM [{sheetName}$]";

//    using (var rdr = cmd.ExecuteReader())
//    {

//        //LINQ query - when executed will create anonymous objects for each row
//        var query = rdr.Cast<DbDataRecord>().Select(row => new
//        {
//            name = row[0],
//            regno = row[1],
//            description = row[2]
//        });

//        //Generates JSON from the LINQ query
//        var json = JsonConvert.SerializeObject(query);

//        //Write the file to the destination path    
//        // File.WriteAllText(destinationPath, json);
//    }
//}


//// With the following two approaches, I can open the .xlsx file and start reading,
//// but the data i'm getting doesn't seem to lineup with the actual data in the cells.
//// This seems to be an XML approach, looking now into a JSON approach.
//// Another potentional option could be saving files as .csv and using File.Something to read


//string filePath = "C:\\Users\\mhein\\Desktop\\Oxygen_Grading.xlsx";
//string filePath = "C:\\Users\\mhein\\Desktop\\TestAttendanceBook.xlsx";

//SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(filePath, false);

//WorkbookPart workbookPart = spreadsheetDocument.WorkbookPart;
//WorksheetPart worksheetPart = workbookPart.WorksheetParts.First();

//string text;

////// SAX approach: ////
//OpenXmlReader reader = OpenXmlReader.Create(worksheetPart);

//while(reader.Read())
//{

//    if(reader.ElementType == typeof(CellValue))
//    {
//        text = reader.GetText();
//        Console.WriteLine(text + " ");
//    }
//}


////// DOM approach: ////

//SheetData sheetData = worksheetPart.Worksheet.Elements<SheetData>().First();

//foreach (Row r in sheetData.Elements<Row>())
//{
//    foreach (Cell c in r.Elements<Cell>())
//    {
//        text = c.CellValue.Text;
//        Console.WriteLine(text + " ");
//    }
//}