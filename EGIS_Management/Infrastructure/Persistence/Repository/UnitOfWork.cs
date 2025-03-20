
namespace Infrastructure.Persistence.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public EGISManagementDbContext _dbContext;

        public UnitOfWork(EGISManagementDbContext dbContext)
        {
              _dbContext = dbContext;  
        }

        public IBankRepository Bank => new BankRepository(_dbContext);

        public IMasterTableCodeRepository MasterCode =>new MasterTableCodeRepository(_dbContext);

        public IMasterTableSubCodeRepository SubCode => new MasterTableSubCodeRepository(_dbContext);

        public async Task<bool> CommitAsync()
        {
            try
            {
                return await _dbContext.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
