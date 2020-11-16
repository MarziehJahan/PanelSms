using Microsoft.EntityFrameworkCore;
using System;

namespace Panel.DAL
{
    public class PanelSimorghContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=123;Persist Security Info=True;User ID=sa;Initial Catalog=PanelSms;Data Source=DESKTOP-MBE8C0P");
            base.OnConfiguring(optionsBuilder);

        }
        public DbSet<Acquaintance> Acquaintances { get; set; }
        public DbSet<Condition> Conditions { get; set; }
        public DbSet<PanelSimorgh> Panels { get; set; }
        public DbSet<TermsAcceptance> Terms { get; set; }
        public DbSet<UserPanel> users { get; set; }
    }
}
