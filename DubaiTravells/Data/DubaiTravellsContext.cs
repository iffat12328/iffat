using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DubaiTravells.Models
{
    public class DubaiTravellsContext : DbContext
    {
        public DubaiTravellsContext (DbContextOptions<DubaiTravellsContext> options)
            : base(options)
        {
        }

        public DbSet<DubaiTravells.Models.User> User { get; set; }
    }
}
