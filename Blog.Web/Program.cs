using Blog.Data.Context;
using Blog.Data.Extensions;
using Blog.Entity.Entities;
using Blog.Service.Describers;
using Blog.Service.Extensions;
using Blog.Web.Filters.ArticleVisitors;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NToastNotify;

var builder = WebApplication.CreateBuilder(args);


builder.Services.LoadDataLayerExtension(builder.Configuration);
builder.Services.LoadServiceLayerExtension(builder.Configuration);
builder.Services.AddSession();
// Add services to the container.
builder.Services.AddControllersWithViews(opt => { 
    opt.Filters.Add<ArticleVisitorFilter>();
}).AddNToastNotifyToastr(new NToastNotify.ToastrOptions
{
    PositionClass = ToastPositions.TopRight,
    TimeOut = 3000
}).AddRazorRuntimeCompilation();


//Identity sistemi ekliyor sonra gerekli servisleri ekliyoruz.
builder.Services.AddIdentity<TUser, TRole>(opt =>
{
    opt.Password.RequireNonAlphanumeric = false;
    opt.Password.RequireLowercase = false;
    opt.Password.RequireUppercase = false;

}).AddRoleManager<RoleManager<TRole>>().AddErrorDescriber<CustomIdentityErrorDescriber>() // Rol y�netimi ile ilgili servis
    .AddEntityFrameworkStores<AppDbContext>() // EF core ile ba�lant� kuran servis
    .AddDefaultTokenProviders(); // Token i�lemlerini y�neten servis


//Auth i�lemleriyle ilgili cookieleri yap�land�r�yoruz.
builder.Services.ConfigureApplicationCookie(config =>
{
    config.LoginPath = new PathString("/Admin/Auth/Login");
    config.LogoutPath = new PathString("/Admin/Auth/Logout");
    config.AccessDeniedPath = new PathString("/Admin/Auth/AccessDenied");
    config.Cookie = new CookieBuilder // Cookie ile ilgili ayarlar� yap�land�r�r.
    {
        Name = "Blog",
        HttpOnly = true,
        SameSite = SameSiteMode.Strict,
        SecurePolicy = CookieSecurePolicy.SameAsRequest // hem http hem https destekler. kullan�c� sec pol ne ise o
    };
    config.SlidingExpiration = true;
    config.ExpireTimeSpan = TimeSpan.FromDays(7);
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseNToastNotify();
app.UseHttpsRedirection();
app.UseRouting();
app.UseSession();
app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();


app.UseEndpoints(endpoints => {
    endpoints.MapAreaControllerRoute(name:"Admin",areaName:"Admin",pattern:"Admin/{controller=Home}/{action=index}/{id?}");
    endpoints.MapDefaultControllerRoute();
});


app.Run();
