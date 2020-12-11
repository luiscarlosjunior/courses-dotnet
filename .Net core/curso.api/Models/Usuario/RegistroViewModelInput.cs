using System.ComponentModel.DataAnnotations;

namespace curso.api.Models.Usuario
{
    /// <summary>
    /// Classe responsável por registrar
    /// </summary>
    public class RegistroViewModelInput
    {
        [Required(ErrorMessage = "O login é obrigatório")]
        public string Login { get; set; }

        [Required(ErrorMessage = "O e-mail não é válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha é obrigatória")]
        public string Senha { get; set; }
    }
}
