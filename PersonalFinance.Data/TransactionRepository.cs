using PersonalFinance.Data.DataContexts;
using PersonalFinance.Data.Interfaces;
using PersonalFinance.Domain.Entities;

namespace PersonalFinance.Data
{
    public class TransactionRepository : BaseRepository<AppDbContext, Transaction>, ITransactionRepository { }
}
