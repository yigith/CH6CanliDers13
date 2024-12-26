namespace MiddlewareOrnek.Middlewares
{
    public class DilTercihiMiddleware
    {
        private readonly RequestDelegate _next;

        public DilTercihiMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            string acceptLanguage = context.Request.Headers["Accept-Language"].ToString();

            string culture = acceptLanguage.Split(',')[0];
            string lang = culture.Split('-')[0];

            context.Items["culture"] = culture;
            context.Items["lang"] = lang;

            await _next(context);
        }
    }
}
