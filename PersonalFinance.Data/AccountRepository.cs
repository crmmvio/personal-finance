using PersonalFinance.Data.Interfaces;
using PersonalFinance.Domain.Entities;
using PersonalFinance.Data.DataContexts;

namespace PersonalFinance.Data
{
    public class AccountRepository : BaseRepository<AppDbContext, Account>, IAccountRepository { }
}
