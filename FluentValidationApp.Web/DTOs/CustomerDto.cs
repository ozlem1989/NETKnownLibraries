using System;

namespace FluentValidationApp.Web.DTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public string Eposta { get; set; }
        public int Yas { get; set; }
        public string FullName { get; set; }

        // flattening : ObjectName+PropertyName.
        //public string CreditCardNumber { get; set; }
        //public DateTime CreditCardValidDate { get; set; }

        //public string CCNumber { get; set; }
        //public DateTime CCValidDate { get; set; }

        // 2nd helper =>   IncludeMembers : 
        public string Number { get; set; }
        public DateTime ValidDate { get; set; }
    }
}
