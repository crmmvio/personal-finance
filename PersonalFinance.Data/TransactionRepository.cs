using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PersonalFinance.Data.Interfaces;
using PersonalFinance.Domain.Entities;

namespace PersonalFinance.Data
{
    public class TransactionRepository : IBaseRepository<Transaction>, ITransactionRepository { }
}
