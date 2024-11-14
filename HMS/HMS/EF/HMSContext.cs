using HMS.EF.TableModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HMS.EF
{
    public class HMSContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}