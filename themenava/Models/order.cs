    //------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace themenava.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class order
    {
        [Required]
        public string first_name { get; set; }
        [Required]
        public string last_name { get; set; }
        [Required]
        public string phone_no_1 { get; set; }
        [Required]
        public string phone_no_2 { get; set; }
        [Required]
        public string email_address { get; set; }
        [Required]
        public string date { get; set; }
        [Required]
        public string cnic { get; set; }
        [Required]
        public int id { get; set; }
        [Required]
        public int no_of_days { get; set; }
        public int price { get; set; }
        public string title { get; set; }
    }
}
