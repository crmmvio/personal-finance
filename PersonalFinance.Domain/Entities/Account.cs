using System.ComponentModel.DataAnnotations;

namespace PersonalFinance.Domain.Entities
{
    [Table("Accounts")]
    public class Account
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo deve ter no máximo 100 caracteres")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Nome")]
        public int BankId { get; set; }
        public virtual Bank Bank { get; set; }

        [Display(Name = "Saldo Inicial")]
        public double InitialBalance { get; set; }

        [Display(Name = "Saldo Atual")]
        public double CurrentBalance { get; set; }
    }
}
