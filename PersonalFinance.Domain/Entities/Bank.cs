using System.ComponentModel.DataAnnotations;

namespace PersonalFinance.Domain.Entities
{
    [Table("Banks")]
    public class Bank
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo deve ter entre {2} e {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Banco")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório")]
        [StringLength(3, ErrorMessage = "O campo deve ter {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Número")]
        public string BankNumber { get; set; }
    }
}
