using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WeatherSamplerBlazorApp;
using WeatherSamplerBlazorApp.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// HttpClient for API calls
builder.Services.AddScoped(sp => new HttpClient 
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) 
});

// Register services
builder.Services.AddScoped<ApiCaller>();
builder.Services.AddSingleton<PlaceStorage>();
builder.Services.AddScoped<WeatherState>();


await builder.Build().RunAsync();
