using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCintro.Models
{
    public class PersonModel : IValidatableObject
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
        [Required(ErrorMessage = "Fornavn er obligatorisk")]
        public string FirstName { get; set; }
        [DisplayName("Etternavn")]
        [Required(ErrorMessage =  "Etternavn er obligatorisk")]
        public string LastName { get; set; }
        [DisplayName("Telefonnummer")]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        public string EmailAddress { get; set; }

        [StringLength(11, MinimumLength = 11, ErrorMessage = "Fødselsnummer må være 11 siffer")]
        [RegularExpression("[0-9]+", ErrorMessage = "Fødselsnummer kan ikke inneholde noe annet enn heltall")]
        [UIHint("IdentityNumber")]
        public string IdentityNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var result = new List<ValidationResult>();

            if (FirstName.Length + LastName.Length < 5)
            {
                var validationResult = new ValidationResult("For- og etternavn må totalt være minst 5 bokstaver", new[] { "FirstName", "LastName" });
                result.Add(validationResult);
            }
            return result;

        }
    }
}