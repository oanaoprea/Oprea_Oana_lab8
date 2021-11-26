using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Oprea_Oana_lab8.Models;

namespace Oprea_Oana_lab8.Data
{
    public class Oprea_Oana_lab8Context : DbContext
    {
        public Oprea_Oana_lab8Context (DbContextOptions<Oprea_Oana_lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Oprea_Oana_lab8.Models.Book> Book { get; set; }

        public DbSet<Oprea_Oana_lab8.Models.Publisher> Publisher { get; set; }
    }
}
