using CsvHelper.Configuration.Attributes;

namespace CsvHelperApp.Models
{
    public class User
    {
        [Name("Id")]
        public int Id { get; set; }

        [Name("Name")]
        public string Name { get; set; }
    }
}
