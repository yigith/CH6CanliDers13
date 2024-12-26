# CH6 - Canlı Ders 13

## Custom Middleware
### Örnek 1: Program.cs
```
app.Use(async (context, next) =>
{
    // your code here ...

    // Call the next delegate/middleware in the pipeline.
    await next(context);
});
```

### Örnek 2: CustomMiddleware.cs
```
public class CustomMiddleware
{
    private readonly RequestDelegate _next;

    public CustomMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        

        // Call the next delegate/middleware in the pipeline.
        await _next(context);
    }
}
```

## Kaynaklar
- https://learn.microsoft.com/en-us/aspnet/core/fundamentals/middleware/write?view=aspnetcore-8.0
- https://learn.microsoft.com/en-us/aspnet/core/fundamentals/localization?view=aspnetcore-8.0
- https://learn.microsoft.com/en-us/aspnet/core/mvc/controllers/filters?view=aspnetcore-8.0
