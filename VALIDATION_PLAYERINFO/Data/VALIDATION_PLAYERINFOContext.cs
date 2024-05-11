using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VALIDATION_PLAYERINFO.Models;

namespace VALIDATION_PLAYERINFO.Data
{
    public class VALIDATION_PLAYERINFOContext : DbContext
    {
        public VALIDATION_PLAYERINFOContext (DbContextOptions<VALIDATION_PLAYERINFOContext> options)
            : base(options)
        {
        }

        public DbSet<VALIDATION_PLAYERINFO.Models.Player> Player { get; set; } = default!;
    }
}
