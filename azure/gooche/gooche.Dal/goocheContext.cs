using gooche.Classes;
using Microsoft.EntityFrameworkCore;

namespace gooche.Dal
{
    public class goocheContext : DbContext
    {
        public goocheContext(DbContextOptions<goocheContext> options)
            : base(options) { }

        public DbSet<UserData> Users { get; set; }

        public DbSet<Menu> Menus { get; set; }
    }
}
