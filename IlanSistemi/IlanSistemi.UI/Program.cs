using IlanSistemi.Business.Abstract;
using IlanSistemi.Business.Concrete;
using IlanSistemi.DataAccess.Abstract;
using IlanSistemi.DataAccess.Concrete;
using IlanSistemi.DataAccess.EntityFramework;
using IlanSistemi.Entities.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<DataContext>();
builder.Services.AddIdentity<Users, AdminRole>().AddEntityFrameworkStores<DataContext>();
builder.Services.AddControllersWithViews();

//DependencyInjections
builder.Services.AddScoped<IUserDal, EfUserDal>();
builder.Services.AddScoped<IUserService, UserManager>();

builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();

builder.Services.AddScoped<IAdvertDal, EfAdvertDal>();
builder.Services.AddScoped<IAdvertService, AdvertManager>();

builder.Services.AddScoped<IAdvertImageDal, EfAdvertImageDal>();
builder.Services.AddScoped<IAdvertImageService, AdvertImageManager>();

builder.Services.AddScoped<ICategoryAdvertDal, EfCategoryAdvertDal>();
builder.Services.AddScoped<ICategoryAdvertService, CategoryAdvertManager>();



builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder()
                   .RequireAuthenticatedUser()
                   .Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});

builder.Services.AddMvc();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(100);
  //  options.AccessDeniedPath = "/ErrorPage/Index/";
    options.LoginPath = "/Default/Index/";
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404/");

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Default}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Default}/{action=Index}/{id?}"
    );
});



app.Run();
