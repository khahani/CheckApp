using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace Tabaar.CheckApp.Model
{
    public class CheckDatabase : DbContext
    {
        public CheckDatabase() : base("MyDefaultConnection") { }

        public DbSet<Check> Checks { get; set; }
    }

    //public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<CheckDatabase>
    //{
        
    //}
}
