using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DAL
{
    public class DataContext : DbContext
    {
        //public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .AddJsonFile("./DatingApp/appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("default"));
        }
    }
}
