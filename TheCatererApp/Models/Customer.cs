using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TheCatererApp.Models
{
   public class Customer
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Location { get; set; }
        [Column(TypeName = "decimal(18, 6)")]
        public decimal TotalCost { get; set; }
       
        [Column(TypeName = "decimal(18, 6)")]
        public decimal Budget { get; set; }
        public int NumberOfGuest { get; set; }
        public string TypeOfFood { get; set; }
        public DateTime DateOfEvent { get; set; }
        
    }
}
