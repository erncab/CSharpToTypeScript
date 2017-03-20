using System;

namespace CSharpToTypeScript.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Guid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NameToPrint { get; set; }
        public int UserUpdatedId { get; set; }
        public int OfficerId { get; set; }
        public int? JobTitleId { get; set; }
        public bool HasAdditionalRegions { get; set; }

        public DateTime? ExpiryDate { get; set; }
        public DateTime DateUpdated { get; set; }

        public Region HomeRegion { get; set; }
        public Region[] Regions { get; set; }
        public AuthorizingLevel AuthorizingLevel { get; set; }
        public ContactInfo ContactInfo { get; set; }
    }
}
