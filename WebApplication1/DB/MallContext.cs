using ConsoleApp.DTO;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp.DB;

/// <summary>
///  数据库上下文.
/// </summary>
public class MallContext : DbContext
{
    public MallContext(DbContextOptions<MallContext> options) : base(options)
    {
    }

    public DbSet<Mall> Malls { get; set; }
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<Store> Stores { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<SalesRecord> SalesRecords { get; set; }
    public DbSet<Member> Members { get; set; }
    public DbSet<MemberConsumptionRecord> MemberConsumptionRecords { get; set; }
}

