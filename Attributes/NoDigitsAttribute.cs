using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace PetShop.Attributes
{
    public class NoDigitsAttribute : ValidationAttribute
    {
        //constructor takes no parameters, invoke the base constructor, pass err msg
        public NoDigitsAttribute() : base("No numbers allowed!") { }

        //override bool IsValid,casr to string, return true if string has no digits, otherwise false
        public override bool IsValid(object value)
        {
            bool result = value.ToString().Any(char.IsDigit);
            return !result;
        }
    }
}