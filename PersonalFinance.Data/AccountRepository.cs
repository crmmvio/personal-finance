using PersonalFinance.Data.Interfaces;
using PersonalFinance.Domain.Entities;

namespace PersonalFinance.Data
{
    public class AccountRepository : IBaseRepository<Account>, IAccountRepository { }
}
