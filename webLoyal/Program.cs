using core;
using core.Service;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;
using System.Globalization;

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
builder.Services.AddSession();

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
    pattern: "{controller=Auth}/{action=Index}/{id?}");

app.Run();
