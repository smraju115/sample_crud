using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CroudAppRaju.Model;

namespace CroudAppRaju.Data
{
    public class CroudAppRajuContext : DbContext
    {
        public CroudAppRajuContext (DbContextOptions<CroudAppRajuContext> options)
            : base(options)
        {
        }

        public DbSet<CroudAppRaju.Model.User> User { get; set; } = default!;
    }
}
