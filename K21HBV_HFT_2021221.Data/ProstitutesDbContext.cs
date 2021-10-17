using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K21HBV_HFT_2021221.Data
{
    public class ProstitutesDbContext:DbContext
    {
        public ProstitutesDbContext()
        {
            Database.EnsureCreated();
        }
        public ProstitutesDbContext(DbContextOptions<ProstitutesDbContext> options):base(options)
        {

        }
        public virtual DbSet<Prostitutes>

    }
}
