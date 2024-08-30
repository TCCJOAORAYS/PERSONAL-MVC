using Personal.Models;
using Personal.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Personal.Data;
public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Exercise> Exercises { get; set; }

     protected override void OnModelCreating(ModelBuilder builder){
       base.OnModelCreating(builder);
        new AppDbSeed(builder);
    }
}