using System.ComponentModel.DataAnnotations;

namespace ContatoMVC.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O Campo {0} não pode ser vazio.")]
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        [EmailAddress(ErrorMessage = "O Email informado não é válido.")]
        public string Email { get; set; }
        [RegularExpression(@"^[0-9""'\s-]*$")]
        [MaxLength(15)]
        public string Telefone { get; set; }
    }
}
