using System;

namespace CSharpToTypeScript.Models
{
    public class Address
    {
        public int? Id { get; set; }

        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string BusinessAddress { get; set; }
        public string CityName { get; set; }
        public string PostalCode { get; set; }
        public Country Country { get; set; }
        public Province Province { get; set; }
        public State State { get; set; }
        public DateTime? DateUpdated { get; set; }
    }
}
