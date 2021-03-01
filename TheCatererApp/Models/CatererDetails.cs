using System;
using System.Collections.Generic;
using System.Text;

namespace TheCatererApp.Models
{
    public class CatererDetails
    {
        public int Id { get; set; }
        public string SurName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string Address { get; set; }
        public string StoreName { get; set; }
        public string PhoneNumber { get; set; }
        public byte Image { get; set; }
        public string ListOfServices { get; set; }
        public string ListOfDishes { get; set; }
        public string BankAccountDetails { get; set; }
    }
}
