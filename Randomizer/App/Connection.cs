using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer
{
    class Connection: DbContext
    { 
        public DbSet<User> Users { get; set; }
        public DbSet<Request> Requests{ get; set; }

        public Connection() : base("Name=Connection")
        {
            Configuration.AutoDetectChangesEnabled = true;
        }
    }
}
