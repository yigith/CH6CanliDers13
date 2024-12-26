using MiddlewareOrnek.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

// Basit Bir Middleware
app.Use(async (context, next) =>
{
    // zar atalým
    int zar = new Random().Next(1, 7);
    context.Items["Zar"] = zar;

    await next(context);
});

// app.UseMiddleware<DilTercihiMiddleware>();
app.UseDilTercihi();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
