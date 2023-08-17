using HotelFinder.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelFinder.DataAccess;

public class HotelDbContext : DbContext
{
     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
     {
          base.OnConfiguring(optionsBuilder);
          optionsBuilder.UseSqlServer(
               "Server=tcp:localhost,1433;Initial Catalog=HotelDB;Persist Security Info=False;User ID=SA;Password=reallyStrongPwd123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30");
     }

     public DbSet<Hotel> Hotels { get; set; }
}