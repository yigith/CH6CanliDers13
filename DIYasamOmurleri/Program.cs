using DIYasamOmurleri.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// zaman servisimizi hizmetler kutusuna ekleyelim

// TimeService nesnesi SADECE 1 kere üretilir
//builder.Services.AddSingleton<TimeService>();

// Her istek için yeni bir nesne üretilir
//builder.Services.AddScoped<TimeService>();

// Ayný istek içinde dahi olsa her hizmet talebinde
// yep yeni bir instance (nesne) üretilir
builder.Services.AddTransient<TimeService>();

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

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

// https://learn.microsoft.com/en-us/dotnet/fundamentals/networking/http/httpclient-guidelines#recommended-use