using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigurationByConvention.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;// SHOULD BE THE SAME TABEL'S NAMES IN DB
        public DbSet<Tweet> Tweets { get; set; } = null!;
        public DbSet<Comment> Comments { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("tblUsers");

            modelBuilder.Entity<Tweet>().ToTable("tblTweets");

            modelBuilder.Entity<Comment>().ToTable("tblComments");

            modelBuilder.Entity<Comment>().Property(p => p.Id)
                .HasColumnName("CommentId");


            modelBuilder.Entity<Comment>().Property(p => p.CommentBy)
              .HasColumnName("UserId");

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = config.GetSection("constr").Value;

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
