using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SockSwitch.Models
{
    public class UserViewModel
    {
        public ICollection<User> Users { get; set; }
        public ICollection<ListedItem> ListedItems { get; set; }
    }
}