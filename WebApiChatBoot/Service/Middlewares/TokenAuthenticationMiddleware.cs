namespace WebApiChatBoot.Service.Middlewares
{
    public class TokenAuthenticationMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<TokenAuthenticationMiddleware> _logger;
        private readonly TokenService _tokenService;

        public TokenAuthenticationMiddleware(RequestDelegate next, ILogger<TokenAuthenticationMiddleware> logger, TokenService tokenService)
        {
            _next = next;
            _logger = logger;
            _tokenService = tokenService;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Libera Swagger e endpoint de geração de hash
            if (context.Request.Path.StartsWithSegments("/swagger") ||
                context.Request.Path.StartsWithSegments("/api/dev"))
            {
                await _next(context);
                return;
            }

            if (!context.Request.Headers.TryGetValue("Authorization", out var tokenHeader))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Token não fornecido");
                return;
            }

            var token = tokenHeader.ToString().Replace("Bearer ", "").Trim();

            if (!_tokenService.ValidarToken(token))
            {
                context.Response.StatusCode = 401;
                await context.Response.WriteAsync("Token inválido");
                return;
            }

            await _next(context);
        }
    }
}