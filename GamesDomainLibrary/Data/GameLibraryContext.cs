using GamesDomainLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesDomainLibrary.Data
{
    public class GameLibraryContext : DbContext
    {
        private string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=GameLibrary;Trusted_Connection=True";

        public DbSet<Game> Games { get; set; }

        public GameLibraryContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
