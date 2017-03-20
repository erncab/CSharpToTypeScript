using System;

namespace CSharpToTypeScript.Models
{
    public class ContactAssignment : EntityBase
    {
        public int Id { get; set; }
        public string ComboId { get; set; }
        public decimal Count { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsThirdParty { get; set; }
    }
}
