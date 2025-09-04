using Backend.Application.Interfaces;
using Backend.Application.Services;
using Backend.Domain.Models.Entity;
using Backend.Infrastructure.CommandSide;
using Backend.Infrastructure.Context;
using Backend.Infrastructure.Interfaces.CommandSide;
using Backend.Infrastructure.Interfaces.Context;
using Backend.Infrastructure.Interfaces.QuerySide;
using Backend.Infrastructure.QuerySide;
using PrjBlazor.VendaAutomoveis.Components;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IRepositorioGenerico<Usuario>, RepositorioGenerico<Usuario>>();
builder.Services.AddScoped<IConsultaGenerica<Usuario>, ConsultaGenerica<Usuario>>();
builder.Services.AddScoped<IContext, Context>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();