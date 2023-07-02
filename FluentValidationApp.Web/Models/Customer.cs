using System;
using System.Collections.Generic;

namespace FluentValidationApp.Web.Models
{
    public class Customer
    {
        public int Id { get; set; }

        //  [Required(ErrorMessage = "Name alanı boş olamaz.Attribute den geliyor.")]
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public DateTime? BirthDate { get; set; }
        public IList<Address> Addresses { get; set; }
        public Gender Gender { get; set; }
    }
}

/*
 * Fluent Validation faydaları : 
 1- SoC : Seperation of concerns prensibine uyumludur. 
 2- Unit test kolaylığı sağlar. 
 3- custom validasyon kolaylıkla yazılır. 
 */