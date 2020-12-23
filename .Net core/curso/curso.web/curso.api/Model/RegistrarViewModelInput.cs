namespace curso.api.Model
{ 
    /// <summary>
    /// Classe responsável por manter os dados de registro
    /// </summary>
    public class RegistrarViewModelInput
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }

    }
}
