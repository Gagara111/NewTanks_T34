using NewTanks.Game;
using NewTanks.Game.Interfaces;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
    .AddControllersWithViews()
    .AddRazorOptions(x =>
    {
        x.ViewLocationFormats.Add("/PartialViews/{0}.cshtml");
    });
builder.Services.AddSingleton<IProfile> (x => new Profile());
builder.Services.AddSingleton<IGameManager> (x => {
    var gameManager = new GameManager ();
    gameManager.InitGame(null);
    return gameManager;
    });



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
