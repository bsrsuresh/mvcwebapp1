using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvcwebapp1.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace mvcwebapp1.Models
{
    public class RecordContext : DbContext
    {
        public RecordContext() : base("RecordContext")
        {
        }
        public DbSet<Student> Students { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}