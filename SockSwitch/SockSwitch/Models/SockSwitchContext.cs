using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace SockSwitch.Models
{
    public class SockSwitchContext : DbContext
    {
        public SockSwitchContext()
            : base("SockSwitchConnection")
    {

    }

        public DbSet<User> Users { get; set; }
        public DbSet<ListedItem> ListedItems { get; set; }
    }
}