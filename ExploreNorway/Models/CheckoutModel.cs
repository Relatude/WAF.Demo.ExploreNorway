using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExploreNorway.Models
{
    public class CheckoutModel
    {

        [Required(ErrorMessage = "*")]
        public string Email { get; set; }

        [DisplayName("Forename:")]
        [Required(ErrorMessage = "*")]
        public string BillingForename { get; set; }

        [DisplayName("Surname:")]
        [Required(ErrorMessage = "*")]
        public string BillingSurname { get; set; }

        [DisplayName("Company:")]
        [Required(ErrorMessage = "*")]
        public string BillingCompany { get; set; }

        [DisplayName("Mobile:")]
        [Required(ErrorMessage = "*")]
        public string BillingMobile { get; set; }

        [DisplayName("Billing address:")]
        [Required(ErrorMessage = "*")]
        public string BillingAddress { get; set; }

        [DisplayName("Billing address 2:")]
        public string BillingAddress2 { get; set; }

        [DisplayName("Zip code:")]
        [Required(ErrorMessage = "*")]
        public string BillingZipCode { get; set; }

        [DisplayName("City:")]
        [Required(ErrorMessage = "*")]
        public string BillingCity { get; set; }

        [DisplayName("Use different address for shipping:")]
        public bool ShippingNotSameAsBilling { get; set; }


        [DisplayName("Forename:")]
        public string ShippingForename { get; set; }

        [DisplayName("Surname:")]
        public string ShippingSurname { get; set; }

        [DisplayName("Company:")]
        public string ShippingCompany { get; set; }

        [DisplayName("Mobile:")]
        public string ShippingMobile { get; set; }

        [DisplayName("Shipping address:")]
        public string ShippingAddress { get; set; }

        [DisplayName("Shipping address 2:")]
        public string ShippingAddress2 { get; set; }

        [DisplayName("Zip code:")]
        public string ShippingZipCode { get; set; }

        [DisplayName("City:")]
        public string ShippingCity { get; set; }
    }
}