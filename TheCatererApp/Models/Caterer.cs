using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;



namespace TheCatererApp.Models
{
    public class Caterer
    {
        public int id { get; set; }
        [Required]
        public string Name { get; set; }

        // Server side validation
       // [DisplayName("Services")]
        [Required]
        //[Range(1, int.MaxValue, ErrorMessage = "Services Must be inputed")]
        public string Services { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Location { get; set; }
        public string Rating { get; set; }
    }
}
