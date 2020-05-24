using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Context : DbContext
    {
        public Context()
            : base("DbConnection")
        { }

        public DbSet<Good> Goods { get; set; }
        public DbSet<Transport> Transports { get; set; }
        public DbSet<Destination> Destinations { get; set; }
    }
}
