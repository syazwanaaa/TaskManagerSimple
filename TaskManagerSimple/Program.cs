using TaskManagerSimple.Components;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

// Tell the app to use <App /> from Components
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();


app.Run();
