namespace CompanyWebApi.Domains.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
