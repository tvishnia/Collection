using System.Threading;
using System.Threading.Tasks;
using ComparerBasic.Domain;
using Microsoft.EntityFrameworkCore;

namespace ComparerBasic.Infrastructure;

public interface IPicServiceContext
{
    DbSet<PictureFileInfo> PictureFileInfos { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}