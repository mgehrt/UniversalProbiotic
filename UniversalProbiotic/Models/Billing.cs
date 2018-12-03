using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversalProbiotic.Models
{
    public class Billing
    {
        public int BillingID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string StateProvince { get; set; }

        public int PostalCode { get; set; }
        public int PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

    }
}