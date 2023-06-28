using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RealEstate.Areas.Identity.Data;
using RealEstate.Models;

namespace RealEstate.Areas.Identity.Data;

public class RealEstateContext : IdentityDbContext<RealEstateUser>
{
    public RealEstateContext(DbContextOptions<RealEstateContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    public DbSet<RealEstate.Models.Agent> Agent { get; set; } = default!;

    public DbSet<RealEstate.Models.Client> Client { get; set; } = default!;

    public DbSet<RealEstate.Models.Listing> Listing { get; set; } = default!;

    public DbSet<RealEstate.Models.Seller> Seller { get; set; } = default!;
}
