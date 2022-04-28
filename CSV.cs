

namespace CsvtoJson
{
    public class CSV
    {
        public string Header1 { get; set; } // This is an additional field added which will not be part of the json objects. This field is used to identy if this value is passed from Program to CsvRead method to convert this to json or not.
        public int Header2 { get; set; }
        public string Header3 { get; set; }
        public string Header4 { get; set; }
        public string Header5 { get; set; }
        public string Header6 { get; set; }
        public string Header7 { get; set; }
        public string Header8 { get; set; }
        public int Header9 { get; set; }
    }
}
