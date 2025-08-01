namespace WebApiChatBoot.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public string? Plano { get; set; }
        public string? Operadora { get; set; }
        public string? Vigencia { get; set; }
        public string? dtInclisao { get; set; }
        public string? Status { get; set; }
    }
}
