using cinema.Models;

namespace cinema.Repositories
{
    public interface IAccountRepository
    {
        bool Create(Account account);

        bool Update(Account account);

        bool Destroy(string id);

        Task<Account> GetAccount(string Id);

        Task<IEnumerable<Account>> GetAll();
    }
}
