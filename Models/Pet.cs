using PetShop.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;




namespace PetShop.Models
{
    public class Pet
    {
        [Display(Name = "Pet ID")]
        public virtual int petID { get; set; }

        [Display(Name = "Pet Name")]
        [NoDigits] // add the noDigitsAttribute to the name property
        public virtual string petName { get; set; }

        [Display(Name ="Is Male")]
        public virtual bool isMale { get; set; }

        public virtual string Breed { get; set; }
        public virtual ApplicationUser Owner { get; set; }

        //add a new integer property called Age, add NonNegativeAttribute to Age
        [NonNegative]
        public virtual int petAge { get; set; }
    }
}
