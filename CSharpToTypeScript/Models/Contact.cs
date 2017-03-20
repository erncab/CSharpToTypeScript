using System;

namespace CSharpToTypeScript.Models
{
    public class Contact
    {
        //Review:
        public string Phonedisplay { get; set; } // return all parts of the phone in the sp
        public string WebsiteUrl { get; set; }   // ?
        public string ContactName { get; set; }  // part of contact? 
        public int EmployerBn { get; set; }      // should be BusinessNumber?

        //Entity
        public int PhoneAreaCode { get; set; }
        public int PhoneNumber { get; set; }
        public string PhoneExtNumber { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime LastUpdated { get; set; }
        public int UserId { get; set; }
        public int PreferredLanguageId { get; set; }
        public string JobTitle { get; set; }
        public int SalutationId { get; set; }
        public string PhoneForeignNumber { get; set; }
        public int FaxAreaCode { get; set; }
        public int FaxNumber { get; set; }
        public string FaxForeignNumber { get; set; }
        public int OtherAreaCode { get; set; }
        public int OtherNumber { get; set; }
        public string FaxDisplay { get; set; }
        public bool IsThirdParty { get; set; }
        public string ThirdParty { get; set; }
        public DateTime DateUpdated { get; set; }
        public int EmployerId { get; set; }         // employer
        public string EmployerName { get; set; }    // employer
        public int BusinessNumber { get; set; }     // employer

        public Address Address { get; set; }
        public Account Account { get; set; }
        public AccountStatus AccountStatus { get; set; }
        public ContactRole ContactRole { get; set; }
        public ContactAssignment ContactAssignment { get; set; }
    }
}
