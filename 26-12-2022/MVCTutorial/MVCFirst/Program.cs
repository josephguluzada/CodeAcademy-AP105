// Add service this container
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();


// Request pipeline (middlewares)
var app = builder.Build();

//app.MapGet("/home", () => "AB102");


app.MapControllerRoute(
        name: "default",
        pattern: "{controller=home}/{action=index}/{id?}"
    );

app.MapControllerRoute(
        name: "ab102",
        pattern: "contact-us",
        defaults: new { controller = "home", action = "contact" }
    );

app.MapControllerRoute(
        name: "ab1025",
        pattern: "about-us",
        defaults: new { controller = "home", action = "about" }
    );


app.Run();
