﻿using Microsoft.EntityFrameworkCore;
using SamuraiApp.Domain;
namespace SamuraiApp.Data
{
    public class SamuraiContext : DbContext
    {

        public SamuraiContext(DbContextOptions<SamuraiContext> options)
            : base(options)
        {}

        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Battle> Battles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SamuraiBattle>().HasKey(s => new { s.SamuraiId, s.BattleId });  //define M-M relationship of SamuraiBattle
        }

        

    }
}
