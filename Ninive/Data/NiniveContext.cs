using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Ninive.Data
{
    public class NiniveContext
    {
        public DbSet<User> Users { get; set; }
        public NiniveContext(DbContextOptions options)
        {

        }
    }
}
