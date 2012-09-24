using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PersonalFinance.Data;
using PersonalFinance.Domain.Entities;

namespace PersonalFinance.Service
{
    public class TransactionService : BaseService<TransactionRepository, Transaction>
    {
        public override bool Add(Transaction entity)
        {
            if (entity.TransactionType == Domain.ETransactionType.Credit)
                entity.Account.CurrentBalance += entity.Value;
            else
                entity.Account.CurrentBalance -= entity.Value;

            return base.Add(entity);
        }
    }
}
