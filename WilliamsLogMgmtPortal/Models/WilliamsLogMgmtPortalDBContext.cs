using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WilliamsLogMgmtPortal.Models
{
    public class WilliamsLogMgmtPortalDBContext: DbContext
    {
        public DbSet<Message> Messages { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<User> Users { get; set; }
    }
}