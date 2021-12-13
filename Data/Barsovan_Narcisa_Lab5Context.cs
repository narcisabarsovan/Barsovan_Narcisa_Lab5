using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Barsovan_Narcisa_Lab5.Models;

namespace Barsovan_Narcisa_Lab5.Data
{
    public class Barsovan_Narcisa_Lab5Context : DbContext
    {
        public Barsovan_Narcisa_Lab5Context (DbContextOptions<Barsovan_Narcisa_Lab5Context> options)
            : base(options)
        {
        }

        public DbSet<Barsovan_Narcisa_Lab5.Models.Book> Book { get; set; }

        public DbSet<Barsovan_Narcisa_Lab5.Models.Publisher> Publisher { get; set; }

        public DbSet<Barsovan_Narcisa_Lab5.Models.Category> Category { get; set; }
    }
}
