using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PetShop.Attributes
{
    public class NonNegativeAttribute:ValidationAttribute
    {
        //constructor takes no parameters, invoke the base constructor, pass err msg
        public NonNegativeAttribute() : base("Number cannot be negative") { }

        //override bool IsValid, return true if value is above 0, otherwise false
        public override bool IsValid(object value)
        {
            bool result = (int)value > 0;
            return result;
        }

    }
}