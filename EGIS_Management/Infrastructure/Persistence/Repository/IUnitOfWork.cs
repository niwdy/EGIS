namespace Infrastructure.Persistence.Repository
{
    public interface IUnitOfWork
    {
        Task<bool> CommitAsync();
        IBankRepository Bank { get; }
        IMasterTableCodeRepository MasterCode { get; }
        IMasterTableSubCodeRepository SubCode { get; }
    }
}
