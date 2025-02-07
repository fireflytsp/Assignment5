var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

 app.MapControllerRoute(
     name: "default",
     pattern: "{controller=Home}/{action=Homepage}/{id?}"
     );


app.Run();

