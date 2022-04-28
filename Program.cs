using LINQtoCSV;
using Newtonsoft.Json;

namespace CsvtoJson
{
    internal class Program
    {
        public int count { get; set; }

        public static void Main(string[] args)
        {
            var pr = new Program();

            string? JsonToPass = pr.ReadCsvFile("Test1");  //Pass Test2 to see if the return json has only Test2 row's details
            Console.WriteLine(JsonToPass);
            if (pr.count == 0)
            {
                Console.WriteLine("No data for Test selected");
            }
            else
            {
                var FinalJson = JsonToPass.Replace("\"Header1\":null,", "");
                Console.WriteLine(FinalJson);
            }
        }

        public string? ReadCsvFile(string testid)
        {
            var csvFileDescription = new CsvFileDescription
            {
                FirstLineHasColumnNames = true,
                IgnoreUnknownColumns = true,
                SeparatorChar = ',',
                UseFieldIndexForReadingData = false,
            };
            var csvContext = new CsvContext();
            var rowsConfigs = csvContext.Read<CSV>("File.csv", csvFileDescription);
            count = 0;
            List<CSV> list = new List<CSV>();
            foreach (var row in rowsConfigs)
            {
                if (row.Header1 == testid)
                {
                    count++;
                    CSV cSV = new CSV
                    {
                        Header2 = row.Header2,
                        Header3 = row.Header3,
                        Header4 = row.Header4,
                        Header5 = row.Header5,
                        Header6 = row.Header6,
                        Header7 = row.Header7,
                        Header8 = row.Header8,
                        Header9 = row.Header9,
                    };

                    list.Add(cSV);
                }
            }
            if (count > 0)
            {
                Console.WriteLine("Number of locks found = " + count);
                string newjson = JsonConvert.SerializeObject(list);
                return newjson;
            }
            else
            {
                return null;
            }
        }
    }
}
