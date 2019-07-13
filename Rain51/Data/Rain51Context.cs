using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rain51.Controllers;

namespace Rain51.Models
{
    public class Rain51Context : DbContext
    {
        public Rain51Context (DbContextOptions<Rain51Context> options)
            : base(options)
        {
        }

        public DbSet<Rain51.Controllers.Novice> Novice { get; set; }
    }
}
