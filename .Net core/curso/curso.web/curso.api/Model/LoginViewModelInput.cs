using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Model
{
    /// <summary>
    /// Classe responsável por manter os dados de login
    /// </summary>
    public class LoginViewModelInput
    {
        [Required(ErrorMessage = "O login não pode ser vazio")]
        public string Login { get; set; }
        [Required(ErrorMessage = "A senha não pode ser vazia")]
        public string Senha { get; set; }
    }
}
