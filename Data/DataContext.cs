using exercise_app_api.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise_app_api.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options){}
    public DbSet<TestClass> Users { get; set; }
    
  }
}