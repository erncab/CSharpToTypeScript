using System;

namespace CSharpToTypeScript.Models
{
    public class ContactInfo : EntityBase
    {
        public string EmailAddress { get; set; }
        public int? FaxAreaCode { get; set; }
        public int? FaxNumber { get; set; }
        public int? PhoneAreaCode { get; set; }
        public string PhoneExtNumber { get; set; }
        public int? PhoneNumber { get; set; }
        public string WebsiteUrl { get; set; }
        public string Name { get; set; }

        //New for Flow
        public int ContactId { get; set; }
        public int OfficialLanguageId { get; set; }
        public bool IsDuplicateInd { get; set; }
        public DateTime DateCeated { get; set; }
        public DateTime DateUpdated { get; set; }
        public int UserCreated { get; set; }
        public int UserUpdated { get; set; }
        public string JobTitle { get; set; }
        public int? AddressId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public int? SalutationId { get; set; }
        public int HomeAreaCode { get; set; }
        public int HomePhoneNumber { get; set; }
        public int BusinessAreaCode { get; set; }
        public int BusinessPhoneNumber { get; set; }
        public string BusinessExtNumber { get; set; }
        public string BusinessForeignNumber { get; set; }
        public string OtherAreaCode { get; set; }
        public string OtherPhoneNumber { get; set; }
        public string OtherExtNumber { get; set; }
        public string OtherForeignNumber { get; set; }
        public int FaxPhoneNumber { get; set; }
        public string FaxForeignNumber { get; set; }
        public DateTime? RedesignCnvrtDate { get; set; }

        public Address Address { get; set; }
    }
}
