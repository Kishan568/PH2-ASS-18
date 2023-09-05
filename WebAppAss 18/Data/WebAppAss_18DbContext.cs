using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppAss_18.Models;

namespace WebAppAss_18.Data
{
    public class WebAppAss_18DbContext : DbContext
    {
        public WebAppAss_18DbContext (DbContextOptions<WebAppAss_18DbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppAss_18.Models.Movie> Movie { get; set; } = default!;
    }
}
