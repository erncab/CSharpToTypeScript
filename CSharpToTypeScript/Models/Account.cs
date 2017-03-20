using System;

namespace CSharpToTypeScript.Models
{
    public class Account : EntityBase
    {
        public int AccessStatusId { get; set; }
        public string Code { get; set; }
        public string NameEn { get; set; }
        public string NameFr { get; set; }
        public string DescEn { get; set; }
        public string DescFr { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
