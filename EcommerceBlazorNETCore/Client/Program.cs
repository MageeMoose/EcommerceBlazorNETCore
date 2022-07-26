global using EcommerceBlazorNETCore.Shared;
global using System.Net.Http.Json;
global using EcommerceBlazorNETCore.Client.Service.ProductService;
global using EcommerceBlazorNETCore.Client.Service.CategoryService;
using EcommerceBlazorNETCore.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
await builder.Build().RunAsync();
