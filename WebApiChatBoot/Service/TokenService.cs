using System.Security.Cryptography;
using System.Text;

namespace WebApiChatBoot.Service
{
    public class TokenService
    {

        private readonly string _hashEsperado;

        public TokenService(IConfiguration configuration)
        {
            _hashEsperado = configuration["TokenSettings:ExpectedHash"]
                ?? throw new InvalidOperationException("Token hash not configured.");
        }

        public bool ValidarToken(string tokenRecebido)
        {
            if (string.IsNullOrEmpty(tokenRecebido))
                return false;

            string hashRecebido = GerarHash(tokenRecebido);
            return hashRecebido == _hashEsperado;
        }

        public string GerarHashParaSenha(string senha)
        {
            return GerarHash(senha);
        }

        private string GerarHash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}