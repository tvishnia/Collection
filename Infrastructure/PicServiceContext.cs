using ComparerBasic.Domain;
using Microsoft.EntityFrameworkCore;

namespace ComparerBasic.Infrastructure;

public class PicServiceContext : 
    DbContext, 
    IPicServiceContext
{
    public DbSet<PictureFileInfo> PictureFileInfos => Set<PictureFileInfo>();
    
    public PicServiceContext(DbContextOptions options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}