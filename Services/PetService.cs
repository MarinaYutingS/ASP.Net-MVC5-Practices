using PetShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetShop.Services
{
    public class PetService
    {
        private ApplicationDbContext context;

        public PetService()
        {
            context = new ApplicationDbContext();
        }

        public PetService(ApplicationDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Create a public function inside PetService called OldEnoughToAdopt.
        /// </summary>
        /// <param name="birthDate">DateTime</param>
        /// <returns>true if DateTime is over 18 years old</returns>
        public bool OldEnoughToAdopt(DateTime birthDate)
        {
            var today = DateTime.Today;
            var age = today.Year - birthDate.Year;
            return age > 18;
        }
    }
}