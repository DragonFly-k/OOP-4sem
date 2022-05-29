using L10.db.model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10.db
{
    class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("connect")
        { }

        public DbSet<Product> Products { get; set; }
    }
}
