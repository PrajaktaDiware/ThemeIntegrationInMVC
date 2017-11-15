using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace themeIntegrationMvc.Models
{
    public class Associate
    {
        [Key]
        public int id { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string name { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        public string email { get; set; }
        [Required]
        [Display(Name = "Contact No.")]
        public string phone { get; set; }
        [Required]
        [Display(Name = "Location")]
        public string location { get; set; }
    }
}