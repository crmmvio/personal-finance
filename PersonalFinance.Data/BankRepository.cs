using PersonalFinance.Data.Interfaces;
using PersonalFinance.Domain.Entities;
using PersonalFinance.Data.DataContexts;

namespace PersonalFinance.Data
{
    public class BankRepository : BaseRepository<AppDbContext, Bank>, IBankRepository { }
}
