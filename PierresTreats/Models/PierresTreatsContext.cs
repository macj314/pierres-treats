using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PierresTreats.Models;

namespace PierresTreats.Models
{
  public class PierresTreatsContext : IdentityDbContext<ApplicationUser> 
  {
    public virtual DbSet<Tag> Flavors { get; set; }
    public DbSet<Recipe> Treats { get; set; }
    public DbSet<RecipeTag> FlavorTreat { get; set; }
    public PierresTreatsContext(DbContextOptions options) : base(options) { }
    }
}