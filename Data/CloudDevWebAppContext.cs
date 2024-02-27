using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CloudDevWebApp.Models;

namespace CloudDevWebApp.Data
{
    public class CloudDevWebAppContext : DbContext
    {
        public CloudDevWebAppContext (DbContextOptions<CloudDevWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<Movies> Movies { get; set; } = default!;

        public DbSet<CloudDevWebApp.Models.Movie> Movie { get; set; } = default!;
    }
}
