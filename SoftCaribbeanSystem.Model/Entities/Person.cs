using SoftCaribbeanSystem.Model.Base.Entity;
using System;

namespace SoftCaribbeanSystem.Model.Entities
{
    public class Person: Entity
    {
        public string DNI { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int PersonTypeId { get; set; }
        public PersonType PersonType { get; set; }
        public string Genre { get; set; }
        public DateTime LeavingDate { get; set; }
        public string CodUser { get; set; }
        public string Address { get; set; }
        public string Photo { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
    }
}
