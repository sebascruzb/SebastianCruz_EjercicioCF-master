using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SebastianCruz_EjercicioCF.Models;

    public class Web_DbContext : DbContext
    {
        public Web_DbContext (DbContextOptions<Web_DbContext> options)
            : base(options)
        {
        }

        public DbSet<SebastianCruz_EjercicioCF.Models.Burguer> Burguer { get; set; } = default!;
    }
