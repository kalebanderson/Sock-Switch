using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SockSwitch.Models
{
    public class User
    {
        [Key]
        public long UserID { get; set; }

        public string FirstName { get; set; }
        public string LastName {get;set;}
        public string EmailAddress { get; set; }
        public DateTime Birthday { get; set; }

    }
}