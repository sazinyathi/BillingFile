using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp10
{
    class Program
    {
        public static List<Details> details { get; set; }
        public static List<string> cc;
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Processing *********************");
            details = new List<Details>();
            //ReadTextFile();
            ReadBillngReportFileWithAllTransactions();

           // List<Details> exports = GetListOfFingerprintsBillingReport();

            var file = @"C:\122.csv";
            string delimiter = ", ";
            WriteToCSVFile(details, file, delimiter);
            Console.WriteLine("Finished Processing *********************");
            Console.ReadLine();
        }

        private static void ReadTextFile()
        {
            string textFile = @"C:\Users\nyathiss\Desktop\New folder\JULY_2020NEW_EDORBCSV.txt";

            using (StreamReader readFile = new StreamReader(textFile))
            {
                string line;
                string[] _lines;

                while ((line = readFile.ReadLine()) != null)
                {
                    _lines = line.Split(',');
                    if (_lines[2] == "\"VARIOUS USERS                 \"")
                    {
                        continue;
                    }
                    var detail = new Details
                    {
                        PeopleSoft = _lines[0],
                        CustomerNumber = _lines[1],
                        Usename = _lines[2],
                        Blank1 = _lines[3],
                        IDIGOCode = _lines[4],
                        Blank2 = _lines[5],
                        Counts = _lines[6],
                        Blank3 = _lines[7],
                        Blank11 = _lines[8],
                        Blank4 = _lines[9],
                        Blank5 = _lines[10],
                        Price = _lines[11],
                        Name = _lines[12],
                        Surname = _lines[13],
                        Blank6 = _lines[14],
                        Blank7 = _lines[15],
                        BookingReferenceNumber = _lines[16],
                        Dates = _lines[17],
                        Blank8 = _lines[18],
                        Blank9 = _lines[19]

                    };


                    details.Add(detail);
                }
            }
        }
        private static void ReadBillngReportFileWithAllTransactions()
        {
            string textFile = @"C:\Users\nyathiss\Desktop\New folder\JULY_2020NEW_EDORBCSV.txt";
            // Read a text file line by line.

            string[] lines = File.ReadAllLines(textFile);


            for (int i = 0; i < lines.Length; i++)
            {

                var _lines = lines[i].Split(',');
                if (_lines[2] == "\"VARIOUS USERS                 \"")
                {
                    continue;
                }
                var detail = new Details
                {
                    PeopleSoft = _lines[0],
                    CustomerNumber = _lines[1],
                    Usename = _lines[2],
                    Blank1 = _lines[3],
                    IDIGOCode = _lines[4],
                    Blank2 = _lines[5],
                    Counts = _lines[6],
                    Blank3 = _lines[7],
                    Blank11 = _lines[8],
                    Blank4 = _lines[9],
                    Blank5 = _lines[10],
                    Price = _lines[11],
                    Name = _lines[12],
                    Surname = _lines[13],
                    Blank6 = _lines[14],
                    Blank7 = _lines[15],
                    BookingReferenceNumber = _lines[16],
                    Dates = _lines[17],
                    Blank8 = _lines[18],
                    Blank9 = _lines[19]

                };


                details.Add(detail);


            }


        }



        private static void WriteToCSVFile(List<Details> exports, string file, string delimiter)
        {
            using (var stream = File.CreateText(file))
            {
                //string createText = "Fist And  Surname" + delimiter + "Booking Reference Number" + delimiter + "IDIGO Number" + delimiter + "Price" + delimiter + Environment.NewLine;
                //stream.Write(createText);
                foreach (var item in exports)
                {
                    string csvRow = string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}", 
                        item.PeopleSoft + delimiter, 
                        item.CustomerNumber + delimiter,
                        item.Usename + delimiter,
                        item.Blank1 + delimiter, 
                        item.IDIGOCode + delimiter,
                        item.Blank2 + delimiter,
                        item.Counts + delimiter,
                        item.Blank3 + delimiter,
                        item.Blank11 + delimiter,
                        item.Blank4 + delimiter,
                        item.Blank5 + delimiter,
                        item.Price + delimiter,
                        item.Name + delimiter,
                        item.Surname + delimiter,
                        item.Blank6 + delimiter,
                        item.Blank7 + delimiter,
                        item.BookingReferenceNumber + delimiter,
                        item.Dates + delimiter,
                        item.Blank8 + delimiter,
                        item.Blank9 + delimiter
                  
                        + Environment.NewLine
                        
                        );


                    stream.Write(csvRow);
                }
            }
        }



        private static List<Details> GetListOfFingerprintsBillingReport()
        {
            var exports = new List<Details>();

            foreach (var item in cc)
            {
                var bb = item.Split(',');

                var detail = new Details
                {
                    PeopleSoft = bb[0],
                    CustomerNumber = bb[1],
                    Usename = bb[2],
                    Blank1 = bb[3],
                    IDIGOCode = bb[4],
                    Blank2 = bb[5],
                    Counts = bb[6],
                    Blank3 = bb[7],
                    Blank11 = bb[8],
                    Blank4 = bb[9],
                    Blank5 = bb[10],
                    Price = bb[11],
                    Name = bb[11],
                    Surname = bb[12],
                    Blank6 = bb[13],
                    Blank7 = bb[14],
                    BookingReferenceNumber = bb[15],
                    Dates = bb[16],
                    Blank8 = bb[17],
                    Blank9 = bb[18],
                    Blank10 = bb[19]
                };

                exports.Add(detail);
            }

            return exports;
        }


    }


    public class Details
    {
        public string PeopleSoft { get; set; } //0
        public string CustomerNumber { get; set; }//1
        public string Usename { get; set; }//2
        public string Blank1 { get; set; }//3
        public string IDIGOCode { get; set; }//4
        public string Blank2 { get; set; }//5
        public string Counts { get; set; }//6
        public string Blank3 { get; set; }//7
        public string Price { get; set; }//8
        public string Blank4 { get; set; }//9
        public string Blank5 { get; set; }//10
        public string Name { get; set; }//11
        public string Surname { get; set; }//12
        public string Blank6 { get; set; }//13
        public string BookingReferenceNumber { get; set; }//14
        public string Blank7 { get; set; }//15
        public string Blank8 { get; set; }//16
        public string Blank9 { get; set; }//17

        public string Dates { get; set; }//18
        public string Blank10 { get; set; }//19
        public string Blank11 { get; set; }//19

    }
}
