using Microsoft.EntityFrameworkCore;
using parseluygulamasi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parseluygulamasi.DataAccess
{
    public class ParselDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder opitonsBuilder) {

            base.OnConfiguring(opitonsBuilder);
            opitonsBuilder.UseNpgsql("Server = localhost ; Database = ParselDb; Port = 5432; User Id = postgres; Password = 12345;");
        }
        public DbSet<Parsel> Parsels { get; set; }
    }
}
