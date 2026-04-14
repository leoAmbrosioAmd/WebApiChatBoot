namespace WebApiChatBoot.Models
{
    public class TabelaPrecoModel
    {
        public int NUMERO_REGISTRO { get; set; }
        public short CODIGO_PLANO { get; set; }               // smallint
        public short CODIGO_TABELA_PRECO { get; set; }        // smallint
        public short IDADE_MINIMA { get; set; }               // smallint
        public short IDADE_MAXIMA { get; set; }               // smallint
        public decimal VALOR_PLANO { get; set; }
        public string? Tipo_Relacao_Dependencia { get; set; } // char(1)
        public string? INFORMACOES_LOG_I { get; set; }
        public string? INFORMACOES_LOG_A { get; set; }
        public decimal? VALOR_NET { get; set; }
        public int? CODIGO_GRUPO_CONTRATO { get; set; }       // int (FK)
        public string? NOME_TABELA { get; set; }
        public string? TIPO_CONTRATO_ESTIPULADO { get; set; } // char(2)
        public string? ID_INSTANCIA_PROCESSO { get; set; }    // varchar(10)
    }
}
