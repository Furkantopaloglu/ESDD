using System;
using System.Collections.Generic;
using System.Data.Entity;
using esdd.Enties;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esddDAL
{
    public class DatabaseContext : DbContext
    {
        public DbSet<EsddAdmin> Admin { get; set; }
        public DbSet<Ab> Ab { get; set; }
        public DbSet<Activity> activities { get; set; }
        public DbSet<Announcement> announcements { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<Gsb> gsbs { get; set; }
        public DbSet<Intent> ıntents { get; set; }
        public DbSet<Management> managements { get; set; }
        public DbSet<Media> medias { get; set; }
        public DbSet<Prodes> prodes { get; set; }


    }
}
