using Microsoft.EntityFrameworkCore;

namespace MindBoxApp.SQLApplication;

public class SqlApplication : DbContext
{
    public SqlApplication()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var reader = new StreamReader("Configuration.txt");
        string config = reader.ReadLine();
        reader.Close();
        optionsBuilder.UseSqlServer(config);
    }

    public DbSet<Product> Products => Set<Product>();
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<CategoryByProduct> CategoriesByProduct => Set<CategoryByProduct>();
}