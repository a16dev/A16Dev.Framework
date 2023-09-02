using System.Threading;
using System.Threading.Tasks;

namespace A16Dev.Data.Abstractions
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));

        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);

        int SaveChanges();

        int SaveChanges(bool acceptAllChangesOnSuccess);
    }
}