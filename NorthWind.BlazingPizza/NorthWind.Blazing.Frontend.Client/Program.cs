using NorthWind.Blazing.Frontend.BusinessObjects.Options;
using NorthWind.BlazingPizza.Frontend.IoC;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddFrontendServices(
    blazingPizzaOptions =>
    builder.Configuration.GetRequiredSection(BlazingPizzaOptions.SectionKey)
    .Bind(blazingPizzaOptions));


await builder.Build().RunAsync();
