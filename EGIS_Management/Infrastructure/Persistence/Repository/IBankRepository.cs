using Domain.Entities;

namespace Infrastructure.Persistence.Repository
{
    public interface IBankRepository : IGenericRepository<Bank>
    {
        IEnumerable<Bank> GetAllByDate(DateTime dt);
    }
}
