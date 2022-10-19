using Microsoft.EntityFrameworkCore;
using SuperTrader.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTrader.DataAccess.Context
{
    public class SuperTraderContext :DbContext
    {
        public SuperTraderContext()
        {

        }
       public DbSet<Buy> Buy { get; set; } 
       public DbSet<Sell> Sell { get; set; }
       public DbSet<Portfolio> Portfolio { get; set; }
       public DbSet<Share> Share { get; set; }
       public DbSet<Traders> Traders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseNpgsql(@"Host=localhost; Database=ST_DB; Username=postgres; Password=12345");
        }

        #region Required
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sell>()
               .HasOne(p => p.share).WithOne().OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Sell>()
               .HasOne(p => p.trader).WithOne().OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Portfolio>()
               .HasOne(p => p.trader).WithMany().OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Portfolio>()
               .HasOne(p => p.sell).WithMany().OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Portfolio>()
               .HasOne(p => p.buy).WithMany().OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Buy>()
               .HasOne(p => p.share).WithOne().OnDelete(DeleteBehavior.NoAction); 
            modelBuilder.Entity<Portfolio>()
               .HasOne(p => p.trader).WithOne().OnDelete(DeleteBehavior.NoAction);
        }
        #endregion

    }
}
