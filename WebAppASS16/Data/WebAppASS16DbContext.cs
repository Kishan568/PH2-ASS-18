using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppASS16.Models;

namespace WebAppASS16.Data
{
    public class WebAppASS16DbContext : DbContext
    {
        public WebAppASS16DbContext (DbContextOptions<WebAppASS16DbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppASS16.Models.Task> Task { get; set; } = default!;
    }
}
