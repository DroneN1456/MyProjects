using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MeuSitezinho.Models;

namespace MeuSitezinho.Data
{
    public class MeuSitezinhoContext : DbContext
    {
        public MeuSitezinhoContext (DbContextOptions<MeuSitezinhoContext> options)
            : base(options)
        {
        }

        public DbSet<MeuSitezinho.Models.Department> Department { get; set; }
    }
}
