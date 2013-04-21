using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SockSwitch.Models
{
    public class ListedItem
    {
        [Key]
        public long ItemID { get; set; }

        public string Name { get; set; }
        //public string Category { get; set; }      possible enum for category
        //public string Area { get; set; }      possible enum for area where it was found

    }
}