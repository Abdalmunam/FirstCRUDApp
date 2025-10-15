using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirstCRUDApp.Models;

namespace FirstCRUDApp.Data
{
    public class FirstCRUDAppContext : DbContext
    {
        public FirstCRUDAppContext (DbContextOptions<FirstCRUDAppContext> options)
            : base(options)
        {
        }

        public DbSet<FirstCRUDApp.Models.Student> Student { get; set; } = default!;
    }
}
