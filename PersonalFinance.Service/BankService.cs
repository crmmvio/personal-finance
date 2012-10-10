using System;
using PersonalFinance.Data;
using PersonalFinance.Domain.Entities;

namespace PersonalFinance.Service
{
    public class BankService : BaseService<BankRepository, Bank>
    {
        public override bool IsValid(PersonalFinance.Domain.Entities.Bank entity)
        {
            entity.BankNumber = string.Format("{0:d3}", Convert.ToInt32(entity.BankNumber));
            return base.IsValid(entity);
        }
    }
}
