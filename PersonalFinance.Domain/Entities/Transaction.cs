using System;
using System.ComponentModel.DataAnnotations;

namespace PersonalFinance.Domain.Entities
{
    [Table("Transactions")]
    public class Transaction
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [Display(Name = "Conta")]
        public int AccountId { get; set; }
        public virtual Account Account { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [Display(Name = "Data")]
        public DateTime TransactionDate { get; set; }

        [Display(Name = "Valor")]
        [Required(ErrorMessage = "O campo é obrigatório")]
        public double Value { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [Display(Name = "Tipo")]
        public ETransactionType TransactionType { get; set; }
    }
}
