using core;
using Microsoft.AspNetCore.Localization;
using System.Globalization;
using webLoyal.Authorization;

var builder = WebApplication.CreateBuilder(args);
var supportedCultures = new[]
{
    new CultureInfo("en-US"),
    new CultureInfo("es"),
    // Agrega otros idiomas compatibles aquí
};

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.InitializerCore();
builder.Services.AddLocalization(options => options.ResourcesPath = "/Resources/language");
builder.Services.AddMvc().AddViewLocalization().AddDataAnnotationsLocalization();
builder.Services.AddSession(options => { options.IdleTimeout = TimeSpan.FromMinutes(30); });
builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add(new CustomAuthorizeFilter());
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseRequestLocalization(new RequestLocalizationOptions
{
    DefaultRequestCulture = new RequestCulture("en-US"),
    SupportedCultures = supportedCultures,
    SupportedUICultures = supportedCultures
});
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();
app.UseRouting();


app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Auth}/{action=index}");

app.Run();
