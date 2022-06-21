using WAF.API;
using WAF.API.Native.API.Web;
using WAF.API.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// WAF Configuration
WAF.ApiConfig.RegisterDataModel();
var configWAFRuntime = builder.Configuration.GetSection("WAFRuntime");
var configWAF = builder.Configuration.GetSection("WAF");
var configWAFAdmin = builder.Configuration.GetSection("WAFAdminUI");

// WAF Services
builder.AddWAFRuntime<WAF.API.NativeRuntime>();
builder.AddWAFRouting(configWAF);
builder.AddWAFAdminUI(configWAFAdmin);
builder.AddWAFNativeContext();
builder.AddWAFAuthenticationAndAuthorization(configWAF);
builder.AddWAFIdentity(configWAF);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

// WAF Use
app.UseWAFAdminUI(configWAFAdmin); // configure admin UI
app.UseWAFRuntime(configWAFRuntime); // connect db, initalize
app.UseWAFRouting(configWAF); // configure routing

// ROUTING
app.MapControllerRoute(
    name: "API",
    pattern: "API/{controller=Base}/{action=Index}/{id?}");

app.Run();
