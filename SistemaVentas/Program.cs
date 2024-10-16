
using SistemaVentas.Core.Application.Helpers;
using SistemaVentas.Infraestructure.Persistence;
using SistemaVentas.Infrastructure.Identity;
using SistemaVentas.Infrastructure.Persistence;
using SistemaVentas.Infrastructure.Shared;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSession();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddTransient<UserSessionHelper>();

//services
builder.Services.AddPersistenceLayer(builder.Configuration);
builder.Services.AddApplicationLayer(builder.Configuration);
builder.Services.AddIdentityDependencyWeb(builder.Configuration);
builder.Services.AddSharedInfrastructure(builder.Configuration);
// Add services to the container.
builder.Services.AddControllersWithViews();



var app = builder.Build();
//RunExtensions the seeds
await app.AddIdentitySeeds();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//Sesiones
app.UseSession();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=user}/{action=login}/{id?}");

app.Run();

