using cinema.Context;
using cinema.Models;
using Microsoft.EntityFrameworkCore;

namespace cinema.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly CinemaDbContext _context;
        public AccountRepository(CinemaDbContext context)
        {
            _context = context;
        }
        public bool Create(Account account)
        {
            throw new NotImplementedException();
        }

        public bool Destroy(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Account> GetAccount(string Id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Account>> GetAll()
        {
            return await _context.Accounts.OrderBy(p => p.cus_email).ToListAsync();
        }

        public bool Update(Account account)
        {
            throw new NotImplementedException();
        }
    }
}
