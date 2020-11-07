using CsvHelper.Configuration.Attributes;

namespace CsvHelperApp.Models
{
    public class User
    {
        [Name("id")]
        public int Id { get; set; }

        [Name("name")]
        public string Name { get; set; }
    }
}
