using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HockeyPlayoffs.Data
{
    public class HockeyContext: DbContext
    {
        public DbSet<PlayoffPossibility> PlayoffPossibilities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=HockeyPlayoffs;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
