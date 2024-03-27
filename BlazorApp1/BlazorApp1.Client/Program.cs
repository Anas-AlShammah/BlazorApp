using BlazorApp1.Core.Interfaces;
using BlazorApp1.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress =new Uri(builder.HostEnvironment.BaseAddress)
});
builder.Services.AddScoped<IGame, ClientGameServices>();

await builder.Build().RunAsync();
