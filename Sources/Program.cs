using BlazorPlayground.Areas.QuickGrid.Services;
using BlazorPlayground.Areas.QuickGrid.Services.Implementation;
using BlazorPlayground.Components;
using BlazorPlayground.Infrastructure.JavaScript.Services;
using BlazorPlayground.Infrastructure.JavaScript.Services.Implementation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<IIndividualsService, IndividualsService>();
builder.Services.AddScoped<IJavaScriptLocator, JavaScriptLocator>();
builder.Services.AddQuickGridEntityFrameworkAdapter();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseAntiforgery();
app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
