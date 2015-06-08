using System;
using System.Collections.Generic;
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

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
    }
}