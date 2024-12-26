using Microsoft.AspNetCore.Mvc.Filters;

namespace ActionFilterOrnek.Filters
{
    public class YonlenAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Eğer istek geldiğinde query string olarak (?yonlen=google)
            // varsa google'a yönlen
            string? yonlen = context.HttpContext.Request.Query["yonlen"];

            if (yonlen == null) return;

            string url;
            switch (yonlen)
            {
                case "google":
                    url = "https://google.com";
                    break;
                case "bing":
                    url = "https://bing.com";
                    break;
                case "yandex":
                    url = "https://yandex.com";
                    break;
                default:
                    return;
            }

            context.HttpContext.Response.Redirect(url);
        }
    }
}
