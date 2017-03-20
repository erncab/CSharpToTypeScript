using System;

namespace CSharpToTypeScript.Models
{
    public class Region
    {
        public int Id { get; set; }       // HrccId 
        public string Code { get; set; }
        public string NameEn { get; set; }
        public string NameFr { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int UserUpdatedId { get; set; }
        public int UserCreatedId { get; set; }
        public DateTime RegionLastUpdated { get; set; }
        public DateTime AddressLastUpdated { get; set; }
        public Contact Contact { get; set; } 
    }
}
