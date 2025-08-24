using Microsoft.EntityFrameworkCore;
using TestStore.Data.Entities;

namespace TestStore.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Resource> Resources { get; set; } = null!;
    public DbSet<Unit> Units { get; set; } = null!;
    public DbSet<ReceiptDocument> ReceiptDocuments { get; set; } = null!;
    public DbSet<ReceiptResource> ReceiptResources { get; set; } = null!;
}