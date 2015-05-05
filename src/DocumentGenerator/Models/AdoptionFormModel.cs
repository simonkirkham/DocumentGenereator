using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DocumentGenerator.Models
{
    public class AdoptionFormModel
    {
        [DisplayName("Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime Date { get; set; }

        [DisplayName("Name")]
        [Required]
        public string FullName { get; set; }

        [DisplayName("Address Line 1")]
        [Required]
        public string AddressLine1 { get; set; }

        [DisplayName("Address Line 2")]
        public string AddressLine2 { get; set; }

        [DisplayName("Address Line 3")]
        public string AddressLine3 { get; set; }

        [DisplayName("Postcode")]
        [DataType(DataType.PostalCode)]
        [Required]
        public string Postcode { get; set; }

        [DisplayName("Telephone Number")]
        [DataType(DataType.PhoneNumber)]
        [Required]
        public string TelephoneNumber { get; set; }

        [DisplayName("Email Address")]
        [EmailAddress]
        [Required]
        public string EmailAddress { get; set; }

        [DisplayName("Animal Name")]        
        [Required]
        public string AnimalName { get; set; }
    }
}