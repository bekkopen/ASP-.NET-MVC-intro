using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVCintro.Models
{
    public class PersonModel
    {
        public PersonModel(int personId, string firstName, string lastName, string phoneNumber)
        {
            Id = personId;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }

        public PersonModel()
        {
            
        }

        public int Id { get; set; }
        [DisplayName("Fornavn")]
        public string FirstName { get; set; }
        [DisplayName("Etternavn")]
        public string LastName { get; set; }
        [DisplayName("Telefonnummer")]
        public string PhoneNumber { get; set; }
    }
}