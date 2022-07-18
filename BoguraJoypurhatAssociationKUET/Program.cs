using BoguraJoypurhatAssociationKUET.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using BoguraJoypurhatAssociationKUET.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);


var connectionString = builder.Configuration.GetConnectionString("LoginDbContextConnection") ?? throw new InvalidOperationException("Connection string 'LoginDbContextConnection' not found.");

builder.Services.AddDbContext<LoginDbContext>(options =>
    options.UseSqlServer(connectionString)); ;

builder.Services.AddDefaultIdentity<LoggedinUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<LoginDbContext>(); ;
//var connectionString = builder.Configuration.GetConnectionString("LoginDbContextConnection") ?? throw new InvalidOperationException("Connection string 'LoginDbContextConnection' not found.");

//builder.Services.AddDbContext<LoginDbContext>(options =>
//    options.UseSqlServer(connectionString));;

//builder.Services.AddDefaultIdentity<loggedinUser>(options => options.SignIn.RequireConfirmedAccount = false)
//    .AddEntityFrameworkStores<LoginDbContext>();;

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString)); ;







// Add services to the container.
//builder.Services.AddControllersWithViews();

//builder.Services.AddDbContext<ApplicationDbContext>(options=>options.UseSqlServer(
//    builder.Configuration.GetConnectionString("DefaultConnection")
//    ));

//builder.Services.AddDefaultIdentity<LoggedinUser>(options => options.SignIn.RequireConfirmedAccount = true)
//    .AddEntityFrameworkStores<LoginDbContext>();
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
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
