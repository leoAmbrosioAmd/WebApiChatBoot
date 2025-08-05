namespace WebApiChatBoot.Models
{
    #region LOCAL ONDE SERA BUSACADO DO ALIANÇA
    //public class UsuarioModel
    //{
    //    public string Id { get; set; }
    //    public string? Nome { get; set; }
    //    public string? Cpf { get; set; }
    //    public string? Telefone { get; set; }
    //    public string? Email { get; set; }
    //    public string? Plano { get; set; }
    //    public string? Operadora { get; set; }
    //    public string? Vigencia { get; set; }
    //    public string? dtInclisao { get; set; }
    //    public string? Status { get; set; }
    //}
    #endregion

    public class UsuarioModel
    {
        public string Id { get; set; } // CODIGO_ASSOCIADO (varchar)
        public string? Nome { get; set; } // NOME_ASSOCIADO
        public string? Cpf { get; set; } // NUMERO_CPF
        public short? Telefone { get; set; } // CODIGO_EMPRESA (smallint)
        public short? Plano { get; set; }    // CODIGO_PLANO (smallint)
        public string? ULTIMO_STATUS { get; set; } // ULTIMO_STATUS (varchar)
        public DateTime? dtInclisao { get; set; } // DATA_ADMISSAO (datetime)
    }

}
