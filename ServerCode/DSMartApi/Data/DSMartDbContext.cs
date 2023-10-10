using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using DSMartEntities.Entities;

namespace AspNetCoreApp.Data;

public class DSMartDbContext : DbContext
{
    public IConfiguration Configuration { get; }
    public DSMartDbContext(DbContextOptions<DSMartDbContext> options, IConfiguration configuration) : base(options)
    {
        Configuration = configuration;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        if (modelBuilder == null)
        {
            throw new ArgumentNullException(nameof(modelBuilder));

            base.OnModelCreating(modelBuilder);
        }
    }

    public DbSet<ALLCODE> AllCode { get; set; }
    public DbSet<Users> Users { get; set; }
}
