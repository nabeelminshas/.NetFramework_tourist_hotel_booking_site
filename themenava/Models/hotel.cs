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
    using System.Web;

    public partial class hotel
    {
        public int id { get; set; }
        [Required]
        public string address { get; set; }
        public string imageurl { get; set; }
        [Required]
        public string h_placeid { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string no_of_rooms { get; set; }
        //[Required]
        public int price { get; set; }
        public HttpPostedFileBase imagefile { get; set; }
    }
}