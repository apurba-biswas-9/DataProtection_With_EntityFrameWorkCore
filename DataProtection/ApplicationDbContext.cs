using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataProtection
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("Data Source=blogging.db");
        //}
        public DbSet<DataProtectionElement> DataProtectionXMLElements { get; set; }
    }

    public class DataProtectionElement
    {
        public DataProtectionElement()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public string Xml { get; set; }
    }
}
