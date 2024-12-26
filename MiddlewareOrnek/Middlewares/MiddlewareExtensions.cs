namespace MiddlewareOrnek.Middlewares
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseDilTercihi(this IApplicationBuilder app)
        {
            app.UseMiddleware<DilTercihiMiddleware>();

            return app;
        }
    }
}
